using System;

namespace Awesomepiece.Model
{
	[Serializable]
	public class GameSkipInfoResponseModel : ResponseModel
	{
		public int invasionSkipCount;

		public int invasionSkipHeartFreeCount;

		public int totalInvasionSkipCount;
	}
}
