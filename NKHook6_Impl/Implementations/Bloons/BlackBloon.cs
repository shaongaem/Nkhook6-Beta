using System;
using Assets.Scripts.Unity;
using NKHook6_Impl.Extensions;

namespace NKHook6_Impl.Implementations.Bloons
{
	// Token: 0x02000049 RID: 73
	public class BlackBloon : NBloon
	{
		// Token: 0x060000BF RID: 191 RVA: 0x00002E6C File Offset: 0x0000106C
		public BlackBloon() : base(Game.instance.getBloonModel("Black"))
		{
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00002D3A File Offset: 0x00000F3A
		internal BlackBloon(string modelName) : base(Game.instance.getBloonModel(modelName))
		{
		}
	}
}
