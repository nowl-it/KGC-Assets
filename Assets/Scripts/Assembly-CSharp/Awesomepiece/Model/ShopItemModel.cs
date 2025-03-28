using System;

namespace Awesomepiece.Model
{
	[Serializable]
	public class ShopItemModel
	{
		public int itemId;

		public int unitId;

		public int count;

		public int price;

		public bool discount;

		public bool free;

		public bool soldOut;

		public bool doubleChance;

		public string createdAt;

		public string untilAt;

		public int buyCount;

		public int monthlyBuyCount;

		public DateTime createdAt_ => default(DateTime);

		public DateTime untilAt_ => default(DateTime);

		public bool CheckEqual(ShopItemModel old)
		{
			return false;
		}
	}
}
