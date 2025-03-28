using System;
using System.Collections.Generic;

namespace Awesomepiece.Model
{
	[Serializable]
	public class TreasureCheckWishListValidRequestModel
	{
		public Dictionary<ResourceTreasure.Rarity, List<int>> wishList;
	}
}
