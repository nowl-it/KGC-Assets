using System;

namespace Awesomepiece.Model
{
	[Serializable]
	public class DevAddPassMissionResponseModel : ResponseModel
	{
		public MissionData newMissionData;

		public int prevMissionId;
	}
}
