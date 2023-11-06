using System;
using Assets.Scripts.Simulation.Bloons;
using Harmony;
using NKHook6.API.Events._Bloons;
using NKHook6.API.Registry;
using NKHook6_Impl.Implementations.Bloons;

namespace NKHook6_Impl.Bloons
{
	// Token: 0x02000086 RID: 134
	[HarmonyPatch(typeof(Bloon), "SetRotation")]
	internal class RotatePatch
	{
		// Token: 0x06000117 RID: 279 RVA: 0x00003408 File Offset: 0x00001608
		[HarmonyPrefix]
		internal static bool Prefix(Bloon __instance, float rotation)
		{
			NBloonEntity nbloonEntity = new NBloonEntity(__instance);
			BloonEvents.RotateEvent rotateEvent = new BloonEvents.RotateEvent(nbloonEntity, rotation);
			if (rotation != nbloonEntity.GetRotation())
			{
				EventRegistry.instance.DispatchEvent<BloonEvents.RotateEvent>(ref rotateEvent);
			}
			return !rotateEvent.IsCancelled();
		}
	}
}
