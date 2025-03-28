using System;
using System.Collections.Generic;

namespace Awesomepiece.Model
{
	[Serializable]
	public class CardWithCandiesResponseModel : ResponseModel
	{
		public CardResponseModel cardResponseModel;

		public List<InventoryItem> candies;
	}
}
