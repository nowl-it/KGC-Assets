using System;
using System.Collections.Generic;

namespace Awesomepiece.Model
{
	[Serializable]
	public class DailyAttendanceEventsResponseModel : ResponseModel
	{
		public List<int> eventIds;

		public List<int> attendances;
	}
}
