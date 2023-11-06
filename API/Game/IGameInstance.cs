using System;

namespace NKHook6.API.Game
{
	// Token: 0x02000018 RID: 24
	public interface IGameInstance
	{
		// Token: 0x0600003D RID: 61
		IPlayer GetPlayer();

		// Token: 0x0600003E RID: 62
		IPlayer GetPlayer(int index);

		// Token: 0x0600003F RID: 63
		double GetHealth();

		// Token: 0x06000040 RID: 64
		void SetHealth(double value);

		// Token: 0x06000041 RID: 65
		void Lose();

		// Token: 0x06000042 RID: 66
		IMap GetMap();
	}
}
