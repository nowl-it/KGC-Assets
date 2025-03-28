using System;
using System.Xml;
using UnityEngine;

public class ResourceRankTier : ResourceBase<ResourceRankTier>, IResourceRankTier
{
	public int winScore;

	public int loseScore;

	public string rewardType;

	public int rewardId;

	public int rewardCount;

	private string _tierIconName;

	private Sprite _tierIcon;

	private string _starIconName;

	private Sprite _starIcon;

	public int reqScore { get; set; }

	public int reqRank { get; set; }

	public bool isChallenger => false;

	public new string name => null;

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

	public Sprite tierIcon => null;

	public Sprite starIcon => null;

	public static IResourceRankTier FirstTier => null;

	public static IResourceRankTier LastTier => null;

	public override void Init(XmlNode n)
	{
	}

	public static void Load(Action callback = null)
	{
	}

	public static Font GetRankingFont(int tier)
	{
		return null;
	}

	public static ResourceRankTier GetByScore(int score)
	{
		return null;
	}

	public static ResourceRankTier GetByScoreAndRank(int score, int rank)
	{
		return null;
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
}
