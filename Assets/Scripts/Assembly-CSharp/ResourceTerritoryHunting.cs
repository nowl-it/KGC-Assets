using System;
using System.Xml;
using UnityEngine;

public class ResourceTerritoryHunting : ResourceBase<ResourceTerritoryHunting>
{
	public enum TerritoryHuntingRank
	{
		F = 0,
		D = 1,
		C = 2,
		B = 3,
		A = 4,
		S = 5,
		SS = 6,
		Count = 7
	}

	private string _nameKey;

	private string _descKey;

	public int difficulty;

	public int theme;

	public bool isHardMode;

	public int themeSeason;

	public int reqHeroCount;

	public int reqCombatPower;

	public int rewardAmount;

	public int minLevel;

	public int maxLevel;

	public XmlNode xmlNode;

	public int inheritFrom;

	public new string name => null;

	public string desc => null;

	public override void Init(XmlNode n)
	{
	}

	public TimeSpan GetRequiredTime(int foodBoosterLevel, float shortenPer)
	{
		return default(TimeSpan);
	}

	public static void Load(Action callback = null)
	{
	}

	public static Color GetRankColor(TerritoryHuntingRank rank)
	{
		return default(Color);
	}
}
