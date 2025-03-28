using System;
using System.Collections.Generic;

namespace Awesomepiece.Model
{
	[Serializable]
	public class ClanModel
	{
		[Serializable]
		public class RoleName
		{
			public int role;

			public string name;

			public RoleName(int role, string name)
			{
			}
		}

		public int id;

		public string name;

		public int markId;

		public int language;

		public List<int> keywords;

		public int joinType;

		public string intro;

		public int battleTier;

		public int tier;

		public int point;

		public int contribution;

		public int weeklyContribution;

		public int memberCount;

		public int maxMemberCount;

		public string masterName;

		public int masterAccountId;

		public bool nameBanned;

		public List<RoleName> roleNames;

		public string notice;

		public List<ClanMemberModel> members;

		public List<ClanChatModel> chats;

		public List<ClanMemberModel> joinRequests;

		public int goldBonusTier;

		public bool canMandateMaster;

		public int clanRaidRank;

		public int clanPointRank;

		public int weeklyClanPointRank;
	}
}
