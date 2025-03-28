using System;

namespace Awesomepiece.Model
{
	[Serializable]
	public class FourthYearEventResponseModel : ResponseModel
	{
		public bool buyPass;

		public int currentPassDay;

		public int lastHeartRewardDay;

		public int lastPassOnlyRewardDay;

		public int currentAttendanceDay;

		public int lastAttendanceRewardDay;
	}
}
