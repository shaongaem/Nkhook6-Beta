using System;
using Assets.Scripts.Simulation.Bloons;
using Harmony;
using NKHook6.API.Events._Bloons;
using NKHook6.API.Registry;
using NKHook6_Impl.Implementations.Bloons;

namespace NKHook6_Impl.Bloons
{
	// Token: 0x02000084 RID: 132
	[HarmonyPatch(typeof(Bloon), "Leaked")]
	internal class LeakedPatch
	{
		// Token: 0x06000113 RID: 275 RVA: 0x000033A8 File Offset: 0x000015A8
		[HarmonyPrefix]
		internal static bool Prefix(Bloon __instance)
		{
			BloonEvents.LeakedEvent leakedEvent = new BloonEvents.LeakedEvent(new NBloonEntity(__instance));
			EventRegistry.instance.DispatchEvent<BloonEvents.LeakedEvent>(ref leakedEvent);
			return !leakedEvent.IsCancelled();
		}
	}
}
