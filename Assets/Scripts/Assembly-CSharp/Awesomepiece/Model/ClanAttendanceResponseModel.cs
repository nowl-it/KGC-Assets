using System;
using System.Collections.Generic;

namespace Awesomepiece.Model
{
	[Serializable]
	public class ClanAttendanceResponseModel : ResponseModel
	{
		public int clanPoint;

		public int clanTier;

		public List<TokenInfo> tokens;
	}
}
