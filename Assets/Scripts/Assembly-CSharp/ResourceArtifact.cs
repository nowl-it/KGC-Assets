using System;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

public class ResourceArtifact : ResourceBase<ResourceArtifact>, IResourceValue
{
	public enum Type
	{
		Dust = 0,
		Piece = 1,
		Artifact = 2,
		CatalystBox = 3,
		Catalyst = 4,
		PolishItem = 5
	}

	public enum Level
	{
		Normal = 0,
		King = 1,
		God = 2,
		KingGod = 3
	}

	public enum FromType
	{
		ShopCommon = 0,
		ShopRare = 1,
		ShopSpecial = 2,
		HardMode = 3,
		Arena = 4,
		Special = 5,
		RogueLikeBuildingArtifact = 6,
		RogueLike = 7,
		Event = 8,
		Raid = 9
	}

	public class FixOption
	{
		public int count;

		public int minLevel;

		public string type;
	}

	public struct TileBuff
	{
		public int x;

		public int y;

		public int tileBuffItem;
	}

	private DateTime _eventEndAt;

	public int eventDurationDay;

	public FixOption fixOption;

	public int catalystTier;

	public XmlNode xmlNode;

	public Type type;

	public Level level;

	public FromType fromType;

	public int next;

	public int root;

	public int[] rogueLikePossibleFixedBuildings;

	public int rogueLikeBuildingLevel;

	public int reqRogueLikeDlc;

	public bool hideInRogueLike;

	public List<TileBuff> tileBuffList;

	public string spriteName;

	private string _descKey;

	private string _eventOptionDescKey;

	private Sprite _iconSprite;

	public Dictionary<string, string> values;

	public List<int> shortcutInfoList;

	public List<string> checkDuplicateOption;

	public string regionCondition;

	public List<WorldTrigger> worldTriggerList;

	public DateTime eventEndAt => default(DateTime);

	public int dismantleDustCount => 0;

	public new string name => null;

	public string desc => null;

	public string eventOptionDesc => null;

	public Sprite iconSprite => null;

	public bool canDismantle => false;

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

	public string GetMainOptionText()
	{
		return null;
	}

	public static void Load(Action callback = null)
	{
	}

	public static int GetOptionCount(Level level)
	{
		return 0;
	}

	public static string GetColorCode(ResourceArtifact resArtifact)
	{
		return null;
	}

	public static int GetFromTypeRank(FromType fromType)
	{
		return 0;
	}
}
