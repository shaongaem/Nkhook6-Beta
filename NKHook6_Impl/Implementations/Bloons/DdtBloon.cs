using System;
using Assets.Scripts.Unity;
using NKHook6_Impl.Extensions;

namespace NKHook6_Impl.Implementations.Bloons
{
	// Token: 0x02000073 RID: 115
	public class DdtBloon : NBloon
	{
		// Token: 0x060000F3 RID: 243 RVA: 0x000030F2 File Offset: 0x000012F2
		public DdtBloon() : base(Game.instance.getBloonModel("Ddt"))
		{
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x00002D3A File Offset: 0x00000F3A
		internal DdtBloon(string modelName) : base(Game.instance.getBloonModel(modelName))
		{
		}
	}
}
