using System;
using System.Collections.Generic;

namespace Awesomepiece.Model
{
	[Serializable]
	public class EndRogueLikeFloorResponseModel : ResponseModel
	{
		public int rewardAmount;

		public int level;

		public int exp;

		public int gold;

		public int currentHeart;

		public int addSeasonalEventToken;

		public int addPassPoint;

		public int addClanPoint;

		public int hotTimeBonusValue;

		public List<int> rogueLikeClearedMission;
	}
}
