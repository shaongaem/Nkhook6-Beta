using System;
using NKHook6.API.Game;

namespace NKHook6.API.Events._Player
{
	// Token: 0x02000028 RID: 40
	public class PlayerEvents
	{
		// Token: 0x02000094 RID: 148
		[EventHeader("CashChangedEvent")]
		public class CashChangedEvent : EventBaseCancellable
		{
			// Token: 0x06000138 RID: 312 RVA: 0x000037E0 File Offset: 0x000019E0
			public CashChangedEvent(IGameInstance game, double oldCash, double newCash)
			{
				this.game = game;
				this.oldCash = oldCash;
				this.newCash = newCash;
			}

			// Token: 0x04000042 RID: 66
			public IGameInstance game;

			// Token: 0x04000043 RID: 67
			public double oldCash;

			// Token: 0x04000044 RID: 68
			public double newCash;
		}

		// Token: 0x02000095 RID: 149
		[EventHeader("CashGainedEvent")]
		public class CashGainedEvent : PlayerEvents.CashChangedEvent
		{
			// Token: 0x06000139 RID: 313 RVA: 0x000037FD File Offset: 0x000019FD
			public CashGainedEvent(IGameInstance game, double oldCash, double newCash) : base(game, oldCash, newCash)
			{
			}
		}

		// Token: 0x02000096 RID: 150
		[EventHeader("CashLostEvent")]
		public class CashLostEvent : PlayerEvents.CashChangedEvent
		{
			// Token: 0x0600013A RID: 314 RVA: 0x000037FD File Offset: 0x000019FD
			public CashLostEvent(IGameInstance game, double oldCash, double newCash) : base(game, oldCash, newCash)
			{
			}
		}

		// Token: 0x02000097 RID: 151
		[EventHeader("HealthChangedEvent")]
		public class HealthChangedEvent : EventBaseCancellable
		{
			// Token: 0x0600013B RID: 315 RVA: 0x00003808 File Offset: 0x00001A08
			public HealthChangedEvent(IGameInstance game, double oldCash, double newCash)
			{
				this.game = game;
				this.oldCash = oldCash;
				this.newCash = newCash;
			}

			// Token: 0x04000045 RID: 69
			public IGameInstance game;

			// Token: 0x04000046 RID: 70
			public double oldCash;

			// Token: 0x04000047 RID: 71
			public double newCash;
		}

		// Token: 0x02000098 RID: 152
		[EventHeader("HealthGainedEvent")]
		public class HealthGainedEvent : PlayerEvents.HealthChangedEvent
		{
			// Token: 0x0600013C RID: 316 RVA: 0x00003825 File Offset: 0x00001A25
			public HealthGainedEvent(IGameInstance game, double oldCash, double newCash) : base(game, oldCash, newCash)
			{
			}
		}

		// Token: 0x02000099 RID: 153
		[EventHeader("HealthLostEvent")]
		public class HealthLostEvent : PlayerEvents.HealthChangedEvent
		{
			// Token: 0x0600013D RID: 317 RVA: 0x00003825 File Offset: 0x00001A25
			public HealthLostEvent(IGameInstance game, double oldCash, double newCash) : base(game, oldCash, newCash)
			{
			}
		}
	}
}
