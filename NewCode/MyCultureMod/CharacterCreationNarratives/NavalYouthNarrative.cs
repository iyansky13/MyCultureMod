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
    [HarmonyPatch("YouthCoastalDefenderNarrativeOptionOnCondition")]
    public class YouthCoastalDefenderConditionPatch
    {
        private static readonly HashSet<string> AllowedCultures = new HashSet<string>
        {
            "barbarian",            
            // Add more cultures here
            // Battania
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
    [HarmonyPatch("YouthCrewedAGalleyNarrativeOptionOnCondition")]
    public class YouthCrewedAGalleyConditionPatch
    {
        private static readonly HashSet<string> AllowedCultures = new HashSet<string>
        {
            "rhodok",
            "republic"
            // Add more cultures here
            // vlandia // empire
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
    [HarmonyPatch("YouthDeckhandCorsairNarrativeOptionOnCondition")]
    public class YouthDeckhandCorsairConditionPatch
    {
        private static readonly HashSet<string> AllowedCultures = new HashSet<string>
        {
            "sarranid",            
            // Add more cultures here
            // aserai
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
    [HarmonyPatch("YouthNordArtisanOptionOnCondition")]
    public class YouthNordArtisanConditionPatch
    {
        private static readonly HashSet<string> AllowedCultures = new HashSet<string>
        {
            "saxon",            
            // Add more cultures here
            // nord
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
    [HarmonyPatch("YouthNordGuardOptionOnCondition")]
    public class YouthNordGuardConditionPatch
    {
        private static readonly HashSet<string> AllowedCultures = new HashSet<string>
        {
            "saxon",            
            // Add more cultures here
            // nord
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
    [HarmonyPatch("YouthNordInfantryOptionOnCondition")]
    public class YouthNordInfantryConditionPatch
    {
        private static readonly HashSet<string> AllowedCultures = new HashSet<string>
        {
            "saxon",            
            // Add more cultures here
            // nord
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
    [HarmonyPatch("YouthNordMercenaryOptionOnCondition")]
    public class YouthNordMercenaryConditionPatch
    {
        private static readonly HashSet<string> AllowedCultures = new HashSet<string>
        {
            "saxon",            
            // Add more cultures here
            // nord
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
    [HarmonyPatch("YouthNordSkirmisherOptionOnCondition")]
    public class YouthNordSkirmisherConditionPatch
    {
        private static readonly HashSet<string> AllowedCultures = new HashSet<string>
        {
            "saxon",            
            // Add more cultures here
            // nord
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
    [HarmonyPatch("YouthNordVagabondOptionOnCondition")]
    public class YouthNordVagabondConditionPatch
    {
        private static readonly HashSet<string> AllowedCultures = new HashSet<string>
        {
            "saxon",            
            // Add more cultures here
            // nord
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
    [HarmonyPatch("YouthRaidedRiverTrafficNarrativeOptionOnCondition")]
    public class YouthRaidedRiverTrafficConditionPatch
    {
        private static readonly HashSet<string> AllowedCultures = new HashSet<string>
        {
            "khergit",            
            // Add more cultures here
            // khuzait
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
    [HarmonyPatch("YouthRowedRiverTraderNarrativeOptionOnCondition")]
    public class YouthRowedRiverTraderConditionPatch
    {
        private static readonly HashSet<string> AllowedCultures = new HashSet<string>
        {
            "vaegir",            
            // Add more cultures here
            // sturgia
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
    [HarmonyPatch("YouthServeRaiderShipNarrativeOptionOnCondition")]
    public class YouthServeRaiderShipTraderConditionPatch
    {
        private static readonly HashSet<string> AllowedCultures = new HashSet<string>
        {
            "saxon",            
            // Add more cultures here
            // nord
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