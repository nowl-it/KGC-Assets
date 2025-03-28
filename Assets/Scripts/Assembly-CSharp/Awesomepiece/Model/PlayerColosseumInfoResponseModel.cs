using System;
using System.Collections.Generic;

namespace Awesomepiece.Model
{
	[Serializable]
	public class PlayerColosseumInfoResponseModel : ResponseModel
	{
		public int season;

		public int leagueSeason;

		public int score;

		public int tier;

		public int rank;

		public int bestScore;

		public int bestTier;

		public int winCount;

		public int loseCount;

		public int gameCount;

		public int semiSeason;

		public List<LeagueContentScoreData> semiSeasonScoreDatas;

		public string[] seasonUntilAtDates;

		public string[] nextSeasonStartAtDates;

		public bool colosseumEnabled;

		public List<int> receivedRewards;

		public int[] freeRewardCountPerBox;

		public DateTime GetCurrentSeasonUntilAt()
		{
			return default(DateTime);
		}

		public DateTime GetNextSeasonStartAt()
		{
			return default(DateTime);
		}

		public DateTime GetSeasonUntilAt(int semiSeason)
		{
			return default(DateTime);
		}

		public DateTime GetSeasonStartAt(int semiSeason)
		{
			return default(DateTime);
		}
	}
}
