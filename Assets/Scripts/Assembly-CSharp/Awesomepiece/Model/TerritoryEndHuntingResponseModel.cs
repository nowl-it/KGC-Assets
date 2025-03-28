using System;

namespace Awesomepiece.Model
{
	[Serializable]
	public class TerritoryEndHuntingResponseModel : ResponseModel
	{
		public RewardListResponseData rewardListResponseData;

		public TerritoryHuntingData territoryHuntingData;

		public string rank;
	}
}
