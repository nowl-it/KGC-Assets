using System;

namespace Awesomepiece.Model
{
	[Serializable]
	public class TerritoryAlchemyResponseModel : ResponseModel
	{
		public RewardListResponseData rewardListResponseData;

		public RewardListResponseData consumedListData;

		public int jackpotLevel;
	}
}
