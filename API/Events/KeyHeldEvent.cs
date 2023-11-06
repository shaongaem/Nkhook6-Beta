using System;

namespace NKHook6.API.Events
{
	// Token: 0x02000021 RID: 33
	[EventHeader("KeyHeldEvent")]
	public class KeyHeldEvent : KeyEvent
	{
		// Token: 0x06000051 RID: 81 RVA: 0x000027F5 File Offset: 0x000009F5
		public KeyHeldEvent(char key) : base(key)
		{
		}
	}
}
