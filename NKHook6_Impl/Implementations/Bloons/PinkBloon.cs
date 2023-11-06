using System;
using Assets.Scripts.Unity;
using NKHook6_Impl.Extensions;

namespace NKHook6_Impl.Implementations.Bloons
{
	// Token: 0x02000045 RID: 69
	public class PinkBloon : NBloon
	{
		// Token: 0x060000BA RID: 186 RVA: 0x00002E2E File Offset: 0x0000102E
		public PinkBloon() : base(Game.instance.getBloonModel("Pink"))
		{
		}

		// Token: 0x060000BB RID: 187 RVA: 0x00002D3A File Offset: 0x00000F3A
		internal PinkBloon(string modelName) : base(Game.instance.getBloonModel(modelName))
		{
		}
	}
}
