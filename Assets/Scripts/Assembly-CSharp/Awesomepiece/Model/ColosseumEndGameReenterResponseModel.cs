using System;

namespace Awesomepiece.Model
{
	[Serializable]
	public class ColosseumEndGameReenterResponseModel : ResponseModel
	{
		public int scoreDelta;

		public int rank;

		public int round;

		public string gameId;

		public int tier;

		public int score;

		public int addedToken;
	}
}
