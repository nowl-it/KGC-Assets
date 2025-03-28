using System;
using System.Collections.Generic;

namespace Awesomepiece.Model
{
	[Serializable]
	public class TreasureRequestModel
	{
		public int targetId;

		public List<int> materialTreasureIds;

		public int materialItemCount;

		public int unitId;

		public int state;

		public List<InventoryItem> expItems;
	}
}
