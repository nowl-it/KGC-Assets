using System;
using System.Collections.Generic;

namespace Awesomepiece.Model
{
	[Serializable]
	public class RogueLikeMissionStatisticsResponseModel : ResponseModel
	{
		public List<MissionStatisticsData> rogueLikeMissionStatistics;

		public int totalRogueLikeUser;
	}
}
