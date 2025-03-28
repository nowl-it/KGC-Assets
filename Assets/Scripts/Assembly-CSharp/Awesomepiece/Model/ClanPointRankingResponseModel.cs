using System;
using System.Collections.Generic;

namespace Awesomepiece.Model
{
	[Serializable]
	public class ClanPointRankingResponseModel : ResponseModel
	{
		[Serializable]
		public class ClanPointRankingData
		{
			public int rank;

			public int clanPoint;

			public int clanTier;

			public int battleTier;

			public int clanId;

			public string clanName;

			public int markId;
		}

		public List<ClanPointRankingData> ranking;

		public ClanPointRankingData playerClanRank;
	}
}
