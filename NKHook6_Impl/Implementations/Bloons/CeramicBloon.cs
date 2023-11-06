using System;
using Assets.Scripts.Unity;
using NKHook6_Impl.Extensions;

namespace NKHook6_Impl.Implementations.Bloons
{
	// Token: 0x02000065 RID: 101
	public class CeramicBloon : NBloon
	{
		// Token: 0x060000E1 RID: 225 RVA: 0x00003014 File Offset: 0x00001214
		public CeramicBloon() : base(Game.instance.getBloonModel("Ceramic"))
		{
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00002D3A File Offset: 0x00000F3A
		internal CeramicBloon(string modelName) : base(Game.instance.getBloonModel(modelName))
		{
		}
	}
}
