using System;

namespace Awesomepiece.Model
{
	[Serializable]
	public class PlayerInventoryCountResponseModel : ResponseModel
	{
		public int playerCash;

		public int inventoryCount;
	}
}
