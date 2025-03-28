using System;

namespace Awesomepiece.Model
{
	[Serializable]
	public class ClanRaidBestDeckModel
	{
		public int accountId;

		public int clanId;

		public int bossId;

		public int season;

		public int score;

		public ClanRaidDeckData deck;

		public string lastBattleTime;

		public string userName;

		public string castleName;

		public int kingPostfix;

		public int castlePostfix;

		public int profileIconId;

		public int nameTagId;

		public DateTime lastBattleTime_ => default(DateTime);
	}
}
