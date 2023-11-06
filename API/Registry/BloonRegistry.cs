using System;
using NKHook6.API.Bloons;

namespace NKHook6.API.Registry
{
	// Token: 0x0200000E RID: 14
	public class BloonRegistry : Registry<IBloon>
	{
		// Token: 0x04000007 RID: 7
		public static BloonRegistry instance = new BloonRegistry();
	}
}
