using System;

namespace Awesomepiece.Model
{
	[Serializable]
	public class ClanResponseModel : ResponseModel
	{
		public ClanModel clan;

		public int role;

		public string requestSupportCooltime;

		public ClanSupportCompletedModel supportCompletedModel;

		public string seasonUntilAtDate;

		public string nextSeasonStartAtDate;

		public bool clanRaidEnabled;

		public string clanRaidUntilAtDate;

		public string nextClanRaidStartAtDate;

		public string canPlayClanRaidAt;

		public string clanRaidLockedByLeaveUntilAt;

		public DateTime requestSupportCooltime_ => default(DateTime);

		public DateTime seasonUntilAtDate_ => default(DateTime);

		public DateTime nextSeasonStartAtDate_ => default(DateTime);

		public DateTime clanRaidUntilAtDate_ => default(DateTime);

		public DateTime nextClanRaidStartAtDate_ => default(DateTime);

		public DateTime canPlayClanRaidAt_ => default(DateTime);

		public DateTime clanRaidLockedByLeaveUntilAt_ => default(DateTime);
	}
}
