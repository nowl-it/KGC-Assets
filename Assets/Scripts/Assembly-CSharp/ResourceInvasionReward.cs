using System;
using System.Collections.Generic;
using System.Xml;
using Awesomepiece;

public class ResourceInvasionReward : ResourceBase<ResourceInvasionReward>
{
	public Reward[] rewards;

	public Reward passReward;

	public override void Init(XmlNode n)
	{
	}

	public static void Load(Action callback = null)
	{
	}

	public static ResourceInvasionReward Get(int theme, int difficulty)
	{
		return null;
	}

	public static List<ResourceInvasionReward> GetAllByPassIndex(int passIndex)
	{
		return null;
	}
}
