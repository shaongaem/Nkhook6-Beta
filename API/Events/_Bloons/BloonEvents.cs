using System;
using NKHook6.API.Bloons;
using NKHook6.API.Towers;
using NKHook6.API.Towers.Projectiles;

namespace NKHook6.API.Events._Bloons
{
	// Token: 0x0200002B RID: 43
	public class BloonEvents
	{
		// Token: 0x0200009F RID: 159
		[EventHeader("BloonCreatedEvent")]
		public class CreatedEvent : EventBase, BloonEvent
		{
			// Token: 0x06000143 RID: 323 RVA: 0x00003890 File Offset: 0x00001A90
			public CreatedEvent(IBloonEntity bloon)
			{
				this.bloon = bloon;
			}

			// Token: 0x06000144 RID: 324 RVA: 0x0000389F File Offset: 0x00001A9F
			public IBloonEntity GetBloon()
			{
				return this.bloon;
			}

			// Token: 0x04000050 RID: 80
			private IBloonEntity bloon;
		}

		// Token: 0x020000A0 RID: 160
		[EventHeader("BloonDamagedEvent")]
		public class DamagedEvent : EventBaseCancellable, BloonEvent
		{
			// Token: 0x17000006 RID: 6
			// (get) Token: 0x06000145 RID: 325 RVA: 0x000038A7 File Offset: 0x00001AA7
			// (set) Token: 0x06000146 RID: 326 RVA: 0x000038AF File Offset: 0x00001AAF
			private float damageTaken { get; set; }

			// Token: 0x17000007 RID: 7
			// (get) Token: 0x06000147 RID: 327 RVA: 0x000038B8 File Offset: 0x00001AB8
			// (set) Token: 0x06000148 RID: 328 RVA: 0x000038C0 File Offset: 0x00001AC0
			private string[] damageTypes { get; set; }

			// Token: 0x17000008 RID: 8
			// (get) Token: 0x06000149 RID: 329 RVA: 0x000038C9 File Offset: 0x00001AC9
			// (set) Token: 0x0600014A RID: 330 RVA: 0x000038D1 File Offset: 0x00001AD1
			private IProjectileEntity projectile { get; set; }

			// Token: 0x17000009 RID: 9
			// (get) Token: 0x0600014B RID: 331 RVA: 0x000038DA File Offset: 0x00001ADA
			// (set) Token: 0x0600014C RID: 332 RVA: 0x000038E2 File Offset: 0x00001AE2
			private bool distrubuteToChildren { get; set; }

			// Token: 0x1700000A RID: 10
			// (get) Token: 0x0600014D RID: 333 RVA: 0x000038EB File Offset: 0x00001AEB
			// (set) Token: 0x0600014E RID: 334 RVA: 0x000038F3 File Offset: 0x00001AF3
			private bool overrideDistributeBlocker { get; set; }

			// Token: 0x1700000B RID: 11
			// (get) Token: 0x0600014F RID: 335 RVA: 0x000038FC File Offset: 0x00001AFC
			// (set) Token: 0x06000150 RID: 336 RVA: 0x00003904 File Offset: 0x00001B04
			private bool createEffect { get; set; }

			// Token: 0x1700000C RID: 12
			// (get) Token: 0x06000151 RID: 337 RVA: 0x0000390D File Offset: 0x00001B0D
			// (set) Token: 0x06000152 RID: 338 RVA: 0x00003915 File Offset: 0x00001B15
			private ITowerEntity tower { get; set; }

			// Token: 0x1700000D RID: 13
			// (get) Token: 0x06000153 RID: 339 RVA: 0x0000391E File Offset: 0x00001B1E
			// (set) Token: 0x06000154 RID: 340 RVA: 0x00003926 File Offset: 0x00001B26
			private bool canDestroyProjectile { get; set; }

			// Token: 0x1700000E RID: 14
			// (get) Token: 0x06000155 RID: 341 RVA: 0x0000392F File Offset: 0x00001B2F
			// (set) Token: 0x06000156 RID: 342 RVA: 0x00003937 File Offset: 0x00001B37
			private string[] ignoreImmunityForBloonTypes { get; set; }

			// Token: 0x1700000F RID: 15
			// (get) Token: 0x06000157 RID: 343 RVA: 0x00003940 File Offset: 0x00001B40
			// (set) Token: 0x06000158 RID: 344 RVA: 0x00003948 File Offset: 0x00001B48
			private bool ignoreNonTargetables { get; set; }

