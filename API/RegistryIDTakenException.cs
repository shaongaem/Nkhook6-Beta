using System;

namespace NKHook6.API
{
	// Token: 0x02000005 RID: 5
	public class RegistryIDTakenException : Exception
	{
		// Token: 0x06000010 RID: 16 RVA: 0x0000227E File Offset: 0x0000047E
		public RegistryIDTakenException(string problematicId) : base("The given registry ID \"" + problematicId + "\" was already registered.")
		{
		}
	}
}
