using System;
using System.Collections.Generic;

namespace Awesomepiece.Model
{
	[Serializable]
	public class BuyResponseModel : ResponseModel
	{
		public List<GachaResultCollection> gachas;

		public bool soldOut;

		public int unitId;

		public int unitExp;

		public int unitSoul;

		public List<CardExpResult> cardExpResults;

		public List<int> newUnitIds;

		public int playerGold;

		public int playerCash;

		public int playerPaidCash;

		public int playerHeart;

		public int playerRemainAdHeart;

		public int dailyBuyHeartCount;

		public List<GachaKey> gachaKeys;

		public GachaStack gachaStack;

		public int eventFlag;

		public List<int> eventMode;

		public List<int> eventFlags;

		public ShopItemModel[] cashItems;

		public ShopItemModel[] dailyItems;

		public List<ShopItemModel> eventShopItems;

		public List<ShopItemModel> specialEventShopItems;

		public List<ShopItemModel> arenaShopItems;

		public List<ShopItemModel> clanShopItems;

		public List<ShopItemModel> hardModeShopItems;

		public List<TokenInfo> tokens;

		public ArtifactResultResponseModel artifactResult;

		public TreasureResultResponseModel treasureResult;

		public AccessoryResultResponseModel accessoryResult;

		public int skin;

		public int unitExpItem;

		public int unitSoulItem;

		public List<InventoryItem> inventoryItems;

		public FlagResponseModel flag;

		public NameTagResponseModel nameTag;

		public PlayerTerritoryTycoonResponseModel playerTerritoryTycoon;

		public PlayerTerritoryResponseModel.StoredBuilding territoryBuilding;

		public string boughtRogueLikeDLCs;
	}
}
