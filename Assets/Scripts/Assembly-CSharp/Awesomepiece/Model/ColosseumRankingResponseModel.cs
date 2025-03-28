using System;
using System.Collections.Generic;

namespace Awesomepiece.Model
{
	[Serializable]
	public class ColosseumRankingResponseModel : ResponseModel
	{
		[Serializable]
		public class ColosseumRankingData
		{
			public int rank;

			public int score;

			public int accountId;

			public string userName;

			public string castleName;

			public int kingPostfix;

			public int castlePostfix;

			public int flagId;

			public int nameTagId;

			public int profileIcon;

			public int tier;
		}

		public List<ColosseumRankingData> ranking;

		public ColosseumRankingData playerRank;
	}
}
