using System;

namespace Awesomepiece.Model
{
	[Serializable]
	public class MissionRewardResponseModel : ResponseModel
	{
		public int keyStack;

		public int goal;

		public SeasonPassResponseModel passModel;

		public PlayerTerritoryTycoonResponseModel playerTerritoryTycoon;

		public RewardListResponseData rewardListResponseData;
	}
}
