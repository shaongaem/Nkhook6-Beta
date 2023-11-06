using System;

namespace NKHook6.API.Map
{
	// Token: 0x02000013 RID: 19
	public struct Area
	{
		// Token: 0x06000039 RID: 57 RVA: 0x0000276D File Offset: 0x0000096D
		public Area(string id, Polygon polygon, int height, AreaType areaType, bool isBlocker = false)
		{
			this.id = id;
			this.polygon = polygon;
			this.height = height;
			this.areaType = areaType;
			this.isBlocker = isBlocker;
		}

		// Token: 0x0400000B RID: 11
		public string id;

		// Token: 0x0400000C RID: 12
		public Polygon polygon;

		// Token: 0x0400000D RID: 13
		public int height;

		// Token: 0x0400000E RID: 14
		public AreaType areaType;

		// Token: 0x0400000F RID: 15
		public bool isBlocker;
	}
}
