using HarmonyLib;
using RimWorld;
using XmlExtensions;
using UnityEngine;
using Verse;

namespace TallerTabMenus
{
    class Patches
    {
		[HarmonyPatch(typeof(ITab_Storage), "OnOpen")]
		internal static class Patch_ITab_Storage
		{
			private static void Prefix(ref Vector2 ___size, ref Vector2 ___WinSize)
			{
				___WinSize.y = float.Parse(SettingsManager.GetSetting("imranfishnikos.tallertabmenus", "storage_height"));
				___size.y = float.Parse(SettingsManager.GetSetting("imranfishnikos.tallertabmenus", "storage_height"));
			}
		}
	}
}
