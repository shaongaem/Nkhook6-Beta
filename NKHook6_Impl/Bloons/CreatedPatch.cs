using System;
using Assets.Scripts.Models;
using Assets.Scripts.Simulation.Bloons;
using Assets.Scripts.Simulation.Objects;
using Harmony;
using NKHook6.API.Events._Bloons;
using NKHook6.API.Registry;
using NKHook6_Impl.Implementations.Bloons;

namespace NKHook6_Impl.Bloons
{
	// Token: 0x02000082 RID: 130
	[HarmonyPatch(typeof(Bloon), "Initialise")]
	internal class CreatedPatch
	{
		// Token: 0x0600010F RID: 271 RVA: 0x00003350 File Offset: 0x00001550
		[HarmonyPostfix]
		internal static void Postfix(Bloon __instance, Entity target, Model modelToUse)
		{
			BloonEvents.CreatedEvent createdEvent = new BloonEvents.CreatedEvent(new NBloonEntity(__instance));
			EventRegistry.instance.DispatchEvent<BloonEvents.CreatedEvent>(ref createdEvent);
		}
	}
}
