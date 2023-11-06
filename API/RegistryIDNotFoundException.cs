using System;

namespace NKHook6.API
{
	// Token: 0x02000006 RID: 6
	public class RegistryIDNotFoundException : Exception
	{
		// Token: 0x06000011 RID: 17 RVA: 0x00002296 File Offset: 0x00000496
		public RegistryIDNotFoundException(string unknownId) : base("The given registry ID, \"" + unknownId + "\" doesn't exist!")
		{
		}
	}
}
