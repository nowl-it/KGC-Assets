using System;

namespace Awesomepiece.Model
{
	[Serializable]
	public class BuyRequestModel
	{
		public int itemId;

		public bool daily;

		public int idx;

		public int targetUnit;

		public int buyAmount;

		public int gachaId;

		public bool isFromTutorial;
	}
}
