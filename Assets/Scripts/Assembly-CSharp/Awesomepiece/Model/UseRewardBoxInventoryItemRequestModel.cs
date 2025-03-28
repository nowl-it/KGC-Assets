using System;

namespace Awesomepiece.Model
{
	[Serializable]
	public class UseRewardBoxInventoryItemRequestModel
	{
		public int itemId;

		public bool[] selectIdx;

		public int count;
	}
}
