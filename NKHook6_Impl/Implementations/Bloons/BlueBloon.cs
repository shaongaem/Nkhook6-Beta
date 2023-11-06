using System;
using Assets.Scripts.Unity;
using NKHook6_Impl.Extensions;

namespace NKHook6_Impl.Implementations.Bloons
{
	// Token: 0x02000039 RID: 57
	public class BlueBloon : NBloon
	{
		// Token: 0x060000AB RID: 171 RVA: 0x00002D74 File Offset: 0x00000F74
		public BlueBloon() : base(Game.instance.getBloonModel("Blue"))
		{
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00002D3A File Offset: 0x00000F3A
		internal BlueBloon(string modelName) : base(Game.instance.getBloonModel(modelName))
		{
		}
	}
}
