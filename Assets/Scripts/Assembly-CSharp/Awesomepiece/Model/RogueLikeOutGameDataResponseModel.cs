using System;

namespace Awesomepiece.Model
{
	[Serializable]
	public class RogueLikeOutGameDataResponseModel : ResponseModel
	{
		public RogueLikeOutGameStatusSerializable rogueLikeOutGameStatus;

		public int totalClearCount;
	}
}
