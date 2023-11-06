using System;
using Assets.Scripts.Unity;
using NKHook6_Impl.Extensions;

namespace NKHook6_Impl.Implementations.Bloons
{
	// Token: 0x0200006F RID: 111
	public class BfbBloon : NBloon
	{
		// Token: 0x060000ED RID: 237 RVA: 0x000030AA File Offset: 0x000012AA
		public BfbBloon() : base(Game.instance.getBloonModel("Bfb"))
		{
		}

		// Token: 0x060000EE RID: 238 RVA: 0x00002D3A File Offset: 0x00000F3A
		internal BfbBloon(string modelName) : base(Game.instance.getBloonModel(modelName))
		{
		}
	}
}
