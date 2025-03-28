using System;

namespace Awesomepiece.Model
{
	[Serializable]
	public class ClanRaidResponseModel : ResponseModel
	{
		public ClanRaidModel clanRaid;

		public bool killBoss;
	}
}
