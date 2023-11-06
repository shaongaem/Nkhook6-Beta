using System;
using Assets.Scripts.Unity.Bridge;
using Harmony;
using KHook6_Impl.Implementations.Game;
using NKHook6.API.Events._Game;
using NKHook6.API.Game;
using NKHook6.API.Registry;

namespace NKHook6_Impl.Game
{
	// Token: 0x02000081 RID: 129
	[HarmonyPatch(typeof(UnityToSimulation), "StartRound")]
	internal class RoundStartPatch
	{
		// Token: 0x0600010D RID: 269 RVA: 0x0000331C File Offset: 0x0000151C
		[HarmonyPrefix]
		internal static void Prefix(UnityToSimulation __instance)
		{
			IGameInstance game = NGameInstance.GetGame();
			int round = __instance.simulation.GetSpawnedRound() + 1;
			GameEvents.RoundStartEvent roundStartEvent = new GameEvents.RoundStartEvent(game, round);
			EventRegistry.instance.DispatchEvent<GameEvents.RoundStartEvent>(ref roundStartEvent);
		}
	}
}
