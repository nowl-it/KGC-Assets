using System;
using System.Collections.Generic;
using System.Xml;

public class ResourceEliteLevel : ResourceBase<ResourceEliteLevel>
{
	public class LevelData
	{
		public int valueRatio;

		public int rewardRatio;

		public float buffDuration;
	}

	public enum Type
	{
		EventTrigger = 0,
		AddStartLife = 1,
		AddEnemyUnitTier = 2,
		AddEnemyTroopSize = 3,
		UpgradeEliteEnemy = 4
	}

	private string _desc;

	public Type type;

	public int maxLevel;

	public int levelRatio;

	public ResourceEventTrigger eventTrigger;

	private List<LevelData> levelDatas;

	public override void Init(XmlNode n)
	{
	}

	public static void Load(Action callback = null)
	{
	}

	public LevelData GetLevelData(int level)
	{
		return null;
	}

	public string GetDesc(int level)
	{
		return null;
	}
}
