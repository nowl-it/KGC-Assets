using System;
using System.Collections.Generic;
using System.Xml;
using Awesomepiece;

public class ResourceTerritoryAlchemyItem : ResourceBase<ResourceTerritoryAlchemyItem>
{
	public class AlchemyRewards
	{
		public int index;

		public List<int> jackpotPer;

		public List<Reward> rewards;

		public int version;

		public static List<AlchemyRewards> ParseList(XmlNode n)
		{
			return null;
		}

		public static AlchemyRewards Parse(XmlNode n)
		{
			return null;
		}
	}

	public int level;

	public int reqPoint;

	public List<AlchemyRewards> rewards;

	public bool enabled;

	private static List<ResourceTerritoryAlchemyItem> _levelSortedData;

	public override void Init(XmlNode n)
	{
	}

	public static void Load(Action callback = null)
	{
	}

	public static int GetMaxLevel()
	{
		return 0;
	}

	public static ResourceTerritoryAlchemyItem GetByLevel(int levelIndex)
	{
		return null;
	}
}
