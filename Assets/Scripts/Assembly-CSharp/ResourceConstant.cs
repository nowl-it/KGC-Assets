using System;
using System.Collections.Generic;
using System.Xml;

public class ResourceConstant : ResourceBase<ResourceConstant>
{
	[Serializable]
	public enum Type
	{
		UnitNeedExp = 0,
		UnitLvUpCost = 1,
		BuildingPointCost = 2,
		UnitPotentialUpgradeExp = 3,
		UnitPotentialUpgradeGold = 4,
		UnitPotentialUpgradeSoul = 5,
		PlayerNeedExp = 6,
		FoodBoosterMaxLevel = 7,
		FoodBoosterCost = 8,
		FoodBoosterReward = 9,
		InvasionDifficultyReward = 10,
		FlagBoosterMaxLevel = 11,
		FlagBoosterCost = 12,
		FlagBoosterReward = 13,
		ArenaTokenReward = 14,
		DeckSlot = 15,
		UnitNeedSoul = 16,
		FoodMax = 17,
		RerollPassMission = 18,
		CombatPower = 19,
		AccessoryCombatPower = 20,
		AccessorySynergyCombatPower = 21,
		TreasureCombatPower = 22,
		HuntingRankReward = 23,
		HuntingRefreshCost = 24,
		HuntingFoodBoosterCost = 25,
		HuntingFoodBoosterReward = 26,
		UnitAssignmentBenefitPer = 27,
		UnitAssignmentRoleBonusPer = 28,
		InventoryETCSortPriority = 29,
		InventoryAccessoryTypeSortPriority = 30,
		InventoryArtifactFromTypeSortPriority = 31,
		DeckSlotNameMaxLength = 32,
		LevelLimit_DeleteDataWhenLeft = 33,
		LevelLimit_IngameMissionIndicator = 34,
		LevelLimit_ShopDailyDelivery = 35,
		LevelLimit_NewHeroPackage = 36,
		LevelLimit_OfferWall = 37,
		LevelLimit_GodSkinPackage = 38,
		LevelLimit_CustomGrowthPackage = 39,
		LevelLimit_CartPackage = 40,
		LevelLimit_AlertUnit = 41,
		LevelLimit_FirstPackage = 42,
		LevelLimit_EventMode = 43,
		LevelLimit_Clan = 44,
		LevelLimit_SeasonalEventMode = 45,
		LevelLimit_HardMode = 46,
		LevelLimit_Territory = 47,
		LevelLimit_RogueLike = 48,
		LevelLimit_Colosseum = 49,
		LevelLimit_Arena = 50,
		LevelLimit_ArtifactSlot = 51,
		LevelLimit_ArtifactFirstSupport = 52,
		LevelLimit_TerritoryFirstSupport = 53,
		LevelLimit_Missions = 54,
		LevelLimit_SeasonPass = 55,
		LevelLimit_IngameAutoMerge = 56,
		LevelLimit_IngameDevilTierUp = 57,
		LevelLimit_GameListBoxSeason = 58,
		LevelLimit_Treasure = 59,
		LevelLimit_Hero_PickUp = 60,
		LevelLimit_Babel = 61,
		LevelLimit_EventPackage = 62,
		LevelLimit_EarlyAccess = 63,
		LevelLimit_PackageShop = 64,
		LevelLimit_StarterMission = 65,
		LevelLimit_FirstStepPackage = 66,
		None = 67,
		PlayerNeedExp_Old = 68,
		FlagBoosterRewardOld = 69
	}

	public Type type;

	public bool isList;

	public bool isText;

	public int index;

	public int value;

	public string valueText;

	public List<int> listValue;

	public List<string> listValueText;

	private static Dictionary<Type, Dictionary<int, int>> _singleData;

	private static Dictionary<Type, Dictionary<int, List<int>>> _listData;

	private static Dictionary<Type, Dictionary<int, string>> _textSingleData;

	private static Dictionary<Type, Dictionary<int, List<string>>> _textListData;

	public override void Init(XmlNode n)
	{
	}

	public static void Load(Action callback = null)
	{
	}

	public static int Get(Type type, int index = -1)
	{
		return 0;
	}

	public static List<int> GetList(Type type, int index = -1)
	{
		return null;
	}

	public static string GetText(Type type, int index = -1)
	{
		return null;
	}

	public static List<string> GetTextList(Type type, int index = -1)
	{
		return null;
	}

	public static int Length(Type type)
	{
		return 0;
	}

	public static int ListLength(Type type)
	{
		return 0;
	}

	public static int GetMaxHeart(int level)
	{
		return 0;
	}
}
