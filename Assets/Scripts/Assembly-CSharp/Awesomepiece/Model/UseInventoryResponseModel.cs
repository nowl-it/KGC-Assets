using System;
using System.Collections.Generic;

namespace Awesomepiece.Model
{
	[Serializable]
	public class UseInventoryResponseModel : ResponseModel
	{
		public int playerHeart;

		public int eventFlag;

		public List<InventoryItem> inventoryItems;
	}
}
