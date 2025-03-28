using System;

namespace Awesomepiece.Model
{
	[Serializable]
	public class TerritoryStartHuntingResponseModel : ResponseModel
	{
		public int heart;

		public string lastHeartTime;

		public int ticketCount;

		public string endAt;

		public DateTime lastHeartTime_ => default(DateTime);

		public DateTime endAt_ => default(DateTime);
	}
}
