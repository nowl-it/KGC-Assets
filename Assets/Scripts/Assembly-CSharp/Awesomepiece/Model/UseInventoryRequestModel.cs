using System;

namespace Awesomepiece.Model
{
	[Serializable]
	public class UseInventoryRequestModel
	{
		public string itemType;

		public int itemID;

		public int count;
	}
}
