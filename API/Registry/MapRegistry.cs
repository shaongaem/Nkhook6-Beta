using System;
using NKHook6.API.Game;

namespace NKHook6.API.Registry
{
	// Token: 0x02000010 RID: 16
	public class MapRegistry : Registry<IMap>
	{
		// Token: 0x06000029 RID: 41 RVA: 0x0000269C File Offset: 0x0000089C
		public static MapRegistry operator +(MapRegistry inst, IMap map)
		{
			return (MapRegistry)inst.Register(map.GetMapName(), map);
		}

		// Token: 0x0600002A RID: 42 RVA: 0x000026B0 File Offset: 0x000008B0
		public static MapRegistry operator -(MapRegistry inst, IMap map)
		{
			return (MapRegistry)inst.Unregister(map.GetMapName());
		}

		// Token: 0x0600002B RID: 43 RVA: 0x000026C3 File Offset: 0x000008C3
		public static IMap operator ^(MapRegistry inst, string tower)
		{
			return inst.GetItem(tower);
		}

		// Token: 0x0600002C RID: 44 RVA: 0x000026CC File Offset: 0x000008CC
		public void Test()
		{
			MapRegistry.instance += new TestMap();
			MapRegistry.instance ^ "TestMap";
			MapRegistry.instance -= new TestMap();
		}

		// Token: 0x04000009 RID: 9
		public static MapRegistry instance = new MapRegistry();
	}
}
