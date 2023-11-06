using System;
using Assets.Scripts.Unity.UI_New.InGame;
using NKHook6.API.Game;

namespace KHook6_Impl.Implementations.Game
{
	// Token: 0x0200002E RID: 46
	public class NGameInstance : IGameInstance
	{
		// Token: 0x0600006F RID: 111 RVA: 0x00002816 File Offset: 0x00000A16
		public static NGameInstance GetGame()
		{
			if (NGameInstance.gameInstance == null)
			{
				InGame instance = InGame.instance;
				if (instance == null)
				{
					throw new Exception("Cannot get NGameInstance without being in a game!");
				}
				NGameInstance.gameInstance = new NGameInstance(instance);
			}
			return NGameInstance.gameInstance;
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00002847 File Offset: 0x00000A47
		private NGameInstance(InGame inGame)
		{
			this.inGame = inGame;
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00002856 File Offset: 0x00000A56
		public InGame GetNative()
		{
			return this.inGame;
		}

		// Token: 0x06000072 RID: 114 RVA: 0x0000285E File Offset: 0x00000A5E
		public double GetHealth()
		{
			return (double)this.inGame.bridge.GetHealth();
		}

		// Token: 0x06000073 RID: 115 RVA: 0x0000271A File Offset: 0x0000091A
		public IMap GetMap()
		{
			throw new NotImplementedException();
		}

		// Token: 0x06000074 RID: 116 RVA: 0x0000271A File Offset: 0x0000091A
		public IPlayer GetPlayer()
		{
			throw new NotImplementedException();
		}

		// Token: 0x06000075 RID: 117 RVA: 0x0000271A File Offset: 0x0000091A
		public IPlayer GetPlayer(int index)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00002871 File Offset: 0x00000A71
		public void Lose()
		{
			this.inGame.Loose();
		}

		// Token: 0x06000077 RID: 119 RVA: 0x0000271A File Offset: 0x0000091A
		public void SetHealth(double value)
		{
			throw new NotImplementedException();
		}

		// Token: 0x0400001E RID: 30
		private static NGameInstance gameInstance;

		// Token: 0x0400001F RID: 31
		private InGame inGame;
	}
}
