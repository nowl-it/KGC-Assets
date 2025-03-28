using System;
using System.Xml;
using UnityEngine;

public class ResourceNameTag : ResourceBase<ResourceNameTag>
{
	public enum Type
	{
		None = 0,
		PvP = 1,
		Tower = 2,
		Colosseum = 3,
		PvPTier = 4,
		TowerTier = 5,
		ColosseumTier = 6,
		PvPReward = 7,
		TowerReward = 8,
		ColosseumReward = 9,
		CurrentSeason = 10,
		Achievement = 11,
		Level = 12,
		Reward = 13
	}

	public string spriteId;

	public string prefab;

	public int tier;

	public static int defaultNameTagId;

	public Type type;

	private Sprite _nameTagSprite;

	private string _frameSpriteKey;

	private Sprite _iconFrameSprite;

	public bool isTierTag => false;

	public bool isSeasonTag => false;

	public Sprite nameTagSprite => null;

	public Sprite iconFrameSprite => null;

	public override void Init(XmlNode n)
	{
	}

	public static void Load(Action callback = null)
	{
	}

	public static ResourceNameTag GetSeasonNameTag(Type type)
	{
		return null;
	}

	public string GetString(string textType)
	{
		return null;
	}
}
