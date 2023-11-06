using System;
using NKHook6.API.Registry;

namespace NKHook6.API.Map
{
	// Token: 0x02000015 RID: 21
	public struct Path
	{
		// Token: 0x0600003A RID: 58 RVA: 0x00002794 File Offset: 0x00000994
		public Path(string id, params NKHook6.API.Registry.Point[] points)
		{
			this.id = id;
			this.points = points;
		}

		// Token: 0x04000016 RID: 22
		public string id;

		// Token: 0x04000017 RID: 23
		public NKHook6.API.Registry.Point[] points;
	}
}
