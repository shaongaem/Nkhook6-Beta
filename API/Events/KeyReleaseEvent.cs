using System;

namespace NKHook6.API.Events
{
	// Token: 0x02000022 RID: 34
	[EventHeader("KeyReleaseEvent")]
	public class KeyReleaseEvent : KeyEvent
	{
		// Token: 0x06000052 RID: 82 RVA: 0x000027F5 File Offset: 0x000009F5
		public KeyReleaseEvent(char key) : base(key)
		{
		}
	}
}
