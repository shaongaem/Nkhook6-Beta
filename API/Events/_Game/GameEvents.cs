using System;
using NKHook6.API.Game;

namespace NKHook6.API.Events._Game
{
	// Token: 0x02000029 RID: 41
	public class GameEvents
	{
		// Token: 0x0200009A RID: 154
		[EventHeader("DefeatedEvent")]
		public class DefeatedEvent : EventBaseCancellable
		{
			// Token: 0x0600013E RID: 318 RVA: 0x00003830 File Offset: 0x00001A30
			public DefeatedEvent(IGameInstance game)
			{
				this.game = game;
			}

			// Token: 0x04000048 RID: 72
			public IGameInstance game;
		}

		// Token: 0x0200009B RID: 155
		[EventHeader("RoundEndEvent")]
		public class RoundEndEvent : EventBaseCancellable
		{
			// Token: 0x0600013F RID: 319 RVA: 0x0000383F File Offset: 0x00001A3F
			public RoundEndEvent(IGameInstance game, int round)
			{
				this.game = game;
				this.round = round;
			}

			// Token: 0x04000049 RID: 73
			public IGameInstance game;

			// Token: 0x0400004A RID: 74
			public int round;
		}

		// Token: 0x0200009C RID: 156
		[EventHeader("RoundStartEvent")]
		public class RoundStartEvent : EventBaseCancellable
		{
			// Token: 0x06000140 RID: 320 RVA: 0x00003855 File Offset: 0x00001A55
			public RoundStartEvent(IGameInstance game, int round)
			{
				this.game = game;
				this.round = round;
			}

			// Token: 0x0400004B RID: 75
			public IGameInstance game;

			// Token: 0x0400004C RID: 76
			public int round;
		}

		// Token: 0x0200009D RID: 157
		[EventHeader("StartMatchEvent")]
		public class StartMatchEvent : EventBase
		{
			// Token: 0x06000141 RID: 321 RVA: 0x0000386B File Offset: 0x00001A6B
			public StartMatchEvent(IGameInstance game, bool isFromSave)
			{
				this.game = game;
				this.isFromSave = isFromSave;
			}

			// Token: 0x0400004D RID: 77
			public IGameInstance game;

			// Token: 0x0400004E RID: 78
			public bool isFromSave;
		}

		// Token: 0x0200009E RID: 158
		[EventHeader("VictoryEvent")]
		public class VictoryEvent : EventBaseCancellable
		{
			// Token: 0x06000142 RID: 322 RVA: 0x00003881 File Offset: 0x00001A81
			public VictoryEvent(IGameInstance game)
			{
				this.game = game;
			}

			// Token: 0x0400004F RID: 79
			public IGameInstance game;
		}
	}
}
