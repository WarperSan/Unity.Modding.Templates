using HarmonyLib;

namespace UnityModTemplate.Patches;

[HarmonyPatch(typeof(string))]
internal static class Template_Patches
{
    [HarmonyPatch(nameof(string.Remove)), HarmonyPrefix]
    private static void Remove_Prefix(string __instance) { }
    
    [HarmonyPatch(nameof(string.Remove)), HarmonyPostfix]
    private static void Remove_Postfix(string __instance) { }
}