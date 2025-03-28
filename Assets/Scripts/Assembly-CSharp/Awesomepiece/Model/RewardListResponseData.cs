using System;
using System.Collections.Generic;

namespace Awesomepiece.Model
{
	[Serializable]
	public class RewardListResponseData
	{
		public List<RewardResponseData> rewardList;

		public ArtifactResultResponseModel artifactResult;

		public TreasureResultResponseModel treasureResult;

		public AccessoryResultResponseModel accessoryResult;

		public static RewardListResponseData MockUpRewardList(IEnumerable<Reward> rewards)
		{
			return null;
		}
	}
}
