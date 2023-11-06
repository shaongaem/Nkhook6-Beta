using System;
using System.Collections.Generic;
using System.Linq;
using Assets.Scripts.Models.Bloons;
using Assets.Scripts.Models.Towers;
using Assets.Scripts.Unity;

namespace NKHook6_Impl.Extensions
{
	// Token: 0x02000079 RID: 121
	public static class GameExt
	{
		// Token: 0x060000FB RID: 251 RVA: 0x00003154 File Offset: 0x00001354
		public static BloonModel getBloonModel(this Game game, string bloonName)
		{
			return game.model.GetBloon(bloonName);
		}

		// Token: 0x060000FC RID: 252 RVA: 0x00003162 File Offset: 0x00001362
		public static List<BloonModel> getAllBloonModels(this Game game)
		{
			return Enumerable.ToList<BloonModel>(game.model.bloons);
		}

		// Token: 0x060000FD RID: 253 RVA: 0x00003174 File Offset: 0x00001374
		public static TowerModel getTowerModel(this Game game, string towerID, int pathATier = 0, int pathBTier = 0, int pathCTier = 0)
		{
			return game.model.GetTower(towerID, pathATier, pathBTier, pathCTier);
		}

		// Token: 0x060000FE RID: 254 RVA: 0x00003186 File Offset: 0x00001386
		public static List<TowerModel> getAllTowerModels(this Game game)
		{
			return Enumerable.ToList<TowerModel>(game.model.towers);
		}
	}
}
