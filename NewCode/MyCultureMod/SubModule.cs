using HarmonyLib;
using TaleWorlds.MountAndBlade;


namespace MyCultureMod
{
    public class SubModule : MBSubModuleBase
    {
        protected override void OnSubModuleLoad()
        {
            Harmony harmony = new Harmony("MyCultureMod Loaded");
            harmony.PatchAll();
            base.OnSubModuleLoad();

        }

        protected override void OnSubModuleUnloaded()
        {
            base.OnSubModuleUnloaded();

        }

        protected override void OnBeforeInitialModuleScreenSetAsRoot()
        {
            base.OnBeforeInitialModuleScreenSetAsRoot();

        }
    }
}