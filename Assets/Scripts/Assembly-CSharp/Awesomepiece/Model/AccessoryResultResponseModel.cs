using System;
using System.Collections.Generic;

namespace Awesomepiece.Model
{
	[Serializable]
	public class AccessoryResultResponseModel : ResponseModel
	{
		public List<AccessoryModel> accessories;

		public List<int> deletedAccessories;

		public int playerGold;

		public int playerCash;

		public List<InventoryItem> inventories;

		public int addedExpItems;
	}
}
