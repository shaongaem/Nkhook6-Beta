using System;

namespace NKHook6.API.Events
{
	// Token: 0x02000023 RID: 35
	public class UnknownEventException : Exception
	{
		// Token: 0x06000053 RID: 83 RVA: 0x000027FE File Offset: 0x000009FE
		public UnknownEventException(string unknownEvent) : base("Unknown event \"" + unknownEvent + "\"")
		{
		}
	}
}
