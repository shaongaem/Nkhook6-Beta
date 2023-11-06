using System;
using Assets.Scripts.Simulation.Bloons;
using Harmony;
using NKHook6.API.Events._Bloons;
using NKHook6.API.Registry;
using NKHook6_Impl.Implementations.Bloons;

namespace NKHook6_Impl.Bloons
{
	// Token: 0x02000083 RID: 131
	[HarmonyPatch(typeof(Bloon), "OnDestroy")]
	internal class DeletedPatch
	{
		// Token: 0x06000111 RID: 273 RVA: 0x00003378 File Offset: 0x00001578
		[HarmonyPrefix]
		internal static bool Prefix(Bloon __instance)
		{
			BloonEvents.DeletedEvent deletedEvent = new BloonEvents.DeletedEvent(new NBloonEntity(__instance));
			EventRegistry.instance.DispatchEvent<BloonEvents.DeletedEvent>(ref deletedEvent);
			return !deletedEvent.IsCancelled();
		}
	}
}
