using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;
using Awesomepiece.Model;

public class ResourceStage : ResourceBase<ResourceStage>
{
	public class Item
	{
		[XmlAttribute(AttributeName = "ID")]
		public int id;

		[XmlElement(ElementName = "Option")]
		public global::Item.OptionForServer[] options;
	}

	public class SpawnData
	{
		public struct SimpleSpawn
		{
			[XmlAttribute(AttributeName = "Pos")]
			public int pos;

			[XmlAttribute(AttributeName = "Boss")]
			public int boss;

			[XmlAttribute(AttributeName = "Level")]
			public int level;

			[XmlAttribute(AttributeName = "ID")]
			public int id;
		}

		[XmlAttribute(AttributeName = "Y")]
		public int y;

		[XmlElement(ElementName = "Spawn")]
		public SimpleSpawn[] spawn;
	}

	[Serializable]
	public struct Spawn
	{
		public List<int> idList;

		public int pos;

		public int level;

		public int boss;

		public int skin;

		public int cardLevel;

		public int statPer;

		public int equip;

		public int equipTier;

		public int equipCount;

		public bool equipExcept4TierOption;

		public string conditionKey;

		public string conditionValue;

		public float spawnPeriod;

		public string positionType;

		public Spawn(XmlNode spawnNode)
		{
			idList = null;
			pos = 0;
			level = 0;
			boss = 0;
			skin = 0;
			cardLevel = 0;
			statPer = 0;
			equip = 0;
			equipTier = 0;
			equipCount = 0;
			equipExcept4TierOption = false;
			conditionKey = null;
			conditionValue = null;
			spawnPeriod = 0f;
			positionType = null;
		}
	}

	public int theme;

	public int stage;

	public int difficulty;

	public string stageMusic;

	public Dictionary<int, List<Spawn>> mySpawnDatas;

	public Dictionary<int, List<Spawn>> spawnDatas;

	public List<GameCompleteRequestModel.EndItemUnit> spawnItems;

	public List<(int, int)> defaultGen;

	public int addElitePosOffsetY;

	public int valueSum;

	public int monsterLevel;

	public string map;

	public List<string> barricadePrefabs;

	public Dictionary<string, string> values;

	public List<int> eventTriggers;

	public int statPer;

	public XmlNode xmlNode;

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

	public bool IsBoss1Stage()
	{
		return false;
	}

	public bool IsFinalBossStage()
	{
		return false;
	}

	public static ResourceStage GetByThemeAndStage(int themeId, int stage)
	{
		return null;
	}

	public static void Load(Action callback = null)
	{
	}
}
