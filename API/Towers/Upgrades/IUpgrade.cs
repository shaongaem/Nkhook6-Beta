using System;

namespace NKHook6.API.Towers.Upgrades
{
	// Token: 0x0200000A RID: 10
	public interface IUpgrade
	{
		// Token: 0x0600001F RID: 31
		double GetCost();

		// Token: 0x06000020 RID: 32
		string GetName();

		// Token: 0x06000021 RID: 33
		string GetDescription();
	}
}
