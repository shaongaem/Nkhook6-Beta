using System;
using Assets.Scripts.Unity;
using NKHook6_Impl.Extensions;

namespace NKHook6_Impl.Implementations.Bloons
{
	// Token: 0x02000051 RID: 81
	public class PurpleBloon : NBloon
	{
		// Token: 0x060000C9 RID: 201 RVA: 0x00002EE8 File Offset: 0x000010E8
		public PurpleBloon() : base(Game.instance.getBloonModel("Purple"))
		{
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00002D3A File Offset: 0x00000F3A
		internal PurpleBloon(string modelName) : base(Game.instance.getBloonModel(modelName))
		{
		}
	}
}
