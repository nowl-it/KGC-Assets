using System;

namespace Awesomepiece.Model
{
	[Serializable]
	public class ClanRaidMemberDamageSumModel
	{
		public int accountId;

		public string castleName;

		public string userName;

		public int profileIconId;

		public int profileIconBackgroundId;

		public int nameTagId;

		public long damageSum;

		public string lastUpdatedAt;

		public DateTime lastUpdatedAt_ => default(DateTime);
	}
}
