using System;
using System.Collections.Generic;

namespace Awesomepiece.Model
{
	[Serializable]
	public class GameResponseModel : ResponseModel
	{
		public int addGold;

		public int addExp;

		public int addCash;

		public int unitExpItem;

		public int unitSoulItem;

		public int adBonusGold;

		public int adBonusRemainCount;

		public int playerGold;

		public int playerLevel;

		public int playerExp;

		public bool rankedIn;

		public int addRankScore;

		public int rankScore;

		public int rankTier;

		public int ppRewardCount;

		public bool isFirstPvpPlay;

		public bool isFirstEventModePlay;

		public List<int> addArtifactCounts;

		public List<int> addArtifactIds;

		public List<ArtifactModel> artifacts;

		public List<AccessoryModel> addAccessories;

		public int addArenaToken;

		public int addPassPoint;

		public List<int> addCardExpCardIds;

		public List<int> addCardExpCounts;

		public int addSeasonalEventToken;

		public int addClanToken;

		public int clanBossRemainHp;

		public int rogueLikeScore;

		public int hotTimeBonusValue;

		public int addClanPoint;

		public int addHardModeToken;

		public int colosseumScore;

		public int colosseumScoreDelta;

		public int colosseumTier;
	}
}
