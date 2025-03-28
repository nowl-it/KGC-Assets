using System;

namespace Awesomepiece.Model
{
	[Serializable]
	public class CustomEventData
	{
		public string eventName;

		public string startAt;

		public string untilAt;

		public int rewardId;

		public DateTime startAt_ => default(DateTime);

		public DateTime untilAt_ => default(DateTime);
	}
}
