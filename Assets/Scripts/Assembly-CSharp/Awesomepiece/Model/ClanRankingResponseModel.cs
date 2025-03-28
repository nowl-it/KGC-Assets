using System;
using System.Collections.Generic;

namespace Awesomepiece.Model
{
	[Serializable]
	public class ClanRankingResponseModel : ResponseModel
	{
		[Serializable]
		public class ClanRankingData
		{
			public int rank;

			public float score;

			public int tier;

			public int clanId;

			public string clanName;

			public int markId;

			public int stage;

			public int round;

			public int boss;
		}

		public List<ClanRankingData> ranking;

		public ClanRankingData playerClanRank;
	}
}
