using System;
using System.Xml;
using UnityEngine;

public class ResourceColosseumRankTier : ResourceBase<ResourceColosseumRankTier>, IResourceRankTier
{
	public class GameEndReward
	{
		public int[] goldRewards;

		public int[] hardModeTokenRewards;

		public int hardModeTokenLevel;

		public (string, int) conditionPair;
	}

	private string _tierIconName;

	private Sprite _tierIcon;

	private string _starIconName;

	private Sprite _starIcon;

	public string rewardType;

	public int rewardId;

	public int rewardCount;

	public GameEndReward[] gameEndRewards;

	public bool hideInRewardUI;

	public new string name => null;

	public Sprite tierIcon => null;

	public Sprite starIcon => null;

	public bool isChallenger => false;

	public int reqRank { get; set; }

	public new int id
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int reqScore { get; set; }

	public static IResourceRankTier FirstTier => null;

	public static IResourceRankTier LastTier => null;

	public override void Init(XmlNode n)
	{
	}

	public static void Load(Action callback = null)
	{
	}

	public int GetTier()
	{
		return 0;
	}

	public string GetName()
	{
		return null;
	}

	public Sprite GetTierIcon()
	{
		return null;
	}

	public Sprite GetTierStar()
	{
		return null;
	}

	public (string, int, int) GetReward()
	{
		return default((string, int, int));
	}

	public static ResourceColosseumRankTier GetByScore(int score)
	{
		return null;
	}

	public static ResourceColosseumRankTier GetByScoreAndRank(int score, int rank)
	{
		return null;
	}

	public static bool CheckCondition((string type, int value) conditionPair)
	{
		return false;
	}
}
