using System;
using System.Collections.Generic;

namespace Awesomepiece.Model
{
	[Serializable]
	public class ClanRaidDeckInfoResponseModel : ResponseModel
	{
		public List<ClanRaidDeckInfo> clanRaidDeckInfos;

		public ClanRaidRetryInfo retryInfo;
	}
}
