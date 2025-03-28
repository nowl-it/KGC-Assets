using System;
using System.Collections.Generic;

namespace Awesomepiece.Model
{
	[Serializable]
	public class ClanMemberRankingResponseModel : ResponseModel
	{
		public List<ClanPersonalRankingResponseModel.ClanPersonalRankingData> ranking;
	}
}
