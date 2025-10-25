﻿using BepInEx;
using Log = PluginTemplate.Helpers.Log;
using Patch = PluginTemplate.Helpers.Patch;

namespace PluginTemplate;

[BepInPlugin(MyPluginInfo.PLUGIN_GUID, MyPluginInfo.PLUGIN_NAME, MyPluginInfo.PLUGIN_VERSION)]
internal class Plugin : BaseUnityPlugin
{
    private void Awake()
    {
        Patch.ApplyAll();
        Log.Info($"{MyPluginInfo.PLUGIN_NAME} v{MyPluginInfo.PLUGIN_VERSION} has loaded!");
    }

    private void OnDestroy()
    {
        Patch.RevertAll();
        Log.Info($"{MyPluginInfo.PLUGIN_NAME} v{MyPluginInfo.PLUGIN_VERSION} has unloaded!");
    }
}