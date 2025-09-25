#if IncludeHarmony
using HarmonyLib;
#endif

namespace PluginTemplate.Helpers;

/// <summary>
///     Class helping for patching stuff
/// </summary>
internal static class Patch
{
#if IncludeHarmony
    private static Harmony? _harmony;
#endif

    /// <summary>
    ///     Applies every patch needed by this mod
    /// </summary>
    public static void ApplyAll()
    {
#if IncludeHarmony
        if (_harmony != null)
        {
            Log.Debug("Unpatching the existing harmony instance.");
            RevertAll();
        }

        _harmony = new Harmony(MyPluginInfo.PLUGIN_GUID);

        _harmony.PatchAll(typeof(Patches.Example_Patches));

#endif
        Log.Debug("All patches applied.");
    }

    /// <summary>
    ///     Reverts every patch applied by this mod
    /// </summary>
    public static void RevertAll()
    {
#if IncludeHarmony
        if (_harmony == null)
            return;

        _harmony.UnpatchSelf();

        _harmony = null;

#endif
        Log.Debug("All patches reverted.");
    }
}