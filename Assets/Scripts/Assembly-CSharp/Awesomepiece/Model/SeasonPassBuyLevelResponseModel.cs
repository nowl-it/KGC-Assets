using System;

namespace Awesomepiece.Model
{
	[Serializable]
	public class SeasonPassBuyLevelResponseModel : ResponseModel
	{
		public SeasonPassResponseModel pass;

		public int playerCash;
	}
}
