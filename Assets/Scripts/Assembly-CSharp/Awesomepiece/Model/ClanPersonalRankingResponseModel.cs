using System;
using System.Collections.Generic;

namespace Awesomepiece.Model
{
	[Serializable]
	public class ClanPersonalRankingResponseModel : ResponseModel
	{
		[Serializable]
		public class ClanPersonalRankingData
		{
			public int rank;

			public int score;

			public int accountId;

			public string userName;

			public string castleName;

			public int kingPostfix;

			public int castlePostfix;

			public int profileIcon;

			public int flagId;

			public int nameTagId;

			public string lastUpdatedAt;

			public DateTime lastUpdatedAt_ => default(DateTime);
		}

		public List<ClanPersonalRankingData> ranking;

		public ClanPersonalRankingData playerClanRank;
	}
}
