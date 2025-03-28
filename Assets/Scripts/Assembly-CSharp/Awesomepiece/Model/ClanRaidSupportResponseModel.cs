using System;
using System.Collections.Generic;

namespace Awesomepiece.Model
{
	[Serializable]
	public class ClanRaidSupportResponseModel : ResponseModel
	{
		public List<ClanRaidSupportModel> supporters;
	}
}
