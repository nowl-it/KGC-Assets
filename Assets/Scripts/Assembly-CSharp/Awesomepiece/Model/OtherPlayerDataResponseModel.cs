using System;
using System.Collections.Generic;

namespace Awesomepiece.Model
{
	[Serializable]
	public class OtherPlayerDataResponseModel : ResponseModel
	{
		public string name;

		public string castleName;

		public int kingPostfix;

		public int castlePostfix;

		public int profileIconId;

		public int profileIconBackgroundId;

		public int nameTagId;

		public int level;

		public int exp;

		public InvasionDifficultyRecord[] invasionDifficultyRecords;

		public int[] eventModeRecord;

		public int[] rogueLikeBuildingChallengeLevelRecord;

		public int[] babelRecord;

		public int winCount;

		public int heroCount;

		public int currentAltar;

		public CardInfo[] currentDeck;

		public int[] currentPotential;

		public int[] currentRanking;

		public int[] currentHardRanking;

		public int clanId;

		public int clanMark;

		public int clanRole;

		public string clanName;

		public int clanTier;

		public List<ClanModel.RoleName> clanRoleNames;
	}
}
