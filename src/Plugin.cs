using BepInEx;
#if UseHarmony
using HarmonyLib;
#endif
using Log = UnityModTemplate.Helpers.Log;

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
        Log.Info($"{MyPluginInfo.PLUGIN_GUID} v{MyPluginInfo.PLUGIN_VERSION} has loaded!");
    }

    private void OnDestroy()
    {
#if UseHarmony
        Unpatch();

#endif
        Log.Info($"{MyPluginInfo.PLUGIN_GUID} v{MyPluginInfo.PLUGIN_VERSION} has unloaded!");
    }
#if UseHarmony

    #region Harmony

    private Harmony? Harmony;

    private void Patch()
    {
        Harmony = new Harmony(MyPluginInfo.PLUGIN_GUID);
        
        // Harmony.PatchAll(typeof(Patches.Template_Patches));

        Log.Debug("Plugin patched!");
    }

    private void Unpatch()
    {
        Harmony?.UnpatchSelf();
        Harmony = null;
        
        Log.Debug("Plugin unpatched!");
    }

    #endregion
#endif
}
