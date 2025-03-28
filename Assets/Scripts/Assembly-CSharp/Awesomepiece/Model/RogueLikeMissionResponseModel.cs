using System;
using System.Collections.Generic;

namespace Awesomepiece.Model
{
	[Serializable]
	public class RogueLikeMissionResponseModel : ResponseModel
	{
		public List<int> clearedMissions;
	}
}
