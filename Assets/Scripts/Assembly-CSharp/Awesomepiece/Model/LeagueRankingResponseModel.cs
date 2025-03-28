using System;
using System.Collections.Generic;

namespace Awesomepiece.Model
{
	[Serializable]
	public class LeagueRankingResponseModel : ResponseModel
	{
		public List<LeagueRankingData> ranking;

		public LeagueRankingData playerRank;
	}
}
