using System;

namespace NKHook6.API.Events
{
	// Token: 0x02000020 RID: 32
	[EventHeader("KeyPressEvent")]
	public class KeyPressEvent : KeyEvent
	{
		// Token: 0x06000050 RID: 80 RVA: 0x000027F5 File Offset: 0x000009F5
		public KeyPressEvent(char key) : base(key)
		{
		}
	}
}
