using System;
using System.Collections.Generic;

namespace Awesomepiece.Model
{
	[Serializable]
	public class SearchClanResponseModel : ResponseModel
	{
		public List<ClanModel> resultClans;

		public int nextSearchStartOffset;
	}
}
