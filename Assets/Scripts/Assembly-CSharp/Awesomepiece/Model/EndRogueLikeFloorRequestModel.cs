using System;

namespace Awesomepiece.Model
{
	[Serializable]
	public class EndRogueLikeFloorRequestModel
	{
		public int challengeLevel;

		public int floor;

		public int totalBattleRoomCount;

		public int clearedBattleRoomCount;

		public bool revived;
	}
}
