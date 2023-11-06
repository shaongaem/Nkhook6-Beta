using System;
using Assets.Scripts.Simulation.Bloons;
using Harmony;
using NKHook6.API.Events._Bloons;
using NKHook6.API.Registry;
using NKHook6_Impl.Implementations.Bloons;

namespace NKHook6_Impl.Bloons
{
	// Token: 0x02000085 RID: 133
	[HarmonyPatch(typeof(Bloon), "Process")]
	internal class MovePatch
	{
		// Token: 0x06000115 RID: 277 RVA: 0x000033D8 File Offset: 0x000015D8
		[HarmonyPrefix]
		internal static bool Prefix(Bloon __instance, int elapsed)
		{
			BloonEvents.MoveEvent moveEvent = new BloonEvents.MoveEvent(new NBloonEntity(__instance));
			EventRegistry.instance.DispatchEvent<BloonEvents.MoveEvent>(ref moveEvent);
			return !moveEvent.IsCancelled();
		}
	}
}
