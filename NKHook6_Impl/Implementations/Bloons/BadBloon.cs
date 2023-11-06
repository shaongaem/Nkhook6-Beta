using System;
using Assets.Scripts.Unity;
using NKHook6_Impl.Extensions;

namespace NKHook6_Impl.Implementations.Bloons
{
	// Token: 0x02000077 RID: 119
	public class BadBloon : NBloon
	{
		// Token: 0x060000F8 RID: 248 RVA: 0x00003130 File Offset: 0x00001330
		public BadBloon() : base(Game.instance.getBloonModel("Bad"))
		{
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x00002D3A File Offset: 0x00000F3A
		internal BadBloon(string modelName) : base(Game.instance.getBloonModel(modelName))
		{
		}
	}
}
