using System;

namespace NKHook6.API.Towers
{
	// Token: 0x02000008 RID: 8
	public interface ITowerEntity
	{
		// Token: 0x0600001C RID: 28
		ITower GetType();

		// Token: 0x0600001D RID: 29
		float[] GetPosition();

		// Token: 0x0600001E RID: 30
		bool IsUpgradePurchased(int path, int tier);
	}
}
