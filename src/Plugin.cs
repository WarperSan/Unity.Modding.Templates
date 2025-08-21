using BepInEx;
#if UseHarmony
using HarmonyLib;
#endif
#if UseLogger
using Log = UnityModTemplate.Helpers.Log;
#endif

namespace UnityModTemplate;

[BepInPlugin(PluginInfo.PLUGIN_GUID, PluginInfo.PLUGIN_NAME, PluginInfo.PLUGIN_VERSION)]
public class Plugin : BaseUnityPlugin
{
    private void Awake()
    {
#if UseLogger
        Log.SetLogger(Logger);

#endif
#if UseHarmony
        Patch();

#endif
#if UseLogger
        Log.Info($"{PluginInfo.PLUGIN_GUID} v{PluginInfo.PLUGIN_VERSION} has loaded!");
#else
        Logger.LogInfo($"{PluginInfo.PLUGIN_GUID} v{PluginInfo.PLUGIN_VERSION} has loaded!");
#endif
    }
#if UseHarmony

    #region Harmony

    private Harmony? Harmony;

    private void Patch()
    {
        Harmony = new Harmony(PluginInfo.PLUGIN_GUID);
        
        // Harmony.PatchAll(typeof(Patches.Template_Patches));

#if UseLogger
        Log.Debug("Plugin patched!");
#endif
    }

    private void Unpatch()
    {
        Harmony?.UnpatchSelf();
        
#if UseLogger
        Log.Debug("Plugin unpatched!");
#endif
    }

    #endregion
#endif
}
