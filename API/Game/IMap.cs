using System;
using System.Collections.Generic;
using NKHook6.API.Map;

namespace NKHook6.API.Game
{
	// Token: 0x0200001A RID: 26
	public interface IMap
	{
		// Token: 0x06000045 RID: 69
		string GetMapName();

		// Token: 0x06000046 RID: 70
		IEnumerable<Area> GetAreas();

		// Token: 0x06000047 RID: 71
		IEnumerable<Path> GetPaths();

		// Token: 0x06000048 RID: 72
		PathSplitter GetPathSplitter();
	}
}
