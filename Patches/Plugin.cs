using BepInEx;
using System.ComponentModel;

namespace eyerockreborn.Patches
{
    [Description(eyerockreborn.PluginInfo.Description)]
    [BepInPlugin(eyerockreborn.PluginInfo.GUID, eyerockreborn.PluginInfo.Name, eyerockreborn.PluginInfo.Version)]
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
