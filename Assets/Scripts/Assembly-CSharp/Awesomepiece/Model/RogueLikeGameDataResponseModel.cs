using System;

namespace Awesomepiece.Model
{
	[Serializable]
	public class RogueLikeGameDataResponseModel : ResponseModel
	{
		public string rogueLikeSaveData;

		public string state;

		public int saveVersion;

		public int lastHeartPaidFloor;
	}
}
