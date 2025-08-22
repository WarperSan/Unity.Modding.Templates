using BepInEx;
#if UseHarmony
using HarmonyLib;
#endif
#if UseLogger
using Log = UnityModTemplate.Helpers.Log;
#endif

namespace UnityModTemplate;

[BepInPlugin(MyPluginInfo.PLUGIN_GUID, MyPluginInfo.PLUGIN_NAME, MyPluginInfo.PLUGIN_VERSION)]
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
        Log.Info($"{MyPluginInfo.PLUGIN_GUID} v{MyPluginInfo.PLUGIN_VERSION} has loaded!");
#else
        Logger.LogInfo($"{MyPluginInfo.PLUGIN_GUID} v{MyPluginInfo.PLUGIN_VERSION} has loaded!");
#endif
    }

    private void OnDestroy()
    {
#if UseHarmony
        Unpatch();

#endif
#if UseLogger
        Log.Info($"{MyPluginInfo.PLUGIN_GUID} v{MyPluginInfo.PLUGIN_VERSION} has unloaded!");
#else
        Logger.LogInfo($"{MyPluginInfo.PLUGIN_GUID} v{MyPluginInfo.PLUGIN_VERSION} has unloaded!");
#endif
    }
#if UseHarmony

    #region Harmony

    private Harmony? Harmony;

    private void Patch()
    {
        Harmony = new Harmony(MyPluginInfo.PLUGIN_GUID);
        
        // Harmony.PatchAll(typeof(Patches.Template_Patches));

#if UseLogger
        Log.Debug("Plugin patched!");
#endif
    }

    private void Unpatch()
    {
        Harmony?.UnpatchSelf();
        Harmony = null;
        
#if UseLogger
        Log.Debug("Plugin unpatched!");
#endif
    }

    #endregion
#endif
}
