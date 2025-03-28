using System;
using System.Collections.Generic;

namespace Awesomepiece.Model
{
	[Serializable]
	public class AccessoryRequestModel
	{
		public int targetId;

		public int unitId;

		public int state;

		public List<InventoryItem> expItems;
	}
}
