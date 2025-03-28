using System;
using System.Collections.Generic;
using System.Xml;
using Awesomepiece;

public class ResourceRewardBoxInventoryData : ResourceBase<ResourceRewardBoxInventoryData>
{
	public enum Type
	{
		None = 0,
		Probable = 1,
		Fixable = 2,
		Selectable = 3
	}

	public Type type;

	public int rewardCount;

	public string rewardBoxDescKey;

	public string rewardCategoryKey;

	public List<(Reward reward, float probability)> rewards;

	public string rewardBoxDesc => null;

	public string rewardCategory => null;

	public override void Init(XmlNode n)
	{
	}

	public static void Load(Action callback = null)
	{
	}
}
