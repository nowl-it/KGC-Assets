using System;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

public class ResourceInventoryItem : ResourceBase<ResourceInventoryItem>
{
	public enum Type
	{
		None = 0,
		CardLevelUpItem = 1,
		Voucher = 2,
		HeartVoucher = 3,
		RewardBoxInventory = 4
	}

	public struct Value
	{
		public string key;

		public string value;
	}

	private Dictionary<string, Value> _values;

	private string _desc;

	private string _iconName;

	public Type type;

	public List<int> shortcutInfoList;

	private static readonly Dictionary<string, Color> _tooltipTypeColorsDict;

	private Sprite _iconSprite;

	public string inventoryCategory;

	public int inventorySortingOrder;

	public string desc => null;

	public Color tooltipTypeColor => default(Color);

	public Sprite iconSprite => null;

	public static Color GetTooltipTypeColor(string type)
	{
		return default(Color);
	}

	public override void Init(XmlNode n)
	{
	}

	public static ResourceInventoryItem GetByRewardTypeAndID(string rewardType, int id)
	{
		return null;
	}

	public int GetOwnAmount()
	{
		return 0;
	}

	public static void Load(Action callback = null)
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

	public List<int> GetValueIntList(string key, List<int> @default = null)
	{
		return null;
	}

	public bool HasValue(string key)
	{
		return false;
	}

	public bool IsTreasureItem()
	{
		return false;
	}
}
