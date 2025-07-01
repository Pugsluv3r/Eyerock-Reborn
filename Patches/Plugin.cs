using BepInEx;
using System.ComponentModel;

namespace eyerock.Patches
{
    [Description(eyerock.PluginInfo.Description)]
    [BepInPlugin(eyerock.PluginInfo.GUID, eyerock.PluginInfo.Name, eyerock.PluginInfo.Version)]
    public class HarmonyPatches : BaseUnityPlugin
    {
        private void OnEnable()
        {
            Menu.ApplyHarmonyPatches();
        }

        private void OnDisable()
        {
            Menu.RemoveHarmonyPatches();
        }
    }
}
