using System;
using System.Collections.Generic;

namespace Awesomepiece.Model
{
	[Serializable]
	public class ClanRaidModel
	{
		public int clanId;

		public long score;

		public int killCount;

		public int stage;

		public int round;

		public int boss;

		public int remainHp;

		public int currentPlayer;

		public string currentPlayerName;

		public string battleStartedAt;

		public int remainBattleCount;

		public int remainResetCount;

		public List<ClanRaidDeckInfo> decks;

		public ClanRaidCardInfo supportUnitCardInfo;

		public ClanRaidRetryInfo retryInfo;

		public int[] bossList;

		public int seasonEndRank;

		public int goldBonusTier;

		public List<int> usedSupporter;

		public DateTime battleStartedAt_ => default(DateTime);
	}
}
