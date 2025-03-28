using System;
using System.Collections.Generic;

namespace Awesomepiece.Model
{
	[Serializable]
	public class EventModeResponseModel : ResponseModel
	{
		public List<int> eventModes;

		public List<int> eventModeFlags;

		public List<int> eventModeHeartCost;

		public List<int> eventModeMaxPlayCount;

		public List<int> allEventModes;

		public List<int> eventModeFlagCost;
	}
}
