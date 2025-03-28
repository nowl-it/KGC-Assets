using System.Collections.Generic;
using System.Xml;

public class ResourceRogueLikeSetting
{
	public class UnitLevelData
	{
		public float statPer;

		public int needExp;
	}

	private struct Challenge
	{
		public int level;

		public List<(string key, string value, int attribute)> datas;
	}

	public class ChallengeData
	{
		public struct SecondRewardBattleRoomGenPer
		{
			public int roomCount;

			public float[] percentages;
		}

		public int setBattleClearDefaultRewardHealPer;

		public int battleClearDefaultRewardGoldMultiplier;

		public List<SecondRewardBattleRoomGenPer> secondRewardBattleRoomGenPers;

		public int setBattleClearLostHpPerHealPer;

		public float hpAndShieldGainPer;

		public bool spawnAllMerchants;

		public bool useFogOfWar;

		public List<int> addEnemiesExceptBossStatPer;

		public List<int> addBossStatPer;

		public int addJunkItem;

		public List<int> removeEvents;

		public int battleRewardRandomItemTiersIndex;

		public int addJunkArtifact;

		public int merchantMinusOnePer;

		public int addArtifactRandomBuildingLevel;

		public bool reduceBossClearReward;
	}

	public static int maxFloor;

	public static int maxUnitCount;

	public static int unitMaxLevel;

	public static int unitTierTerm;

	public static List<(int level, int potentialReqLevel)> unitGetPotentialLevels;

	public static int unitGetTier1PotentialLevel;

	public static List<UnitLevelData> unitLevelDatas;

	public static float unitAttackSpeedPerIncPerLevel;

	public static float unitSizeIncPerLevel;

	public static float unitMaxShieldPerByHp;

	public static int maxArtifactCount;

	public static List<int> finalBossIdList;

	private static float[][][][] _battleRewardRandomItemTiers;

	private static float[][][][] _eliteRewardRandomItemTiers;

	private static Constants.RogueLikeItemType[] _battleRewardRandomItemTypes;

	private static int[] _battleRewardRandomItemTypePers;

	private static Dictionary<Constants.RogueLikeItemType, int[]> _itemPrices;

	private static List<Challenge> _challenges;

	private static void Init(XmlNode n)
	{
	}

	public static int GetBattleRewardRandomItemTier(int optionCount)
	{
		return 0;
	}

	public static int GetEliteRewardRandomItemTier(int optionCount)
	{
		return 0;
	}

	public static Constants.RogueLikeItemType GetBattleRewardRandomItemType()
	{
		return default(Constants.RogueLikeItemType);
	}

	public static int GetPriceOfItem(Constants.RogueLikeItemType type, int tier)
	{
		return 0;
	}

	public static ChallengeData GetChallengeData(int challengeLevel)
	{
		return null;
	}

	public static int GetLowestChallengeLevel()
	{
		return 0;
	}

	public static void Load()
	{
	}
}
