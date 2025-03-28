using System;

namespace Awesomepiece.Model
{
	[Serializable]
	public class MissionData
	{
		public int missionId;

		public int value;

		public int goalValue;

		public bool clear;

		public string createdAt;

		public string untilAt;

		public DateTime createdAt_ => default(DateTime);

		public DateTime untilAt_ => default(DateTime);
	}
}
