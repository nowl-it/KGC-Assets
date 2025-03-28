using System;
using System.Collections.Generic;

namespace Awesomepiece.Model
{
	[Serializable]
	public class TreasureResultResponseModel : ResponseModel
	{
		public List<TreasureModel> treasures;

		public List<int> deletedTreasures;

		public int playerGold;

		public int playerCash;

		public List<InventoryItem> inventories;

		public int addedExpItems;
	}
}
