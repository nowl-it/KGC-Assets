using System;
using System.Collections.Generic;
using System.Xml;
using Awesomepiece;
using UnityEngine;

public class ResourceBabelFloor : ResourceBase<ResourceBabelFloor>
{
	public int babelId;

	public int stage;

	public Reward reward;

	public Reward passReward;

	public int recommendedCombatPower;

	private int _enemyUnitId;

	private string _floorBGSpriteName;

	private Sprite _floorBGSprite;

	private static Dictionary<int, List<ResourceBabelFloor>> _babelFloorDict;

	public int enemyUnitId => 0;

	public Sprite floorBGSprite => null;

	public override void Init(XmlNode n)
	{
	}

	public new static List<ResourceBabelFloor> Get(int theme)
	{
		return null;
	}

	public static ResourceBabelFloor Get(int theme, int stage)
	{
		return null;
	}

	public ResourceStage GetStage()
	{
		return null;
	}

	public static void Load(Action callback = null)
	{
	}
}
