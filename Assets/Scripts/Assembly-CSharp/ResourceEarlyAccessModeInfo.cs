using System;
using System.Collections.Generic;
using System.Xml;
using Awesomepiece.Model;

public class ResourceEarlyAccessModeInfo : ResourceBase<ResourceEarlyAccessModeInfo>
{
	public class TestUnit
	{
		public int unitId;

		public int cardLevel;

		public int potentialTier;
	}

	public class TestTreasure
	{
		public int treasureId;

		public int level;

		public int overcome;
	}

	public class TestAccessory
	{
		public int synergy;

		public int type;

		public int rarity;

		public int level;

		public AccessoryModel.AccessoryData data;
	}

	public List<TestUnit> testUnits;

	public List<TestTreasure> testTreasures;

	public List<TestAccessory> testAccessories;

	private DateTime _startAt;

	private DateTime _endAt;

	public XmlNode xmlNode;

	public int inheritFrom;

	public DateTime startAt => default(DateTime);

	public DateTime endAt => default(DateTime);

	public override void Init(XmlNode n)
	{
	}

	public static void Load()
	{
	}
}
