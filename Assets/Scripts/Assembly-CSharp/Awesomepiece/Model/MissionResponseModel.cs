using System;
using System.Collections.Generic;

namespace Awesomepiece.Model
{
	[Serializable]
	public class MissionResponseModel : ResponseModel
	{
		public List<MissionData> missions;

		public int missionGoal;

		public int missionKeyStack;
	}
}
