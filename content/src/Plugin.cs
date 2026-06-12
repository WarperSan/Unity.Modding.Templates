using BepInEx;
using Log = PluginTemplate.Helpers.Log;
using Patch = PluginTemplate.Helpers.Patch;

namespace PluginTemplate;

[BepInAutoPlugin]
public partial class Plugin : BaseUnityPlugin
{
    private void Awake()
    {
        Patch.ApplyAll();
        Log.Info($"{Name} v{Version} has loaded!");
    }
}