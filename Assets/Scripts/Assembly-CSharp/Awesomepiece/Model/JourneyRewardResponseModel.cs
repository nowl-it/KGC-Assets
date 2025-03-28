using System;
using System.Collections.Generic;

namespace Awesomepiece.Model
{
	[Serializable]
	public class JourneyRewardResponseModel : ResponseModel
	{
		public RewardListResponseData rewardList;

		public List<KeyValue> keyValues;
	}
}
