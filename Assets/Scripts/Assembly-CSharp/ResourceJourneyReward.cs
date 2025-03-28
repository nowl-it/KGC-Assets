using System;
using System.Collections.Generic;
using System.Xml;
using Awesomepiece;

public class ResourceJourneyReward : ResourceBase<ResourceJourneyReward>
{
	public class RewardItem
	{
		public int id;

		public readonly int[] requireTime;

		public Reward reward;

		public TimeSpan requireTimeSpan => default(TimeSpan);
	}

	public List<RewardItem> rewards;

	public override void Init(XmlNode n)
	{
	}

	public static void Load()
	{
	}
}
