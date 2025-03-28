using System;
using System.Collections.Generic;

namespace Awesomepiece.Model
{
	[Serializable]
	public class TreasureWishListRequestModel
	{
		public List<int> treasureIds;

		public ResourceTreasure.Rarity targetRarity;
	}
}
