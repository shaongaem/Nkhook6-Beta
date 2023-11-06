using System;

namespace NKHook6.API.Events
{
	// Token: 0x0200001B RID: 27
	[EventHeader("EventBase")]
	public abstract class EventBase
	{
		// Token: 0x06000049 RID: 73 RVA: 0x00002721 File Offset: 0x00000921
		public EventBase()
		{
		}

		// Token: 0x0400001A RID: 26
		public string eventName;
	}
}
