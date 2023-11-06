using System;

namespace NKHook6.API.Events
{
	// Token: 0x0200001E RID: 30
	[AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = true)]
	public class EventHeader : Attribute
	{
		// Token: 0x0600004E RID: 78 RVA: 0x000027D7 File Offset: 0x000009D7
		public EventHeader(string eventName)
		{
			this.eventName = eventName;
		}

		// Token: 0x0400001C RID: 28
		public string eventName;
	}
}
