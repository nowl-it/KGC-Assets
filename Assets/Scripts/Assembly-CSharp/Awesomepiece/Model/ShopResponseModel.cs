using System;
using System.Collections.Generic;

namespace Awesomepiece.Model
{
	[Serializable]
	public class ShopResponseModel : ResponseModel
	{
		public ShopItemModel[] dailyItems;

		public ShopItemModel[] gachaItems;

		public ShopItemModel[] artifactGachaItems;

		public ShopItemModel[] goldItems;

		public ShopItemModel[] cashItems;

		public List<ShopItemModel> packageItems;

		public List<ShopItemModel> playerPackageItems;

		public List<ShopItemModel> eventPackageItems;

		public List<ShopItemModel> eventShopItems;

		public List<ShopItemModel> specialEventShopItems;

		public List<ShopItemModel> arenaShopItems;

		public List<ShopItemModel> clanShopItems;

		public List<ShopItemModel> hardModeShopItems;

		public List<ShopItemModel> newGachaItems;

		public List<ShopItemModel> newHeroSkinPackageItems;

		public string eventPackageItemsUntilAt;

		public List<GachaKey> gachaKeys;

		public List<GachaStack> gachaStacks;

		public List<int> availableTimeLimitGachas;

		public int[] artifactBoxStack;

		public int[] artifactBoxKey;

		public int remainAdHeart;

		public int dailyBuyHeartCount;

		public string nextRefreshTime;

		public string nextBox2FreeTime;

		public List<Triplet<int, string, bool>> godSkinPackageInformation;

		public List<Triplet<int, string, bool>> godSkinSalePackageInformation;

		public DateTime eventPackageItemsUntilAt_ => default(DateTime);

		public DateTime nextRefreshTime_ => default(DateTime);

		public DateTime nextBox2FreeTime_ => default(DateTime);

		public List<ShopItemModel> EventPackagesForShop()
		{
			return null;
		}
	}
}
