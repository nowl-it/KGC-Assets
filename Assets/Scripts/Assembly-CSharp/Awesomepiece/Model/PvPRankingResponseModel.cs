using System;
using System.Collections.Generic;

namespace Awesomepiece.Model
{
	[Serializable]
	public class PvPRankingResponseModel : ResponseModel
	{
		[Serializable]
		public class PvPRankingData
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

		public List<PvPRankingData> ranking;

		public PvPRankingData playerRank;
	}
}
