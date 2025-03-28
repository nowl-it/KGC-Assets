using System;

namespace Awesomepiece.Model
{
	[Serializable]
	public class SeasonPassReceiveRewardResponseModel : ResponseModel
	{
		public RewardListResponseData rewardListResponseData;

		public SeasonPassResponseModel pass;
	}
}
