using System;

namespace Awesomepiece.Model
{
	[Serializable]
	public class UseRewardBoxInventoryItemResponseModel : ResponseModel
	{
		public RewardListResponseData rewardList;

		public RewardListResponseData addedRewardList;

		public InventoryItem boxRewardInventory;
	}
}
