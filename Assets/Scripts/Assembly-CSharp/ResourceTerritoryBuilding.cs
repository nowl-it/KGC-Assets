using System;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

public class ResourceTerritoryBuilding : ResourceBase<ResourceTerritoryBuilding>, IRecursiveInheritable<ResourceTerritoryBuilding>
{
	public class Spec
	{
		public string name;

		public string format;

		public bool hide;

		public bool showOnlyAtUpgrade;
	}

	public enum Category
	{
		None = 0,
		Building = 1,
		Decoration = 2
	}

	public enum EventBuildingType
	{
		None = 0,
		TerritoryTycoon_Beach_Fishing = 1,
		TerritoryTycoon_Beach_Stall = 2,
		TerritoryTycoon_Beach_Shop = 3
	}

	public XmlNode xmlNode;

	public int rootId;

	public int inheritFrom;

	public Dictionary<string, string> values;

	private string _nameKey;

	private string _descKey;

	private string _shortDescKey;

	private string _iconKey;

	public float iconScale;

	public string prefab;

	public int level;

	public int goldPrice;

	public int laborPrice;

	public int corePrice;

	public int townHallCorePrice;

	public int seasonalTokenPrice;

	private readonly int[] _upgradeEndAt;

	private readonly int[] _jobEndAt;

	public int maxCount;

	public int maxUnitAssignCount;

	public string panelName;

	public int addMaxLabor;

	public bool canStore;

	public int syncLevel;

	public int syncPotentialTier;

	public int maxTickets;

	public int ticket;

	public int recoverCountPerDay;

	public int maxItemLevel;

	public int unlockedTradeShop;

	public int markerYOffset;

	public List<string> menuButtons;

	public List<Spec> specs;

	public ResourceUnit.Role assignmentBonusRole;

	public Category category;

	public EventBuildingType eventBuildingType;

	public List<string> sounds;

	public bool showOnlyIfHas;

	public int minVersion;

	public new string name => null;

	public string desc => null;

	public string shortDesc => null;

	public Sprite icon => null;

	public TimeSpan upgradeEndAt => default(TimeSpan);

	public TimeSpan jobEndAt => default(TimeSpan);

	public ResourceTerritoryTradeShop resUnlockedTradeShop => null;

	public override void Init(XmlNode n)
	{
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

	public bool HasValue(string key)
	{
		return false;
	}

	public bool CheckRequirements(out string requirementsText)
	{
		requirementsText = null;
		return false;
	}

	public bool CheckPrices()
	{
		return false;
	}

	public IRecursiveInheritable<ResourceTerritoryBuilding> GetParentResource()
	{
		return null;
	}

	public XmlNode GetXmlNode()
	{
		return null;
	}

	public int GetMaxTicket(bool passExist)
	{
		return 0;
	}
}
