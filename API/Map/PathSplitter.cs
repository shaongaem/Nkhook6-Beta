using System;

namespace NKHook6.API.Map
{
	// Token: 0x02000016 RID: 22
	public struct PathSplitter
	{
		// Token: 0x0600003B RID: 59 RVA: 0x000027A4 File Offset: 0x000009A4
		public PathSplitter(params string[] paths)
		{
			this.pathNames = paths;
		}

		// Token: 0x04000018 RID: 24
		public string[] pathNames;
	}
}
