using System;
using NKHook6.API.Towers.Projectiles;

namespace NKHook6.API.Events._Projectile
{
	// Token: 0x02000027 RID: 39
	public class ProjectileEvents
	{
		// Token: 0x02000092 RID: 146
		[EventHeader("ProjectileCreatedEvent")]
		public class CreatedEvent : EventBaseCancellable
		{
			// Token: 0x06000136 RID: 310 RVA: 0x000037C2 File Offset: 0x000019C2
			public CreatedEvent(IProjectile projectile)
			{
				this.projectile = projectile;
			}

			// Token: 0x04000040 RID: 64
			public IProjectile projectile;
		}

		// Token: 0x02000093 RID: 147
		[EventHeader("ProjectileDeletedEvent")]
		public class DeletedEvent : EventBaseCancellable
		{
			// Token: 0x06000137 RID: 311 RVA: 0x000037D1 File Offset: 0x000019D1
			public DeletedEvent(IProjectileEntity projectile)
			{
				this.projectile = projectile;
			}

			// Token: 0x04000041 RID: 65
			public IProjectileEntity projectile;
		}
	}
}
