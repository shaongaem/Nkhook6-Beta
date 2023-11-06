using System;

namespace NKHook6.API.Events
{
	// Token: 0x0200001D RID: 29
	[EventHeader("EventBaseCancellable")]
	public class EventBaseCancellable : EventBase
	{
		// Token: 0x0600004C RID: 76 RVA: 0x000027C6 File Offset: 0x000009C6
		public void SetCancelled(bool cancelled)
		{
			this.cancelled = cancelled;
		}

		// Token: 0x0600004D RID: 77 RVA: 0x000027CF File Offset: 0x000009CF
		public bool IsCancelled()
		{
			return this.cancelled;
		}

		// Token: 0x0400001B RID: 27
		public bool cancelled;
	}
}
