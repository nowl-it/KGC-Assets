using System.Collections.Generic;
using System.Xml;
using Awesomepiece.Model;
using UnityEngine;

public class ResourceAccessoryConstant
{
	public class AccessoryTypeInfo
	{
		public enum AccessoryType
		{
			None = 0,
			Necklace = 1,
			Bracelet = 2,
			Ring = 3,
			Earring = 4
		}

		public AccessoryType accessoryType;

		public string[] mainStats;
	}

	public class MainStatInfo
	{
		public string statTypeStr;

		public float value;

		public float increaseByLevel;

		public string[] subStats;
	}

	public class SubStatInfo
	{
		public string statTypeStr;

		public float[] increaseRandomValues;
	}

	public class LevelCost
	{
		public int level;

		public int needExp;

		public int needGold;
	}

	public class DismantleInfo
	{
		public int level;

		public List<InventoryItem> inventoryItems;
	}

	public class LevelEvent
	{
		public int level;

		public ResourceTreasure.Rarity rarity;

		public string type;

		public int value;
	}

	public class SynergyColor
	{
		public int synergy;

		public Color color;
	}

	public class InventoryCountInformation
	{
		public int baseCount;

		public int max;

		public int add;

		public int cash;
	}

	public static Dictionary<AccessoryTypeInfo.AccessoryType, AccessoryTypeInfo> AccessoryTypeDict;

	public static Dictionary<int, string> AccessoryTypeToStringDict;

	public static Dictionary<string, MainStatInfo> MainStatInfoDict;

	public static Dictionary<string, SubStatInfo> SubStatInfoDict;

	public static LevelCost[] LevelCosts;

	public static DismantleInfo[] DismantleInfos;

	public static Dictionary<ResourceTreasure.Rarity, List<LevelEvent>> LevelEventDict;

	public static int EquipCoolTimeMinute;

	public static int CoolTimeGold;

	public static int CoolTimeGoldByMinute;

	public static int CoolTimeTicketId;

	public static int[] AccessoryRarityProb;

	public static Dictionary<string, float[]> StatColorByValueDict;

	public static Color[] StatColorsByValue;

	public static SynergyColor[] SynergyColors;

	public static List<string> AccessoryStats;

	public static int DismantleAlertLevel;

	public static InventoryCountInformation InventoryCountInfo;

	public static Dictionary<string, Color> StatTypeColorDict;

	public static List<int> ScoreTextRanges;

	public static List<Color> ScoreTextColors;

	private static void Init(XmlNode n)
	{
	}

	public static string GetStatWord(string key)
	{
		return null;
	}

	public static string GetLocalizedSlotName(int slot)
	{
		return null;
	}

	public static void Load()
	{
	}
}