			// Token: 0x17000010 RID: 16
			// (get) Token: 0x06000159 RID: 345 RVA: 0x00003951 File Offset: 0x00001B51
			// (set) Token: 0x0600015A RID: 346 RVA: 0x00003959 File Offset: 0x00001B59
			private bool blockSpawnChildren { get; set; }

			// Token: 0x0600015B RID: 347 RVA: 0x00003964 File Offset: 0x00001B64
			public DamagedEvent(IBloonEntity bloon, float totalAmount, string[] types, IProjectileEntity projectile, bool distributeToChildren, bool overrideDistributeBlocker, bool createEffect, ITowerEntity tower, bool canDestroyProjectile, string[] ignoreImmunityForBloonTypes, bool ignoreNonTargetable, bool blockSpawnChildren)
			{
				this.bloon = bloon;
				this.damageTaken = totalAmount;
				this.damageTypes = types;
				this.projectile = projectile;
				this.distrubuteToChildren = distributeToChildren;
				this.overrideDistributeBlocker = overrideDistributeBlocker;
				this.createEffect = createEffect;
				this.tower = tower;
				this.canDestroyProjectile = canDestroyProjectile;
				this.ignoreImmunityForBloonTypes = ignoreImmunityForBloonTypes;
				this.ignoreNonTargetables = ignoreNonTargetable;
				this.blockSpawnChildren = blockSpawnChildren;
			}

			// Token: 0x0600015C RID: 348 RVA: 0x000039D4 File Offset: 0x00001BD4
			public IBloonEntity GetBloon()
			{
				return this.bloon;
			}

			// Token: 0x04000051 RID: 81
			private IBloonEntity bloon;
		}

		// Token: 0x020000A1 RID: 161
		[EventHeader("BloonDeletedEvent")]
		public class DeletedEvent : EventBaseCancellable, BloonEvent
		{
			// Token: 0x0600015D RID: 349 RVA: 0x000039DC File Offset: 0x00001BDC
			public DeletedEvent(IBloonEntity bloon)
			{
				this.bloon = bloon;
			}

			// Token: 0x0600015E RID: 350 RVA: 0x000039EB File Offset: 0x00001BEB
			public IBloonEntity GetBloon()
			{
				return this.bloon;
			}

			// Token: 0x0400005D RID: 93
			private IBloonEntity bloon;
		}

		// Token: 0x020000A2 RID: 162
		[EventHeader("BloonLeakedEvent")]
		public class LeakedEvent : EventBaseCancellable, BloonEvent
		{
			// Token: 0x0600015F RID: 351 RVA: 0x000039F3 File Offset: 0x00001BF3
			public LeakedEvent(IBloonEntity bloon)
			{
				this.bloon = bloon;
			}

			// Token: 0x06000160 RID: 352 RVA: 0x00003A02 File Offset: 0x00001C02
			public IBloonEntity GetBloon()
			{
				return this.bloon;
			}

			// Token: 0x0400005E RID: 94
			private IBloonEntity bloon;
		}

		// Token: 0x020000A3 RID: 163
		[EventHeader("BloonMoveEvent")]
		public class MoveEvent : EventBaseCancellable, BloonEvent
		{
			// Token: 0x06000161 RID: 353 RVA: 0x00003A0A File Offset: 0x00001C0A
			public MoveEvent(IBloonEntity bloon)
			{
				this.bloon = bloon;
			}

			// Token: 0x06000162 RID: 354 RVA: 0x00003A19 File Offset: 0x00001C19
			public IBloonEntity GetBloon()
			{
				return this.bloon;
			}

			// Token: 0x0400005F RID: 95
			private IBloonEntity bloon;
		}

		// Token: 0x020000A4 RID: 164
		[EventHeader("BloonRotateEvent")]
		public class RotateEvent : EventBaseCancellable, BloonEvent
		{
			// Token: 0x06000163 RID: 355 RVA: 0x00003A21 File Offset: 0x00001C21
			public RotateEvent(IBloonEntity bloon, float rotation)
			{
				this.bloon = bloon;
				this.rotation = rotation;
			}

			// Token: 0x06000164 RID: 356 RVA: 0x00003A37 File Offset: 0x00001C37
			public IBloonEntity GetBloon()
			{
				return this.bloon;
			}

			// Token: 0x04000060 RID: 96
			private IBloonEntity bloon;

			// Token: 0x04000061 RID: 97
			private float rotation;
		}
	}
}
