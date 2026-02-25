using HarmonyLib;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.CampaignBehaviors;
using TaleWorlds.CampaignSystem.CharacterCreationContent;
using TaleWorlds.Core;
using System.Collections.Generic;

namespace MyCultureMod
{
    // Patch ALL the Khuzait condition methods
    [HarmonyPatch(typeof(CharacterCreationCampaignBehavior))]
    [HarmonyPatch("KhuzaitRetainerNarrativeOptionOnCondition")]
    public class KhuzaitRetainerConditionPatch
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

    [HarmonyPatch(typeof(CharacterCreationCampaignBehavior))]
    [HarmonyPatch("KhuzaitMerchantNarrativeOptionOnCondition")]
    public class KhuzaitMerchantConditionPatch
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

    [HarmonyPatch(typeof(CharacterCreationCampaignBehavior))]
    [HarmonyPatch("KhuzaitHerderNarrativeOptionOnCondition")]
    public class KhuzaitHerderConditionPatch
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

    [HarmonyPatch(typeof(CharacterCreationCampaignBehavior))]
    [HarmonyPatch("KhuzaitFarmerNarrativeOptionOnCondition")]
    public class KhuzaitFarmerConditionPatch
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

    [HarmonyPatch(typeof(CharacterCreationCampaignBehavior))]
    [HarmonyPatch("KhuzaitHealerNarrativeOptionOnCondition")]
    public class KhuzaitHealerConditionPatch
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

    [HarmonyPatch(typeof(CharacterCreationCampaignBehavior))]
    [HarmonyPatch("KhuzaitNomadHerderNarrativeOptionOnCondition")]
    public class KhuzaitNomadHerderConditionPatch
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

}