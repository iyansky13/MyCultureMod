using HarmonyLib;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.CampaignBehaviors;
using TaleWorlds.CampaignSystem.CharacterCreationContent;
using TaleWorlds.Core;
using System.Collections.Generic;
using NavalDLC.CampaignBehaviors;

namespace MyCultureMod
{
    // Patch ALL the Nord condition methods
    [HarmonyPatch(typeof(NavalCharacterCreationCampaignBehavior))]
    [HarmonyPatch("NordHersirNarrativeOptionOnCondition")]
    public class NordHersirConditionPatch
    {
        private static readonly HashSet<string> AllowedCultures = new HashSet<string>
        {
            "saxon"
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
    [HarmonyPatch("NordMarketTraderNarrativeOptionOnCondition")]
    public class NordMarketTraderConditionPatch
    {
        private static readonly HashSet<string> AllowedCultures = new HashSet<string>
        {
            "saxon"
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
    [HarmonyPatch("NordSkaldNarrativeOptionOnCondition")]
    public class NordSkaldConditionPatch
    {
        private static readonly HashSet<string> AllowedCultures = new HashSet<string>
        {
            "saxon"
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
    [HarmonyPatch("NordBlacksmithNarrativeOptionOnCondition")]
    public class NordBlacksmithConditionPatch
    {
        private static readonly HashSet<string> AllowedCultures = new HashSet<string>
        {
            "saxon"
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
    [HarmonyPatch("NordHunterNarrativeOptionOnCondition")]
    public class NordHunterConditionPatch
    {
        private static readonly HashSet<string> AllowedCultures = new HashSet<string>
        {
            "saxon"
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
    [HarmonyPatch("NordVagabondNarrativeOptionOnCondition")]
    public class NordVagabondConditionPatch
    {
        private static readonly HashSet<string> AllowedCultures = new HashSet<string>
        {
            "saxon"
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
    [HarmonyPatch("NordSailorsNarrativeOptionOnCondition")]
    public class NordSailorsConditionPatch
    {
        private static readonly HashSet<string> AllowedCultures = new HashSet<string>
        {
            "saxon"
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
    [HarmonyPatch("NordShipwrightsNarrativeOptionOnCondition")]
    public class NordShipwrightsConditionPatch
    {
        private static readonly HashSet<string> AllowedCultures = new HashSet<string>
        {
            "saxon"
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