using System;
using Assets.Scripts.Unity;
using NKHook6_Impl.Extensions;

namespace NKHook6_Impl.Implementations.Bloons
{
	// Token: 0x0200006D RID: 109
	public class MoabBloon : NBloon
	{
		// Token: 0x060000EA RID: 234 RVA: 0x00003086 File Offset: 0x00001286
		public MoabBloon() : base(Game.instance.getBloonModel("Moab"))
		{
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00002D3A File Offset: 0x00000F3A
		internal MoabBloon(string modelName) : base(Game.instance.getBloonModel(modelName))
		{
		}
	}
}
