using System;
using System.Collections.Generic;
using System.Xml;
using Awesomepiece;

public class ResourceCustomEventReward : ResourceBase<ResourceCustomEventReward>
{
	public List<Reward> rewards;

	public override void Init(XmlNode n)
	{
	}

	public static void Load(Action callback = null)
	{
	}
}
