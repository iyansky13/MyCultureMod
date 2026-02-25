using HarmonyLib;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.GameComponents;
using TaleWorlds.Core;
using TaleWorlds.Library;

namespace MyCultureMod
{
    /// <summary>
    /// Represents a weighted troop option
    /// </summary>
    public class WeightedTroop
    {
        public string TroopId { get; set; }
        public float Weight { get; set; }

        public WeightedTroop() { }

        public WeightedTroop(string troopId, float weight)
        {
            TroopId = troopId;
            Weight = weight;
        }
    }

    /// <summary>
    /// Loads recruit pool configuration from XML files
    /// </summary>
    public static class RecruitPoolLoader
    {
        private static Dictionary<string, List<WeightedTroop>> _normalRecruitPools;
        private static Dictionary<string, List<WeightedTroop>> _eliteRecruitPools;
        private static bool _isLoaded = false;

        public static Dictionary<string, List<WeightedTroop>> NormalRecruitPools
        {
            get
            {
                if (!_isLoaded) LoadRecruitPools();
                return _normalRecruitPools;
            }
        }

        public static Dictionary<string, List<WeightedTroop>> EliteRecruitPools
        {
            get
            {
                if (!_isLoaded) LoadRecruitPools();
                return _eliteRecruitPools;
            }
        }

        /// <summary>
        /// Loads recruit pools from XML files in the mod's ModuleData folder
        /// </summary>
        public static void LoadRecruitPools()
        {
            if (_isLoaded) return;

            _normalRecruitPools = new Dictionary<string, List<WeightedTroop>>();
            _eliteRecruitPools = new Dictionary<string, List<WeightedTroop>>();

            try
            {
                // Get the mod's directory path
                string modPath = BasePath.Name + "Modules/MyCultureMod/Config/";

                // Load normal recruit pools
                string normalPoolPath = modPath + "recruit_pools.xml";
                if (File.Exists(normalPoolPath))
                {
                    LoadPoolsFromXml(normalPoolPath, _normalRecruitPools, "normal");
                }
                else
                {
                    InformationManager.DisplayMessage(new InformationMessage(
                        "[Recruit Pool] WARNING: recruit_pools.xml not found, using defaults"));
                    LoadDefaultNormalPools();
                }

                // Load elite recruit pools
                string elitePoolPath = modPath + "elite_recruit_pools.xml";
                if (File.Exists(elitePoolPath))
                {
                    LoadPoolsFromXml(elitePoolPath, _eliteRecruitPools, "elite");
                }
                else
                {
                    InformationManager.DisplayMessage(new InformationMessage(
                        "[Recruit Pool] WARNING: elite_recruit_pools.xml not found, using defaults"));
                    LoadDefaultElitePools();
                }

                _isLoaded = true;
                InformationManager.DisplayMessage(new InformationMessage(
                    $"[Recruit Pool] Loaded {_normalRecruitPools.Count} normal pools and {_eliteRecruitPools.Count} elite pools"));
            }
            catch (Exception ex)
            {
                InformationManager.DisplayMessage(new InformationMessage(
                    $"[Recruit Pool] ERROR loading XML: {ex.Message}"));
                LoadDefaultNormalPools();
                LoadDefaultElitePools();
                _isLoaded = true;
            }
        }

        /// <summary>
        /// Loads recruit pools from an XML file
        /// </summary>
        private static void LoadPoolsFromXml(string xmlPath, Dictionary<string, List<WeightedTroop>> targetDict, string poolType)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(xmlPath);

            XmlNode root = doc.DocumentElement;
            if (root == null || root.Name != "RecruitPools")
            {
                throw new Exception($"Invalid XML root element in {xmlPath}");
            }

            foreach (XmlNode cultureNode in root.ChildNodes)
            {
                if (cultureNode.NodeType != XmlNodeType.Element || cultureNode.Name != "Culture")
                    continue;

                // Get culture ID
                string cultureId = cultureNode.Attributes?["id"]?.Value;
                if (string.IsNullOrEmpty(cultureId))
                {
                    InformationManager.DisplayMessage(new InformationMessage(
                        $"[Recruit Pool] WARNING: Culture node missing 'id' attribute in {poolType} pools"));
                    continue;
                }

                // Get troop list
                List<WeightedTroop> troops = new List<WeightedTroop>();

                foreach (XmlNode troopNode in cultureNode.ChildNodes)
                {
                    if (troopNode.NodeType != XmlNodeType.Element || troopNode.Name != "Troop")
                        continue;

                    string troopId = troopNode.Attributes?["id"]?.Value;
                    string weightStr = troopNode.Attributes?["weight"]?.Value;

                    if (string.IsNullOrEmpty(troopId))
                    {
                        InformationManager.DisplayMessage(new InformationMessage(
                            $"[Recruit Pool] WARNING: Troop node missing 'id' in culture '{cultureId}'"));
                        continue;
                    }

                    float weight = 100f; // Default weight
                    if (!string.IsNullOrEmpty(weightStr) && !float.TryParse(weightStr, out weight))
                    {
                        InformationManager.DisplayMessage(new InformationMessage(
                            $"[Recruit Pool] WARNING: Invalid weight '{weightStr}' for troop '{troopId}', using default 100"));
                        weight = 100f;
                    }

                    troops.Add(new WeightedTroop(troopId, weight));
                }

                if (troops.Count > 0)
                {
                    targetDict[cultureId] = troops;
                }
                else
                {
                    InformationManager.DisplayMessage(new InformationMessage(
                        $"[Recruit Pool] WARNING: No valid troops found for culture '{cultureId}'"));
                }
            }
        }

