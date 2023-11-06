using System;

namespace NKHook6.API.Bloons
{
	// Token: 0x0200002D RID: 45
	public interface IBloonEntity
	{
		// Token: 0x0600006B RID: 107
		IBloon GetType();

		// Token: 0x0600006C RID: 108
		float GetProgress();

		// Token: 0x0600006D RID: 109
		float[] GetPosition();

		// Token: 0x0600006E RID: 110
		float GetRotation();
	}
}
