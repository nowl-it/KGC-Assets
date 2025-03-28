using System;

namespace Awesomepiece.Model
{
	[Serializable]
	public class RerollPassMissionResponseModel : ResponseModel
	{
		public MissionData newMissionData;

		public int rerollCount;

		public int playerGold;
	}
}
