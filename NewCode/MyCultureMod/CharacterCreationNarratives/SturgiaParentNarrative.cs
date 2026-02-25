using HarmonyLib;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.CampaignBehaviors;
using TaleWorlds.CampaignSystem.CharacterCreationContent;
using TaleWorlds.Core;
using System.Collections.Generic;

namespace MyCultureMod
{
    // Patch ALL the Sturgia condition methods
    [HarmonyPatch(typeof(CharacterCreationCampaignBehavior))]
    [HarmonyPatch("SturgiaCompanionNarrativeOptionOnCondition")]
    public class SturgiaCompanionConditionPatch
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

    [HarmonyPatch(typeof(CharacterCreationCampaignBehavior))]
    [HarmonyPatch("SturgiaTraderNarrativeOptionOnCondition")]
    public class SturgiaTraderConditionPatch
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

    [HarmonyPatch(typeof(CharacterCreationCampaignBehavior))]
    [HarmonyPatch("SturgiaFarmerNarrativeOptionOnCondition")]
    public class SturgiaFarmerConditionPatch
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

    [HarmonyPatch(typeof(CharacterCreationCampaignBehavior))]
    [HarmonyPatch("SturgiaArtisanNarrativeOptionOnCondition")]
    public class SturgiaArtisanConditionPatch
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

    [HarmonyPatch(typeof(CharacterCreationCampaignBehavior))]
    [HarmonyPatch("SturgiaHunterNarrativeOptionOnCondition")]
    public class SturgiaHunterConditionPatch
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

    [HarmonyPatch(typeof(CharacterCreationCampaignBehavior))]
    [HarmonyPatch("SturgiaVagabondNarrativeOptionOnCondition")]
    public class SturgiaVagabondConditionPatch
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

}