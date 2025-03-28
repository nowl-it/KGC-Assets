using System;

namespace Awesomepiece.Model
{
	[Serializable]
	public class ClanMemberModel
	{
		public int accountId;

		public int role;

		public string castleName;

		public string userName;

		public int contribution;

		public int weeklyContribution;

		public int profileIconId;

		public int profileIconBackgroundId;

		public int flagId;

		public int nameTagId;

		public string lastLogined;

		public int playerLevel;

		public DateTime lastLogined_ => default(DateTime);
	}
}
