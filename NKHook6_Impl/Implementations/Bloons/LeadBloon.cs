using System;
using Assets.Scripts.Unity;
using NKHook6_Impl.Extensions;

namespace NKHook6_Impl.Implementations.Bloons
{
	// Token: 0x02000059 RID: 89
	public class LeadBloon : NBloon
	{
		// Token: 0x060000D3 RID: 211 RVA: 0x00002F64 File Offset: 0x00001164
		public LeadBloon() : base(Game.instance.getBloonModel("Lead"))
		{
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00002D3A File Offset: 0x00000F3A
		internal LeadBloon(string modelName) : base(Game.instance.getBloonModel(modelName))
		{
		}
	}
}
