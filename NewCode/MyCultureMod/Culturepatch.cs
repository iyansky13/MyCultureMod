using HarmonyLib;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.CampaignBehaviors;
using TaleWorlds.CampaignSystem.CharacterCreationContent;
using TaleWorlds.Core;

namespace MyCultureMod
{
    [HarmonyPatch(typeof(CharacterCreationCampaignBehavior), "InitializeCharacterCreationCultures")]
    public class AddOnlyOurCulturesPatch
    {
        // add only our cultures to the selection screen, skip the original method
        static bool Prefix(CharacterCreationManager characterCreationManager)
        {
            foreach (CultureObject cultureObject in Game.Current.ObjectManager.GetObjectTypeList<CultureObject>())
            {
                if (cultureObject.StringId == "vlandia" ||
                    cultureObject.StringId == "empire" ||
                    cultureObject.StringId == "aserai" ||
                    cultureObject.StringId == "sturgia" ||
                    cultureObject.StringId == "khuzait" ||
                    cultureObject.StringId == "battania" ||
                    cultureObject.StringId == "nord" ||
                    cultureObject.StringId == "republic" ||
                    cultureObject.StringId == "rhodok" ||
                    cultureObject.StringId == "saxon" ||
                    cultureObject.StringId == "vaegir" ||
                    cultureObject.StringId == "khergit" ||
                    cultureObject.StringId == "barbarian" ||
                    cultureObject.StringId == "sarranid") // Replace with your culture's StringId
                {
                    characterCreationManager.CharacterCreationContent.AddCharacterCreationCulture(cultureObject, 1, 10);
                }
            }
            return false;
        }
    }
}