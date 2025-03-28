using System;
using System.Collections.Generic;

namespace Awesomepiece.Model
{
	[Serializable]
	public class TreasureWishListResponseModel : ResponseModel
	{
		public Dictionary<ResourceTreasure.Rarity, List<int>> wishList;
	}
}
