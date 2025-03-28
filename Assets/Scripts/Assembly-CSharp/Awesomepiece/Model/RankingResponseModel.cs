using System;
using System.Collections.Generic;

namespace Awesomepiece.Model
{
	[Serializable]
	public class RankingResponseModel : ResponseModel
	{
		[Serializable]
		public class RankingData
		{
			public int rank;

			public long score;

			public int accountId;

			public string userName;

			public string castleName;

			public int kingPostfix;

			public int castlePostfix;

			public int[] deck;
		}

		public string rankingType;

		public List<RankingData> ranking;

		public RankingData playerRank;
	}
}
