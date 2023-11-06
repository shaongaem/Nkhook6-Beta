using System;
using NKHook6.API.Towers.Upgrades;

namespace NKHook6.API.Towers
{
	// Token: 0x02000007 RID: 7
	public interface ITower
	{
		// Token: 0x06000012 RID: 18
		string GetType();

		// Token: 0x06000013 RID: 19
		IUpgrade GetUpgrade(int path, int tier);

		// Token: 0x06000014 RID: 20
		double GetCost();

		// Token: 0x06000015 RID: 21
		bool CanPlaceOnWater();

		// Token: 0x06000016 RID: 22
		bool CanPlaceOnLand();

		// Token: 0x06000017 RID: 23
		bool CanPlaceOnPath();

		// Token: 0x06000018 RID: 24
		bool CanTargetCamo();

		// Token: 0x06000019 RID: 25
		double AttackRadius();

		// Token: 0x0600001A RID: 26
		bool IsInfiniteRadius();

		// Token: 0x0600001B RID: 27
		bool RotateToTarget();
	}
}
