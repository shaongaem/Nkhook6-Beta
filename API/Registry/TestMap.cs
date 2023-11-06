using System;
using System.Collections.Generic;
using NKHook6.API.Game;
using NKHook6.API.Map;

namespace NKHook6.API.Registry
{
	// Token: 0x02000011 RID: 17
	public class TestMap : IMap
	{
		// Token: 0x0600002F RID: 47 RVA: 0x0000271A File Offset: 0x0000091A
		public string GetMapName()
		{
			throw new NotImplementedException();
		}

		// Token: 0x06000030 RID: 48 RVA: 0x0000271A File Offset: 0x0000091A
		public IEnumerable<Area> GetAreas()
		{
			throw new NotImplementedException();
		}

		// Token: 0x06000031 RID: 49 RVA: 0x0000271A File Offset: 0x0000091A
		public IEnumerable<Path> GetPaths()
		{
			throw new NotImplementedException();
		}

		// Token: 0x06000032 RID: 50 RVA: 0x0000271A File Offset: 0x0000091A
		public PathSplitter GetPathSplitter()
		{
			throw new NotImplementedException();
		}
	}
}
