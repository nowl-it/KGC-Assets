using System;
using System.Collections.Generic;

namespace Awesomepiece.Model
{
	[Serializable]
	public class PvPInfoResponseModel : ResponseModel
	{
		public int season;

		public bool pvpEnabled;

		public string[] seasonUntilAtDates;

		public string[] nextSeasonStartAtDates;

		public int theme;

		public int deckRecordDifficulty;

		public int score;

		public int tier;

		public int rank;

		public int bestScore;

		public int bestTier;

		public int semiSeason;

		public List<LeagueContentScoreData> semiSeasonScoreDatas;

		public PvPDeckInfo deckInfo;

		public int remainRetryCount;

		public int retryPrice;

		public int freeRetryChance;

		public int[] deckRecord;

		public List<int> receivedRewards;

		public int currentDeckPlayCount;

		public int arenaTokenBonusCount;

		public string dormantScoreDecreaseAt;

		public int[] semiSeasonBannedHeroIds;

		public int[] semiSeasonBannedTreasureIds;

		public int currentSemiSeasonWinCount;

		public bool[] winRewardReceived;

		public int remainTrainingCount;

		public DateTime dormantScoreDecreaseAt_ => default(DateTime);

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
