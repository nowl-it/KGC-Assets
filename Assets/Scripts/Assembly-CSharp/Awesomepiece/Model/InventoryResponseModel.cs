using System;
using System.Collections.Generic;

namespace Awesomepiece.Model
{
	[Serializable]
	public class InventoryResponseModel : ResponseModel
	{
		public List<int> itemIds;

		public List<int> counts;
	}
}
