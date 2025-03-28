using System;
using System.Xml;
using UnityEngine;

public class ResourceFlag : ResourceBase<ResourceFlag>
{
	public enum Type
	{
		None = 0,
		PvP = 1,
		Tower = 2,
		Colosseum = 3,
		PvPReward = 4,
		TowerReward = 5,
		ColosseumReward = 6,
		PvPTier = 7,
		TowerTier = 8,
		ColosseumTier = 9,
		Achievement = 10,
		Shop = 11,
		Level = 12,
		Reward = 13
	}

	private GameObject _prefab;

	public string prefabName;

	public Type type;

	public int tier;

	public Color color;

	public float previewOffsetY;

	public float spriteOffsetY;

	public float seasonOffsetY;

	private string spriteId;

	private Sprite _flagSprite;

	private Sprite _nameTagSprite;

	public static int minSeason;

	public static int defaultFlagId;

	public GameObject prefab => null;

	public bool isSeasonFlag => false;

	public bool isRewardFlag => false;

	public bool isTierFlag => false;

	public Sprite flagSprite => null;

	public override void Init(XmlNode n)
	{
	}

	public static void Load(Action callback = null)
	{
	}

	public string GetName(int season)
	{
		return null;
	}

	public string GetDesc(Type type, int season, int tier = -1)
	{
		return null;
	}

	public static ResourceFlag GetFlagWithSeason(ResourceFlag flag, int season)
	{
		return null;
	}

	public static ResourceFlag GetSeasonFlag(Type flagType)
	{
		return null;
	}

	public static ResourceFlag GetDefaultFlag()
	{
		return null;
	}
}
