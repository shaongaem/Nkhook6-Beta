using System;
using Assets.Scripts.Unity.UI_New.InGame;
using Harmony;
using KHook6_Impl.Implementations.Game;
using NKHook6.API.Events._Game;
using NKHook6.API.Game;
using NKHook6.API.Registry;

namespace NKHook6_Impl.Game
{
	// Token: 0x02000080 RID: 128
	[HarmonyPatch(typeof(InGame), "RoundEnd")]
	internal class RoundEndPatch
	{
		// Token: 0x0600010B RID: 267 RVA: 0x000032E4 File Offset: 0x000014E4
		[HarmonyPrefix]
		internal static void Prefix(InGame __instance)
		{
			IGameInstance game = NGameInstance.GetGame();
			int spawnedRound = __instance.bridge.simulation.GetSpawnedRound();
			GameEvents.RoundEndEvent roundEndEvent = new GameEvents.RoundEndEvent(game, spawnedRound);
			EventRegistry.instance.DispatchEvent<GameEvents.RoundEndEvent>(ref roundEndEvent);
		}
	}
}
