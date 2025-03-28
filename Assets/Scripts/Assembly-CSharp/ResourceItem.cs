using System;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

public class ResourceItem : ResourceBase<ResourceItem>, IResourceValue
{
	public enum Type
	{
		Equip = 0,
		Instant = 1,
		TileBuff = 2,
		Resumable = 3
	}

	public enum EquipType
	{
		None = 0,
		Sword = 1,
		Armor = 2,
		Bow = 3,
		Staff = 4,
		FromArtifact = 5,
		Rune = 6,
		GodItem = 7
	}

	public XmlNode xmlNode;

	public int inheritFrom;

	public Type type;

	public EquipType equipType;

	public int tier;

	public string spriteName;

	private string _descKey;

	private string _fullDescKey;

	private Sprite _iconSprite;

	public Dictionary<string, string> values;

	public RangeInfo range;

	public int requiredBuilding;

	public int reqRogueLikeDlc;

	private List<string> _subDescKeys;

	public int randomOptionCount;

	public List<(string key, string value)> randomOptions;

	public List<(string key, string value)> fixedOptions;

	public List<(string key, string value)> descOptions;

	public List<string> uniqueOptions;

	public List<Func<Item, string>> paramFuncs;

	public Func<Item, string> representativeValueFunc;

	public List<int> hideThemes;

	public int availableTheme;

	public List<BuffOption> buffOptionList;

	private static readonly Dictionary<string, Func<string, Color, string>> _descKeyValueMap;

	public new string name => null;

	public string desc => null;

	public string fullDesc => null;

	public bool rotateIcon => false;

	public bool isNormalEquipItem => false;

	public bool isUnitEquipItem => false;

	public Sprite iconSprite => null;

	public bool IsUniqueOption(string option)
	{
		return false;
	}

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

	public List<(string, string)> GetAllValues()
	{
		return null;
	}

	public string GetDesc()
	{
		return null;
	}

	public static string GetDesc(string desc, IResourceValue target, Color color = default(Color), Func<float, float> advanceItemAdaptabilityFunc = null)
	{
		return null;
	}

	public static string GetDescOfSingleOption(Item.Option option, Color color = default(Color), float advanceItemAdaptability = 1f)
	{
		return null;
	}

	public static string GetDescWithParam(string desc, Item item, Color color = default(Color))
	{
		return null;
	}

	public static string GetSubDesc(int index, Item item, List<string> paramList = null, Color color = default(Color))
	{
		return null;
	}

	public static void Load(Action callback = null)
	{
	}

	public static ResourceItem PickRandomEquip(int tier, List<int> excepts = null, int? seed = null)
	{
		return null;
	}

	public static ResourceItem PickRandomInstant(int tier, int? seed = null)
	{
		return null;
	}

	public static ResourceItem PickRandomTileBuff(int tier, int? seed = null)
	{
		return null;
	}

	public static ResourceItem PickRandomConsumable(int tier, int? seed = null)
	{
		return null;
	}

	public static ResourceItem PickRandomRune(int tier, int? seed = null)
	{
		return null;
	}

	public static ResourceItem PickRandomGodItem(int? seed = null)
	{
		return null;
	}

	public static Item GetItem(BattleManager battle, int id, bool alreadyEffected = false, bool except4TierOption = false, bool isTemporal = false, int? seed = null)
	{
		return null;
	}

	public static ResourceItem PickRandomItem(int tier, int[] equipInstantRatio = null, bool only1TierEquip = false, List<int> excepts = null, int? seed = null)
	{
		return null;
	}

	public Vector2Int GetTeleportTo(Vector2Int pos)
	{
		return default(Vector2Int);
	}

	private Func<Item, string> ParseParamFunc(XmlNode root, XmlNode descParam, XmlNode inherit, string representType = "None")
	{
		return null;
	}
}
