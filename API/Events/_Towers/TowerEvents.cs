using System;
using NKHook6.API.Towers;

namespace NKHook6.API.Events._Towers
{
	// Token: 0x02000026 RID: 38
	public class TowerEvents
	{
		// Token: 0x0200008C RID: 140
		[EventHeader("TowerCreatedEvent")]
		public class CreatedEvent : EventBase
		{
			// Token: 0x06000130 RID: 304 RVA: 0x00003761 File Offset: 0x00001961
			public CreatedEvent(ITowerEntity tower)
			{
				this.tower = tower;
			}

			// Token: 0x04000039 RID: 57
			public ITowerEntity tower;
		}

		// Token: 0x0200008D RID: 141
		[EventHeader("TowerDeletedEvent")]
		public class DeletedEvent : EventBase
		{
			// Token: 0x06000131 RID: 305 RVA: 0x00003770 File Offset: 0x00001970
			public DeletedEvent(ITowerEntity tower)
			{
				this.tower = tower;
			}

			// Token: 0x0400003A RID: 58
			public ITowerEntity tower;
		}

		// Token: 0x0200008E RID: 142
		[EventHeader("TowerDeselectedEvent")]
		public class DeselectedEvent : EventBaseCancellable
		{
			// Token: 0x06000132 RID: 306 RVA: 0x0000377F File Offset: 0x0000197F
			public DeselectedEvent(ITowerEntity tower)
			{
				this.tower = tower;
			}

			// Token: 0x0400003B RID: 59
			public ITowerEntity tower;
		}

		// Token: 0x0200008F RID: 143
		[EventHeader("TowerSelectedEvent")]
		public class SelectedEvent : EventBaseCancellable
		{
			// Token: 0x06000133 RID: 307 RVA: 0x0000378E File Offset: 0x0000198E
			public SelectedEvent(ITowerEntity tower)
			{
				this.tower = tower;
			}

			// Token: 0x0400003C RID: 60
			public ITowerEntity tower;
		}

		// Token: 0x02000090 RID: 144
		[EventHeader("TowerSoldEvent")]
		public class SoldEvent : EventBaseCancellable
		{
			// Token: 0x06000134 RID: 308 RVA: 0x0000379D File Offset: 0x0000199D
			public SoldEvent(ITowerEntity tower, float sellAmount)
			{
				this.tower = tower;
				this.sellAmount = sellAmount;
			}

			// Token: 0x0400003D RID: 61
			public ITowerEntity tower;

			// Token: 0x0400003E RID: 62
			public float sellAmount;
		}

		// Token: 0x02000091 RID: 145
		[EventHeader("TowerUpgradeEvent")]
		public class UpgradeEvent : EventBaseCancellable
		{
			// Token: 0x06000135 RID: 309 RVA: 0x000037B3 File Offset: 0x000019B3
			public UpgradeEvent(ITowerEntity tower)
			{
				this.tower = tower;
			}

			// Token: 0x0400003F RID: 63
			public ITowerEntity tower;
		}
	}
}
