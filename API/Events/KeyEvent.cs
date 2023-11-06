using System;

namespace NKHook6.API.Events
{
	// Token: 0x0200001F RID: 31
	[EventHeader("KeyEvent")]
	public class KeyEvent : EventBase
	{
		// Token: 0x0600004F RID: 79 RVA: 0x000027E6 File Offset: 0x000009E6
		public KeyEvent(char key)
		{
			this.key = key;
		}

		// Token: 0x0400001D RID: 29
		public char key;
	}
}
