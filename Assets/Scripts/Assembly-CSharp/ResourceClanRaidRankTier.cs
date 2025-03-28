using System;
using System.Xml;
using UnityEngine;

public class ResourceClanRaidRankTier : ResourceBase<ResourceClanRaidRankTier>
{
	public int reqBosskill;

	public int reqRank;

	public int clanTokenReward;

	public int clanGoldReward;

	private string _tierIconName;

	private Sprite _tierIcon;

	private string _starIconName;

	private Sprite _starIcon;

	public bool isChallenger => false;

	public new string name => null;

	public Sprite tierIcon => null;

	public Sprite starIcon => null;

	public static ResourceClanRaidRankTier firstTier { get; private set; }

	public static ResourceClanRaidRankTier lastTier { get; private set; }

	public override void Init(XmlNode n)
	{
	}

	public static void Load(Action callback = null)
	{
	}

	public static ResourceClanRaidRankTier GetClanRankTier(int score, int rank)
	{
		return null;
	}
}
