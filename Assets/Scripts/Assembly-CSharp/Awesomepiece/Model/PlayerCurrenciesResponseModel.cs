using System;

namespace Awesomepiece.Model
{
	[Serializable]
	public class PlayerCurrenciesResponseModel : ResponseModel
	{
		public int gold;

		public int cash;

		public int heart;
	}
}