        /// <summary>
        /// Fallback default normal pools (same as your original hardcoded values)
        /// </summary>
        private static void LoadDefaultNormalPools()
        {
            _normalRecruitPools = new Dictionary<string, List<WeightedTroop>>
            {
                { "empire", new List<WeightedTroop>
                    {
                        new WeightedTroop("imperial_recruit", 70f),
                        new WeightedTroop("imperial_infantryman", 30f)
                    }
                },
                { "sturgia", new List<WeightedTroop>
                    {
                        new WeightedTroop("sturgian_recruit", 70f),
                        new WeightedTroop("sturgian_woodsman", 30f)
                    }
                },
                { "aserai", new List<WeightedTroop>
                    {
                        new WeightedTroop("aserai_recruit", 70f),
                        new WeightedTroop("aserai_tribal_warrior", 30f)
                    }
                },
                { "vlandia", new List<WeightedTroop>
                    {
                        new WeightedTroop("vlandian_recruit", 70f),
                        new WeightedTroop("vlandian_levy", 30f)
                    }
                },
                { "battania", new List<WeightedTroop>
                    {
                        new WeightedTroop("battanian_clansman", 70f),
                        new WeightedTroop("battanian_volunteer", 30f)
                    }
                },
                { "khuzait", new List<WeightedTroop>
                    {
                        new WeightedTroop("khuzait_tribesman", 70f),
                        new WeightedTroop("khuzait_spearman", 30f)
                    }
                },
                { "sarranid", new List<WeightedTroop>
                    {
                        new WeightedTroop("aserai_recruit", 60f),
                        new WeightedTroop("aserai_tribal_warrior", 25f),
                        new WeightedTroop("aserai_youth", 15f)
                    }
                },
            };
        }

        /// <summary>
        /// Fallback default elite pools
        /// </summary>
        private static void LoadDefaultElitePools()
        {
            _eliteRecruitPools = new Dictionary<string, List<WeightedTroop>>
            {
                { "empire", new List<WeightedTroop>
                    {
                        new WeightedTroop("imperial_infantryman", 60f),
                        new WeightedTroop("imperial_archer", 40f)
                    }
                },
                { "sturgia", new List<WeightedTroop>
                    {
                        new WeightedTroop("sturgian_soldier", 60f),
                        new WeightedTroop("sturgian_hunter", 40f)
                    }
                },
                { "aserai", new List<WeightedTroop>
                    {
                        new WeightedTroop("aserai_tribesman", 50f),
                        new WeightedTroop("aserai_skirmisher", 30f),
                        new WeightedTroop("aserai_faris", 20f)
                    }
                },
                { "sarranid", new List<WeightedTroop>
                    {
                        new WeightedTroop("aserai_tribesman", 40f),
                        new WeightedTroop("aserai_skirmisher", 30f),
                        new WeightedTroop("aserai_faris", 30f)
                    }
                },
            };
        }
    }

    /// <summary>
    /// Harmony patch for GetBasicVolunteer - now loads from XML
    /// </summary>
    [HarmonyPatch(typeof(DefaultVolunteerModel))]
    [HarmonyPatch("GetBasicVolunteer")]
    public class GetBasicVolunteerPatch
    {
        /// <summary>
        /// Selects a random troop from a weighted pool
        /// </summary>
        private static string SelectWeightedRandomTroop(List<WeightedTroop> weightedTroops)
        {
            if (weightedTroops == null || weightedTroops.Count == 0)
            {
                return null;
            }

            if (weightedTroops.Count == 1)
            {
                return weightedTroops[0].TroopId;
            }

            float totalWeight = weightedTroops.Sum(wt => wt.Weight);
            float randomValue = MBRandom.RandomFloat * totalWeight;

            float cumulativeWeight = 0f;
            foreach (var weightedTroop in weightedTroops)
            {
                cumulativeWeight += weightedTroop.Weight;
                if (randomValue <= cumulativeWeight)
                {
                    return weightedTroop.TroopId;
                }
            }

            return weightedTroops[0].TroopId;
        }

        /// <summary>
        /// Postfix patch - loads recruit pools from XML files
        /// </summary>
        public static void Postfix(ref CharacterObject __result, Hero sellerHero)
        {
            if (sellerHero == null || sellerHero.CurrentSettlement == null)
            {
                return;
            }

            // Check if this should be an elite troop
            bool shouldBeElite = sellerHero.IsRuralNotable &&
                                 sellerHero.CurrentSettlement.IsVillage &&
                                 sellerHero.CurrentSettlement.Village.Bound != null &&
                                 sellerHero.CurrentSettlement.Village.Bound.IsCastle;

            string settlementCultureId = sellerHero.CurrentSettlement.Culture?.StringId;

            if (string.IsNullOrEmpty(settlementCultureId))
            {
                return;
            }

            // Get the appropriate pool from XML-loaded data
            Dictionary<string, List<WeightedTroop>> poolToUse = shouldBeElite
                ? RecruitPoolLoader.EliteRecruitPools
                : RecruitPoolLoader.NormalRecruitPools;

            if (poolToUse.TryGetValue(settlementCultureId, out List<WeightedTroop> recruitPool))
            {
                string selectedTroopId = SelectWeightedRandomTroop(recruitPool);

                if (!string.IsNullOrEmpty(selectedTroopId))
                {
                    CharacterObject customTroop = CharacterObject.Find(selectedTroopId);

                    if (customTroop != null)
                    {
                        __result = customTroop;
                    }
                    else
                    {
                        InformationManager.DisplayMessage(new InformationMessage(
                            $"[Recruit Error] Troop '{selectedTroopId}' not found for culture '{settlementCultureId}'"));
                    }
                }
            }
        }
    }
}
