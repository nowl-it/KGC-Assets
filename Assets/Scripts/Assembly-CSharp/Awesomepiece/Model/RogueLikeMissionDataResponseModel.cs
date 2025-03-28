using System;
using System.Collections.Generic;

namespace Awesomepiece.Model
{
	[Serializable]
	public class RogueLikeMissionDataResponseModel : ResponseModel
	{
		public List<MissionData> missions;
	}
}
