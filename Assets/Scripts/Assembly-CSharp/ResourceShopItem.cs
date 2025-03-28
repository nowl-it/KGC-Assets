using System;
using System.Collections.Generic;
using System.Xml;
using Awesomepiece.Model;
using UnityEngine;

public class ResourceShopItem : ResourceBase<ResourceShopItem>
{
	[Serializable]
	public enum Type
	{
		UnitExp = 0,
		Unit = 1,
		Gacha = 2,
		Gold = 3,
		Cash = 4,
		DailyShop = 5,
		Package = 6,
		SelectUnitExp = 7,
		Heart = 8,
		Status = 9,
		EventPackage = 10,
		EventShop = 11,
		Skin = 12,
		ArtifactGacha = 13,
		ArenaShop = 14,
		SeasonPass = 15,
		DailyPackage = 16,
		ClanShop = 17,
		UnitSoul = 18,
		UnitSoulItem = 19,
		NewUnitGacha = 20,
		NewHeroSkinPackage = 21,
		GoldMine = 22,
		CashMine = 23,
		BabelPass = 24,
		SeasonPassPlus = 25,
		SeasonPassPremium = 26,
		InvasionPass = 27,
		HardModeShop = 28,
		TerritoryPass = 29,
		TerritoryHuntingTicket = 30,
		TerritoryTimeSkip = 31,
		GodSkinPackage = 32,
		GodSkinSalePackage = 33,
		EventMissionPass = 34,
		RogueLikeBuildingPackage = 35,
		RogueLikeBuildingSalePackage = 36,
		TreasureGacha = 37,
		Treasure = 38,
		SpecialSeasonalEventShop = 39,
		InventoryItem = 40,
		EventPass = 41
	}

	public enum SpecialEventType
	{
		None = 0,
		ThirdHalfAnniversary = 1,
		FourthYearEvent = 2
	}

	public enum BuyLimitType
	{
		Daily = 0,
		Weekly = 1,
		Monthly = 2
	}

	public enum SpecialSeasonalTokenType
	{
		None = 0,
		Consumable = 1,
		Gacha = 2,
		Skin = 3
	}

	public class BabelPassInfo
	{
		public int babelId;

		public int minStage;

		public int maxStage;
	}

	public Type type;

	public string spriteName;

	public string packageTagName;

	public int recommendPriority;

	public int recommendDay;

	private Sprite _iconSprite;

	private Sprite _upIconSprite;

	public int price;

	public int cashPrice;

	private float _moneyPrice;

	private float _moneyPriceiOS;

	private float _dolarPrice;

	private float _dolarPriceiOS;

	public int soulItemPrice;

	private DateTime _buyUntilAt;

	public int gold;

	public int cash;

	public int heart;

	public int hardModeToken;

	public int hardModeTokenLevel;

	public int artifactId;

	public int artifactCount;

	public int accessorySynergy;

	public Dictionary<string, string> values;

	public string productId;

	public string eventType;

	public SpecialEventType specialEventType;

	public int tokenPrice;

	public int gachaBoxIndex;

	public int seasonPass;

	public List<int> artifactIds;

	public List<int> artifactCounts;

	public List<int> treasureIds;

	public List<int> treasureCounts;

	public List<InventoryItem> inventoryItems;

	public List<InventoryItem> boxKeys;

	public (int amount, SpecialSeasonalTokenType type) specialSeasonalEventToken;

	public BuyLimitType buyLimitType;

	public int buyLimitMonthly;

	public int minVersion;

	public bool showGachaConfirmPanel;

	public (int theme, int difficulty) invasionDifficultyLimit;

	public (string type, int value) unlockLimit;

	public List<int> missionIds;

	public bool unitBundlePackage;

	public List<int> unitIdList;

	public string unitBundlePackageLevelLimit;

	public bool skinBundlePackage;

	public bool choicePackageUnit;

	public int choicePackageUnitItemCount;

	public SpecialSeasonalTokenType specialSeasonalTokenPriceType;

	public BabelPassInfo babelPassInfo;

	private static int? _stepUpPackageMaxTier;

	public new string name => null;

	public float moneyPrice => 0f;

	public float krMoneyPrice => 0f;

	public DateTime buyUntilAt => default(DateTime);

	public Sprite iconSprite => null;

	public Sprite upIconSprite => null;

	public static int StepUpPackageMaxTier => 0;

	public override void Init(XmlNode n)
	{
	}

	public int GetValueInt(string key, int @default = -1)
	{
		return 0;
	}

	public float GetValueFloat(string key, float @default = -1f)
	{
		return 0f;
	}

	public string GetValueText(string key, string @default = null)
	{
		return null;
	}

	public bool GetValueBool(string key, bool @default = false)
	{
		return false;
	}

	public bool HasValue(string key)
	{
		return false;
	}

	public static void Load(Action callback = null)
	{
	}

	public static List<string> GetProductIds()
	{
		return null;
	}

	public static ResourceShopItem FindByProductId(string productId)
	{
		return null;
	}

	public static Sprite GetCashImage(int value)
	{
		return null;
	}

	public static Sprite GetGoldImage(int value)
	{
		return null;
	}

	public static Sprite GetHeartImage(int value)
	{
		return null;
	}

	public static int GetTypeCount(Type type)
	{
		return 0;
	}

	public List<InventoryItem> GetRewardAsInventoryItems()
	{
		return null;
	}

	public bool CheckIsLocked()
	{
		return false;
	}

	public string GetUnlockDesc()
	{
		return null;
	}

	public (Dictionary<ResourceInventoryItem, int>, Dictionary<ResourceArtifact, int>) GetTotalMissionRewards()
	{
		return default((Dictionary<ResourceInventoryItem, int>, Dictionary<ResourceArtifact, int>));
	}

	public bool IsBanned()
	{
		return false;
	}
}
