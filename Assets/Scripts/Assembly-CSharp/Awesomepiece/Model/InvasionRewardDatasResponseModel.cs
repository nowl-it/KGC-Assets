using System;
using System.Collections.Generic;

namespace Awesomepiece.Model
{
	[Serializable]
	public class InvasionRewardDatasResponseModel : ResponseModel
	{
		[Serializable]
		public class RewardData
		{
			public int index;

			public int pass;

			public long rewardState;

			public RewardData(int index, int pass, long rewardState)
			{
			}
		}

		public List<RewardData> rewardDatas;
	}
}
