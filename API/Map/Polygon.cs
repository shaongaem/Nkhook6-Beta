using System;
using System.Collections.Generic;
using System.Numerics;

namespace NKHook6.API.Map
{
	// Token: 0x02000017 RID: 23
	public struct Polygon
	{
		// Token: 0x0600003C RID: 60 RVA: 0x000027AD File Offset: 0x000009AD
		public Polygon(IEnumerable<Vector2> area)
		{
			this.area = area;
		}

		// Token: 0x04000019 RID: 25
		public IEnumerable<Vector2> area;
	}
}
