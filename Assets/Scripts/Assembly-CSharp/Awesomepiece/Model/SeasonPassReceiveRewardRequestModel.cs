using System;
using System.Collections.Generic;

namespace Awesomepiece.Model
{
	[Serializable]
	public class SeasonPassReceiveRewardRequestModel
	{
		public List<int> levels;

		public int level;

		public List<bool> isPassOnly;

		public List<bool> isPremiumOnly;

		public bool passOnlyReward;

		public int bonusId;

		public int targetId;

		public int season;
	}
}
