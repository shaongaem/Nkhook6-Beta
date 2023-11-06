using System;
using Assets.Scripts.Models.Bloons;
using NKHook6.API.Bloons;

namespace NKHook6_Impl.Implementations.Bloons
{
	// Token: 0x02000033 RID: 51
	public class NBloon : IBloon
	{
		// Token: 0x06000090 RID: 144 RVA: 0x00002721 File Offset: 0x00000921
		public NBloon()
		{
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00002B5F File Offset: 0x00000D5F
		public NBloon(BloonModel bloonModel)
		{
			this.bloonModel = bloonModel;
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00002B6E File Offset: 0x00000D6E
		public new virtual string GetType()
		{
			return this.bloonModel.name;
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00002B7B File Offset: 0x00000D7B
		public virtual string GetBaseType()
		{
			return this.bloonModel.baseId;
		}

		// Token: 0x06000094 RID: 148 RVA: 0x0000271A File Offset: 0x0000091A
		public virtual IBloon.Modifier[] GetModifiers()
		{
			throw new NotImplementedException();
		}

		// Token: 0x06000095 RID: 149 RVA: 0x0000271A File Offset: 0x0000091A
		public virtual IBloon.Immunity[] GetImmunities()
		{
			throw new NotImplementedException();
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00002B88 File Offset: 0x00000D88
		public virtual float GetMaxHealth()
		{
			return this.bloonModel.maxHealth;
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00002B95 File Offset: 0x00000D95
		public virtual float GetLeakDamage()
		{
			return this.bloonModel.leakDamage;
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00002BA2 File Offset: 0x00000DA2
		public virtual bool IsInvulnerable()
		{
			return this.bloonModel.isInvulnerable;
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00002BAF File Offset: 0x00000DAF
		public virtual float GetSpeed()
		{
			return this.bloonModel.speed;
		}

		// Token: 0x0600009A RID: 154 RVA: 0x00002BBC File Offset: 0x00000DBC
		public virtual float GetSpeedFrames()
		{
			return this.bloonModel.speedFrames;
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00002BC9 File Offset: 0x00000DC9
		public virtual float GetRadius()
		{
			return this.bloonModel.radius;
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00002BD6 File Offset: 0x00000DD6
		public virtual float GetDanger()
		{
			return this.bloonModel.danger;
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00002BE3 File Offset: 0x00000DE3
		public virtual bool IsRotateable()
		{
			return this.bloonModel.rotate;
		}

		// Token: 0x0600009E RID: 158 RVA: 0x0000271A File Offset: 0x0000091A
		public virtual string GetIcon()
		{
			throw new NotImplementedException();
		}

		// Token: 0x0600009F RID: 159 RVA: 0x0000271A File Offset: 0x0000091A
		public virtual string GetDisplay()
		{
			throw new NotImplementedException();
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00002BF0 File Offset: 0x00000DF0
		public virtual string[] GetTags()
		{
			return this.bloonModel.tags;
		}

		// Token: 0x04000022 RID: 34
		private BloonModel bloonModel;
	}
}
