using HarmonyLib;
using Verse;

namespace TallerTabMenus
{
    public class TallerMenus : Mod
    {
		public TallerMenus(ModContentPack content) : base(content)
		{
			var harmony = new Harmony("imranfishnikos.tallertabmenus");
			harmony.PatchAll();
		}
	}
}
