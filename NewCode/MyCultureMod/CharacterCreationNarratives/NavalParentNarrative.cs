using HarmonyLib;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.CampaignBehaviors;
using TaleWorlds.CampaignSystem.CharacterCreationContent;
using TaleWorlds.Core;
using System.Collections.Generic;
using NavalDLC.CampaignBehaviors;

namespace MyCultureMod
{
    [HarmonyPatch(typeof(NavalCharacterCreationCampaignBehavior))]
    [HarmonyPatch("AseraiCorsairTradersNarrativeOptionOnCondition")]
    public class AseraiCorsairConditionPatch
    {
        private static readonly HashSet<string> AllowedCultures = new HashSet<string>
        {
            "sarranid"
            // Add more cultures here
            //aserai
        };

        public static void Postfix(ref bool __result, CharacterCreationManager characterCreationManager)
        {
            string cultureId = characterCreationManager?.CharacterCreationContent?.SelectedCulture?.StringId;
            if (cultureId != null && AllowedCultures.Contains(cultureId))
            {
                __result = true;
            }
        }
    }

    [HarmonyPatch(typeof(NavalCharacterCreationCampaignBehavior))]
    [HarmonyPatch("AseraiFerrymanNarrativeOptionOnCondition")]
    public class AseraiFerrymanConditionPatch
    {
        private static readonly HashSet<string> AllowedCultures = new HashSet<string>
        {
            "sarranid"
            // Add more cultures here
            //aserai
        };

        public static void Postfix(ref bool __result, CharacterCreationManager characterCreationManager)
        {
            string cultureId = characterCreationManager?.CharacterCreationContent?.SelectedCulture?.StringId;
            if (cultureId != null && AllowedCultures.Contains(cultureId))
            {
                __result = true;
            }
        }
    }

    [HarmonyPatch(typeof(NavalCharacterCreationCampaignBehavior))]
    [HarmonyPatch("BattaniaCurrachSailorsNarrativeOptionOnCondition")]
    public class BattaniaCurrachSailorConditionPatch
    {
        private static readonly HashSet<string> AllowedCultures = new HashSet<string>
        {
            "barbarian"
            // Add more cultures here
            // battania
        };

        public static void Postfix(ref bool __result, CharacterCreationManager characterCreationManager)
        {
            string cultureId = characterCreationManager?.CharacterCreationContent?.SelectedCulture?.StringId;
            if (cultureId != null && AllowedCultures.Contains(cultureId))
            {
                __result = true;
            }
        }
    }

    [HarmonyPatch(typeof(NavalCharacterCreationCampaignBehavior))]
    [HarmonyPatch("BattaniaGuardianOfTheLakeNarrativeOptionOnCondition")]
    public class BattaniaGuardianLakeConditionPatch
    {
        private static readonly HashSet<string> AllowedCultures = new HashSet<string>
        {
            "barbarian"
            // Add more cultures here
            // battania
        };

        public static void Postfix(ref bool __result, CharacterCreationManager characterCreationManager)
        {
            string cultureId = characterCreationManager?.CharacterCreationContent?.SelectedCulture?.StringId;
            if (cultureId != null && AllowedCultures.Contains(cultureId))
            {
                __result = true;
            }
        }
    }

    [HarmonyPatch(typeof(NavalCharacterCreationCampaignBehavior))]
    [HarmonyPatch("EmpireImperialFleetNarrativeOptionOnCondition")]
    public class EmpireImperialFleetConditionPatch
    {
        private static readonly HashSet<string> AllowedCultures = new HashSet<string>
        {
            "republic"
            // Add more cultures here
        };

        public static void Postfix(ref bool __result, CharacterCreationManager characterCreationManager)
        {
            string cultureId = characterCreationManager?.CharacterCreationContent?.SelectedCulture?.StringId;
            if (cultureId != null && AllowedCultures.Contains(cultureId))
            {
                __result = true;
            }
        }
    }

    [HarmonyPatch(typeof(NavalCharacterCreationCampaignBehavior))]
    [HarmonyPatch("EmpireSmallBoatFishermanNarrativeOptionOnCondition")]
    public class EmpireSmallBoatFishermanConditionPatch
    {
        private static readonly HashSet<string> AllowedCultures = new HashSet<string>
        {
            "republic"
            // Add more cultures here
        };

