#if Logger_BepInEx
using BepInEx.Logging;
#endif

namespace PluginTemplate.Helpers;

/// <summary>
///     Class helping for logging stuff
/// </summary>
internal static class Log
{
#if Logger_BepInEx
    private static ManualLogSource? _logger;

    private static void LogSelf(string message, LogLevel level)
    {
        _logger ??= Logger.CreateLogSource(MyPluginInfo.PLUGIN_NAME);
        _logger?.Log(level, message);
    }
#endif

    /// <summary>
    ///     Logs information for developers that helps to debug the mod
    /// </summary>
    public static void Debug(string message)
    {
#if Logger_System
        Console.WriteLine($"[DEBUG] {message}");
#endif
#if Logger_Unity
        UnityEngine.Debug.Log(message);
#endif
#if Logger_BepInEx
        LogSelf(message, LogLevel.Debug);
#endif
    }

    /// <summary>
    ///     Logs information for players to know important steps of the mod
    /// </summary>
    public static void Info(string message)
    {
#if Logger_System
        Console.WriteLine($"[INFO] {message}");
#endif
#if Logger_Unity
        UnityEngine.Debug.Log(message);
#endif
#if Logger_BepInEx
        LogSelf(message, LogLevel.Message);
#endif
    }

    /// <summary>
    ///     Logs information for players to warn them about an unwanted state
    /// </summary>
    public static void Warning(string message)
    {
#if Logger_System
        Console.WriteLine($"[WARNING] {message}");
#endif
#if Logger_Unity
        UnityEngine.Debug.LogWarning(message);
#endif
#if Logger_BepInEx
        LogSelf(message, LogLevel.Warning);
#endif
    }

    /// <summary>
    ///     Logs information for players to notify them of an error
    /// </summary>
    public static void Error(string message)
    {
#if Logger_System
        Console.WriteLine($"[ERROR] {message}");
#endif
#if Logger_Unity
        UnityEngine.Debug.LogError(message);
#endif
#if Logger_BepInEx
        LogSelf(message, LogLevel.Error);
#endif
    }
}