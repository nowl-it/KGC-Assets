using System;
using System.Collections.Generic;

namespace Awesomepiece.Model
{
	[Serializable]
	public class ClanRaidMemberDamageSumResponseModel : ResponseModel
	{
		public List<ClanRaidMemberDamageSumModel> members;
	}
}
