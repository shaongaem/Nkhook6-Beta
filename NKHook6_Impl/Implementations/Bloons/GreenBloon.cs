using System;
using Assets.Scripts.Unity;
using NKHook6_Impl.Extensions;

namespace NKHook6_Impl.Implementations.Bloons
{
	// Token: 0x0200003D RID: 61
	public class GreenBloon : NBloon
	{
		// Token: 0x060000B0 RID: 176 RVA: 0x00002DB2 File Offset: 0x00000FB2
		public GreenBloon() : base(Game.instance.getBloonModel("Green"))
		{
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00002D3A File Offset: 0x00000F3A
		internal GreenBloon(string modelName) : base(Game.instance.getBloonModel(modelName))
		{
		}
	}
}
