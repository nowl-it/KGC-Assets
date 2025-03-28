using System;
using System.Collections.Generic;
using System.Xml;
using Awesomepiece;
using UnityEngine;

public class ResourceTheme : ResourceBase<ResourceTheme>
{
	public class StageInfo
	{
		public enum Type
		{
			Normal = 0,
			Pick = 1
		}

		public Type type;

		public readonly List<int> targets;

		public int GetStage()
		{
			return 0;
		}
	}

	public class SpawnSet
	{
		public List<int> stages;

		public List<int> levels;
	}

	public struct Value
	{
		public string key;

		public string value;
	}

	public int timeBonus;

	public string mapPrefab;

	public string castlePrefab;

	public List<string> barricadePrefabs;

	public string fogPrefab;

	public List<(string name, float delay)> effectPrefabs;

	public bool isEventMode;

	public bool isSeasonalMode;

	public bool isQuizMode;

	public bool isPvPMode;

	public bool isRankedPvP;

	public int startGold;

	public int startLife;

	public bool isHardMode;

	public bool isClanRaid;

	public bool isRogueLike;

	public bool isColosseum;

	public bool isBabel;

	public List<StageInfo> stageInfos;

	public int maxStage;

	public int enemyPoolTheme;

	public string normalMusic;

	public string battleMusic;

	public string bossWaitMusic;

	public string bossMusic;

	public string finalBossMusic;

	public List<int> startItems;

	public List<int> startUnitLevels;

	public int startSpawnLevelUp;

	public int spawnLevelUpLevel;

	public int minVersion;

	public Dictionary<string, Value> values;

	public List<int> artifactRewards;

	public List<int> accessoryRewardSynergies;

	public string lobbyRewardIconName;

	private Sprite _lobbyRewardIcon;

	public bool enabled;

	public bool artifactEnabled;

	public bool buildingEnabled;

	public bool territoryBuffEnabled;

	public Dictionary<int, SpawnSet> spawnSets;

	public List<int> randomItems;

	public List<int> merchants;

	public bool preserveEnemyItemsOnReBatch;

	public int hardModeTokenLevel;

	public float hardModeTokenCount;

	public bool useFixedUpdate;

	public int themeSeason;

	public List<int> rewardGaugeIcons;

	public static Dictionary<int, int> RewardGaugeIconToInventoryItemMap;

	public static int MaxTheme { get; private set; }

	public static int HardMaxTheme { get; private set; }

	public Sprite lobbyRewardIcon => null;

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

	public bool IsSeasonalQuizMode()
	{
		return false;
	}

	public int GetReqPrevThemeDifficulty()
	{
		return 0;
	}

	public static List<ResourceTheme> GetByThemeSeason(int season, bool hardMode)
	{
		return null;
	}

	public static string BuildThemeString(string format, int theme)
	{
		return null;
	}

	public static string BuildThemeDifficultyString(string format, int theme, int difficulty)
	{
		return null;
	}

	public string GetInvasionChapterText()
	{
		return null;
	}

	public List<Reward> GetAllPossibleInvasionRewards(int difficulty, int foodBoosterLevel)
	{
		return null;
	}

	public string GetHardModeTokenString()
	{
		return null;
	}

	public int GetInvasionGold(int clearedStage, int difficulty, bool win)
	{
		return 0;
	}

	public int GetInvasionExp(int clearedStage, int difficulty, bool win)
	{
		return 0;
	}

	public float GetHardModeTokenCount(int clearedStage, int difficulty)
	{
		return 0f;
	}

	public static void Load(Action callback = null)
	{
	}
}
