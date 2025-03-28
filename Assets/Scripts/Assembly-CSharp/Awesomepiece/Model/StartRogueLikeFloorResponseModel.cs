using System;
using System.Collections.Generic;

namespace Awesomepiece.Model
{
	[Serializable]
	public class StartRogueLikeFloorResponseModel : ResponseModel
	{
		public int heart;

		public string lastHeartTime;

		public List<int> bannedHeroes;

		public DateTime lastHeartTime_ => default(DateTime);
	}
}