        public static void Postfix(ref bool __result, CharacterCreationManager characterCreationManager)
        {
            string cultureId = characterCreationManager?.CharacterCreationContent?.SelectedCulture?.StringId;
            if (cultureId != null && AllowedCultures.Contains(cultureId))
            {
                __result = true;
            }
        }
    }

    [HarmonyPatch(typeof(NavalCharacterCreationCampaignBehavior))]
    [HarmonyPatch("KhuzaitRiverForagersNarrativeOptionOnCondition")]
    public class KhuzaitRiverForagerHerderConditionPatch
    {
        private static readonly HashSet<string> AllowedCultures = new HashSet<string>
        {
            "khergit"
            // Add more cultures here
        };

        public static void Postfix(ref bool __result, CharacterCreationManager characterCreationManager)
        {
            string cultureId = characterCreationManager?.CharacterCreationContent?.SelectedCulture?.StringId;
            if (cultureId != null && AllowedCultures.Contains(cultureId))
            {
                __result = true;
            }
        }
    }

    [HarmonyPatch(typeof(NavalCharacterCreationCampaignBehavior))]
    [HarmonyPatch("KhuzaitRiverTradersNarrativeOptionOnCondition")]
    public class KhuzaitRiverTradersHerderConditionPatch
    {
        private static readonly HashSet<string> AllowedCultures = new HashSet<string>
        {
            "khergit"
            // Add more cultures here
        };

        public static void Postfix(ref bool __result, CharacterCreationManager characterCreationManager)
        {
            string cultureId = characterCreationManager?.CharacterCreationContent?.SelectedCulture?.StringId;
            if (cultureId != null && AllowedCultures.Contains(cultureId))
            {
                __result = true;
            }
        }
    }

    [HarmonyPatch(typeof(NavalCharacterCreationCampaignBehavior))]
    [HarmonyPatch("SturgiaRiverFishermanNarrativeOptionOnCondition")]
    public class SturgiaRiverFishermanConditionPatch
    {
        private static readonly HashSet<string> AllowedCultures = new HashSet<string>
        {
            "vaegir"
            // Add more cultures here
        };

        public static void Postfix(ref bool __result, CharacterCreationManager characterCreationManager)
        {
            string cultureId = characterCreationManager?.CharacterCreationContent?.SelectedCulture?.StringId;
            if (cultureId != null && AllowedCultures.Contains(cultureId))
            {
                __result = true;
            }
        }
    }

    [HarmonyPatch(typeof(NavalCharacterCreationCampaignBehavior))]
    [HarmonyPatch("SturgiaShipbuildersNarrativeOptionOnCondition")]
    public class SturgiaShipBuildersConditionPatch
    {
        private static readonly HashSet<string> AllowedCultures = new HashSet<string>
        {
            "vaegir"
            // Add more cultures here
        };

        public static void Postfix(ref bool __result, CharacterCreationManager characterCreationManager)
        {
            string cultureId = characterCreationManager?.CharacterCreationContent?.SelectedCulture?.StringId;
            if (cultureId != null && AllowedCultures.Contains(cultureId))
            {
                __result = true;
            }
        }
    }

    [HarmonyPatch(typeof(NavalCharacterCreationCampaignBehavior))]
    [HarmonyPatch("VlandiaCoastalFishermanNarrativeOptionOnCondition")]
    public class VlandiaCoastalFishermanConditionPatch
    {
        private static readonly HashSet<string> AllowedCultures = new HashSet<string>
        {
            "rhodok"
            // Add more cultures here
        };

        public static void Postfix(ref bool __result, CharacterCreationManager characterCreationManager)
        {
            string cultureId = characterCreationManager?.CharacterCreationContent?.SelectedCulture?.StringId;
            if (cultureId != null && AllowedCultures.Contains(cultureId))
            {
                __result = true;
            }
        }
    }

    [HarmonyPatch(typeof(NavalCharacterCreationCampaignBehavior))]
    [HarmonyPatch("VlandiaDockersNarrativeOptionOnCondition")]
    public class VlandiaDockersConditionPatch
    {
        private static readonly HashSet<string> AllowedCultures = new HashSet<string>
        {
            "rhodok"
            // Add more cultures here
        };

        public static void Postfix(ref bool __result, CharacterCreationManager characterCreationManager)
        {
            string cultureId = characterCreationManager?.CharacterCreationContent?.SelectedCulture?.StringId;
            if (cultureId != null && AllowedCultures.Contains(cultureId))
            {
                __result = true;
            }
        }
    }
}