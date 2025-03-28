using System;
using System.Collections.Generic;

namespace Awesomepiece.Model
{
	[Serializable]
	public class RogueLikeRankingResponseModel : ResponseModel
	{
		[Serializable]
		public class RogueLikeRankingData
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

			public int challenge;

			public int building;
		}

		public List<RogueLikeRankingData> ranking;

		public RogueLikeRankingData playerRank;
	}
}
