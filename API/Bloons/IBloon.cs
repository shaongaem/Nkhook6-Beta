using System;

namespace NKHook6.API.Bloons
{
	// Token: 0x0200002C RID: 44
	public interface IBloon
	{
		// Token: 0x0600005C RID: 92
		string GetType();

		// Token: 0x0600005D RID: 93
		string GetBaseType();

		// Token: 0x0600005E RID: 94
		IBloon.Modifier[] GetModifiers();

		// Token: 0x0600005F RID: 95
		IBloon.Immunity[] GetImmunities();

		// Token: 0x06000060 RID: 96
		float GetMaxHealth();

		// Token: 0x06000061 RID: 97
		float GetLeakDamage();

		// Token: 0x06000062 RID: 98
		bool IsInvulnerable();

		// Token: 0x06000063 RID: 99
		float GetSpeed();

		// Token: 0x06000064 RID: 100
		float GetSpeedFrames();

		// Token: 0x06000065 RID: 101
		float GetRadius();

		// Token: 0x06000066 RID: 102
		float GetDanger();

		// Token: 0x06000067 RID: 103
		bool IsRotateable();

		// Token: 0x06000068 RID: 104
		string GetIcon();

		// Token: 0x06000069 RID: 105
		string GetDisplay();

		// Token: 0x0600006A RID: 106
		string[] GetTags();

		// Token: 0x020000A5 RID: 165
		public enum Modifier
		{
			// Token: 0x04000063 RID: 99
			Regen,
			// Token: 0x04000064 RID: 100
			Camo,
			// Token: 0x04000065 RID: 101
			Fortified,
			// Token: 0x04000066 RID: 102
			Moab
		}

		// Token: 0x020000A6 RID: 166
		public enum Immunity
		{
			// Token: 0x04000068 RID: 104
			Lead,
			// Token: 0x04000069 RID: 105
			Spikes,
			// Token: 0x0400006A RID: 106
			Glue,
			// Token: 0x0400006B RID: 107
			Ice
		}
	}
}
