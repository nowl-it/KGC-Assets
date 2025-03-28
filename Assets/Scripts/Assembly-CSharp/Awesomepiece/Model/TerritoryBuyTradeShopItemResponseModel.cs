using System;

namespace Awesomepiece.Model
{
	[Serializable]
	public class TerritoryBuyTradeShopItemResponseModel : ResponseModel
	{
		public RewardListResponseData rewardListResponseData;

		public RewardListResponseData consumedListData;

		public TerritoryTradeShopItemData tradeShopItemData;
	}
}
