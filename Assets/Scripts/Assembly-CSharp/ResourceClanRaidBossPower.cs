using System;
using System.Collections.Generic;
using System.Xml;

public class ResourceClanRaidBossPower : ResourceBase<ResourceClanRaidBossPower>
{
	public List<float> bossPowerList;

	public float addChangeMaxAmount;

	public float removeChangeMaxAmount;

	private Dictionary<int, List<(float start, float end)>> _values;

	public override void Init(XmlNode n)
	{
	}

	public static float GetValue(int id, float bossPower, int idx)
	{
		return 0f;
	}

	public float GetValue(float bossPower, int idx)
	{
		return 0f;
	}

	public static void Load(Action callback = null)
	{
	}
}
