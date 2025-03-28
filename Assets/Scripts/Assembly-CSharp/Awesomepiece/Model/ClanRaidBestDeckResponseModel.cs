using System;
using System.Collections.Generic;

namespace Awesomepiece.Model
{
	[Serializable]
	public class ClanRaidBestDeckResponseModel : ResponseModel
	{
		public List<ClanRaidBestDeckModel> bestDecks;
	}
}
