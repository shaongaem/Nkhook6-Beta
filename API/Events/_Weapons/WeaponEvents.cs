using System;
using NKHook6.API.Towers.Weapons;

namespace NKHook6.API.Events._Weapons
{
	// Token: 0x02000025 RID: 37
	public class WeaponEvents
	{
		// Token: 0x0200008A RID: 138
		[EventHeader("WeaponCreatedEvent")]
		public class CreatedEvent : EventBaseCancellable
		{
			// Token: 0x0600012E RID: 302 RVA: 0x00003743 File Offset: 0x00001943
			public CreatedEvent(IWeapon weapon)
			{
				this.weapon = weapon;
			}

			// Token: 0x04000037 RID: 55
			public IWeapon weapon;
		}

		// Token: 0x0200008B RID: 139
		[EventHeader("WeaponDeletedEvent")]
		public class DeletedEvent : EventBaseCancellable
		{
			// Token: 0x0600012F RID: 303 RVA: 0x00003752 File Offset: 0x00001952
			public DeletedEvent(IWeapon weapon)
			{
				this.weapon = weapon;
			}

			// Token: 0x04000038 RID: 56
			public IWeapon weapon;
		}
	}
}
