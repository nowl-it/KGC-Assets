using System;
using System.Collections.Generic;
using System.Xml;
using Awesomepiece;

public static class ResourceColosseumSetting
{
	public static int ApplyTarotSetting;

	public static DateTime ApplyTarotStartDate;

	public static DateTime ApplyTarotEndDate;

	public static int MaxAbilityLevel;

	public static int[] AbilityLevelNeedExp;

	public static int[][] InvadeItemProbability;

	public static int AbilityRerollCount;

	public static int MaxInvadePoint;

	public static int IncreaseInvadePointAmount;

	public static int InvadeShopRerollCost;

	public static int[][] PhaseTimeLengths;

	public static int[] EnemyBerserkValue;

	public static Dictionary<BuffManager.StatType, float> StatPerByBerserkValueWithType;

	public static int BerserkBaseValueAddAmount;

	public static int BerserkBaseValueStreakAmount;

	public static int[] DecreaseEnemyBerserkBaseValue;

	public static int[] RewardRequireRounds;

	public static int[] RewardHeartCosts;

	public static int[] AbilityExpsWhenOpponentTargetLose;

	public static (int point, Reward reward)[] OpenMissionRewards;

	public static int PoolClearStage;

	public static float BonusRewardProb;

	public static float BonusRewardPer;

	private static void Init(XmlNode n)
	{
	}

	public static float GetPhaseTimeLength(Scene_Game.ColosseumGamePhase phase, int stage)
	{
		return 0f;
	}

	public static void Load()
	{
	}

	public static float GetStatPerFromEnemyBerserkValue(int berserkValue, BuffManager.StatType type, bool perValue = true)
	{
		return 0f;
	}
}
