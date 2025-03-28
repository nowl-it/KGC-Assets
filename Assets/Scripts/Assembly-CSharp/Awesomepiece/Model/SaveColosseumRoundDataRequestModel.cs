using System.Collections.Generic;

namespace Awesomepiece.Model
{
	public class SaveColosseumRoundDataRequestModel
	{
		public class ColosseumRoundData : GameCompleteRequestModel.RoundData
		{
			public List<int> usedInvadeItems;

			public List<int> obtainedAbilities;

			public List<int> obtainedTarots;

			public bool win;

			public int enemyBerserkValue;
		}

		public int round;

		public ColosseumRoundData roundData;
	}
}
