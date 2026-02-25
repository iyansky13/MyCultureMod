using HarmonyLib;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.CampaignBehaviors;
using TaleWorlds.CampaignSystem.CharacterCreationContent;
using TaleWorlds.Core;
using System.Collections.Generic;

namespace MyCultureMod
{
    // Youth - Staff options (Empire and Aserai)
    [HarmonyPatch(typeof(CharacterCreationCampaignBehavior))]
    [HarmonyPatch("YouthStaffOneOptionOnCondition")]
    public class YouthStaffOneConditionPatch
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

    [HarmonyPatch(typeof(CharacterCreationCampaignBehavior))]
    [HarmonyPatch("YouthStaffTwoOptionOnCondition")]
    public class YouthStaffTwoConditionPatch
    {
        private static readonly HashSet<string> AllowedCultures = new HashSet<string>
        {
            "baltic",
            "sarranid"
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

    // Youth - Groom option (Vlandia)
    [HarmonyPatch(typeof(CharacterCreationCampaignBehavior))]
    [HarmonyPatch("YouthGroomOptionOnCondition")]
    public class YouthGroomConditionPatch
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

    // Youth - Servant options (Khuzait and Battania)
    [HarmonyPatch(typeof(CharacterCreationCampaignBehavior))]
    [HarmonyPatch("YouthServantOneOptionOnCondition")]
    public class YouthServantOneConditionPatch
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
    [HarmonyPatch("YouthServantTwoOptionOnCondition")]
    public class YouthServantTwoConditionPatch
    {
        private static readonly HashSet<string> AllowedCultures = new HashSet<string>
        {
            "barbarian"
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

    // Youth - Cavalry (Vlandia)
    [HarmonyPatch(typeof(CharacterCreationCampaignBehavior))]
    [HarmonyPatch("YouthCavalryOptionOnCondition")]
    public class YouthCavalryConditionPatch
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

    // Youth - Hearth guard (Sturgia and Battania)
    [HarmonyPatch(typeof(CharacterCreationCampaignBehavior))]
    [HarmonyPatch("YouthHearthOptionOnCondition")]
    public class YouthHearthConditionPatch
    {
        private static readonly HashSet<string> AllowedCultures = new HashSet<string>
        {
            "vaegir",
            "barbarian"
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

    // Youth - Guard options (various cultures)
    [HarmonyPatch(typeof(CharacterCreationCampaignBehavior))]
    [HarmonyPatch("YouthGuardHighRegisterOptionOnCondition")]
    public class YouthGuardHighRegisterConditionPatch
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

    [HarmonyPatch(typeof(CharacterCreationCampaignBehavior))]
    [HarmonyPatch("YouthGuardLowRegisterOptionOnCondition")]
    public class YouthGuardLowRegisterConditionPatch
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
    [HarmonyPatch("YouthGuardGarrisonRegisterOptionOnCondition")]
    public class YouthGuardGarrisonRegisterConditionPatch
    {
        private static readonly HashSet<string> AllowedCultures = new HashSet<string>
        {
            "khergit",
            "barbarian",
            "sarranid"
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
    [HarmonyPatch("YouthGuardEmpireRegisterOptionOnCondition")]
    public class YouthGuardEmpireRegisterConditionPatch
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

    // Youth - Rider options (Empire, Khuzait, Aserai, Sturgia)
    [HarmonyPatch(typeof(CharacterCreationCampaignBehavior))]
    [HarmonyPatch("YouthRiderHighRegisterOptionOnCondition")]
    public class YouthRiderHighRegisterConditionPatch
    {
        private static readonly HashSet<string> AllowedCultures = new HashSet<string>
        {
            "khergit",
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

    [HarmonyPatch(typeof(CharacterCreationCampaignBehavior))]
    [HarmonyPatch("YouthRiderLowRegisterOptionOnCondition")]
    public class YouthRiderLowRegisterConditionPatch
    {
        private static readonly HashSet<string> AllowedCultures = new HashSet<string>
        {
            "vaegir",
            "sarranid"
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

    // Youth - Infantry (All cultures)
    [HarmonyPatch(typeof(CharacterCreationCampaignBehavior))]
    [HarmonyPatch("YouthInfantryOptionOnCondition")]
    public class YouthInfantryConditionPatch
    {
        private static readonly HashSet<string> AllowedCultures = new HashSet<string>
        {
            "rhodok",
            "vaegir",
            "barbarian",
            "republic",
            "khergit",
            "sarranid"
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

    // Youth - Skirmisher (Most cultures)
    [HarmonyPatch(typeof(CharacterCreationCampaignBehavior))]
    [HarmonyPatch("YouthSkirmisherOptionOnCondition")]
    public class YouthSkirmisherConditionPatch
    {
        private static readonly HashSet<string> AllowedCultures = new HashSet<string>
        {
            "rhodok",
            "vaegir",
            "khergit",
            "republic",
            "sarranid"
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

    // Youth - Kern (Battania)
    [HarmonyPatch(typeof(CharacterCreationCampaignBehavior))]
    [HarmonyPatch("YouthKernOptionOnCondition")]
    public class YouthKernConditionPatch
    {
        private static readonly HashSet<string> AllowedCultures = new HashSet<string>
        {
            "baltic",
            "barbarian"
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

    // Youth - Camp followers (Vlandia and Sturgia)
    [HarmonyPatch(typeof(CharacterCreationCampaignBehavior))]
    [HarmonyPatch("YouthCampOptionOnCondition")]
    public class YouthCampConditionPatch
    {
        private static readonly HashSet<string> AllowedCultures = new HashSet<string>
        {
            "vaegir",
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

    // Youth - Envoy's guard options
    [HarmonyPatch(typeof(CharacterCreationCampaignBehavior))]
    [HarmonyPatch("EnvoysGuardFirstOptionOnCondition")]
    public class EnvoysGuardFirstConditionPatch
    {
        private static readonly HashSet<string> AllowedCultures = new HashSet<string>
        {
            "khergit",
            "republic",
            "baltic"
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
    [HarmonyPatch("EnvoysGuardSecondOptionOnCondition")]
    public class EnvoysGuardSecondConditionPatch
    {
        private static readonly HashSet<string> AllowedCultures = new HashSet<string>
        {
            "baltic",
            "barbarian",
            "sarranid"
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