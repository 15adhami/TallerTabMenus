using HarmonyLib;
using Verse;

namespace TallerTabMenus
{
    public class TallerTabMenus : Mod
    {
		public TallerTabMenus(ModContentPack content) : base(content)
		{
			var harmony = new Harmony("imranfishnikos.tallertabmenus");
			harmony.PatchAll();
		}
	}
}
