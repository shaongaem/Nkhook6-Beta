using System;
using NKHook6.API.Towers;

namespace NKHook6.API.Registry
{
	// Token: 0x02000012 RID: 18
	public class TowerRegistry : Registry<ITower>
	{
		// Token: 0x06000034 RID: 52 RVA: 0x00002729 File Offset: 0x00000929
		public static TowerRegistry operator +(TowerRegistry inst, ITower tower)
		{
			return (TowerRegistry)inst.Register(tower.GetType(), tower);
		}

		// Token: 0x06000035 RID: 53 RVA: 0x0000273D File Offset: 0x0000093D
		public static TowerRegistry operator -(TowerRegistry inst, ITower tower)
		{
			return (TowerRegistry)inst.Unregister(tower.GetType());
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00002750 File Offset: 0x00000950
		public static ITower operator ^(TowerRegistry inst, string tower)
		{
			return inst.GetItem(tower);
		}

		// Token: 0x0400000A RID: 10
		public static TowerRegistry instance = new TowerRegistry();
	}
}
