using System;

namespace Awesomepiece.Model
{
	[Serializable]
	public class EventMissionData
	{
		public int eventType;

		public string startAt;

		public string untilAt;

		public int value;

		public ResourceMission.EventType eventType_ => default(ResourceMission.EventType);

		public DateTime startAt_ => default(DateTime);

		public DateTime untilAt_ => default(DateTime);
	}
}
