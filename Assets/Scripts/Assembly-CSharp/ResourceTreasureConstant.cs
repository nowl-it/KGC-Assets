using System.Collections.Generic;
using System.Xml;
using Awesomepiece.Model;
using UnityEngine;

public class ResourceTreasureConstant
{
	public class TreasureLevelCost
	{
		public ResourceTreasure.Rarity rarity;

		public int level;

		public int needExp;

		public int needGold;
	}

	public class TreasureOvercomeCost
	{
		public ResourceTreasure.Rarity rarity;

		public int maxOvercome;

		public int needMaterial;

		public float addSlotValueRatio;
	}

	public class TreasureOvercomeUp
	{
		public int overcome;

		public int maxLevel;

		public string eventType;

		public string type;
	}

	public class TreasureDismantleInfo
	{
		public ResourceTreasure.Rarity rarity;

		public int level;

		public List<InventoryItem> inventoryItems;
	}

	public class InventoryCountInformation
	{
		public int baseCount;

		public int max;

		public int add;

		public int cash;
	}

	public static Dictionary<ResourceTreasure.Rarity, List<TreasureLevelCost>> LevelCostDict;

	public static Dictionary<ResourceTreasure.Rarity, TreasureOvercomeCost> OvercomeCostDict;

	public static Dictionary<string, List<TreasureOvercomeUp>> OvercomeUpDict;

	public static TreasureOvercomeUp[] OvercomeUps;

	public static Dictionary<ResourceTreasure.Rarity, List<TreasureDismantleInfo>> DismantleInfoDict;

	public static int EquipCoolTime;

	public static int CoolTimeGold;

	public static int CoolTimeGoldByMinute;

	public static int CoolTimeTicketId;

	public static Dictionary<ResourceTreasure.Rarity, Color> ColorByRarityDict;

	public static InventoryCountInformation InventoryCountInfo;

	public static Dictionary<ResourceTreasure.Rarity, (Color start, Color end)> IconGradationColor;

	public static int TreasureSpecialDismantleItemCountByOvercome;

	private static void Init(XmlNode n)
	{
	}

	public static void Load()
	{
	}
}
