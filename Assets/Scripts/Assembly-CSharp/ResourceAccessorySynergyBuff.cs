using System;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

public class ResourceAccessorySynergyBuff : ResourceBase<ResourceAccessorySynergyBuff>
{
	public int root;

	public int count;

	public int synergy;

	public string type;

	public List<(string key, float value)> numericKeyValues;

	public List<BuffOption> buffOptionList;

	public XmlNode xmlNode;

	public List<Func<Buff, string>> paramFuncs;

	public string descKey;

	public bool hideInInventory;

	public string namePreKey;

	public static int lastSynergy;

	public string desc => null;

	public string namePre => null;

	public override void Init(XmlNode n)
	{
	}

	public static List<ResourceAccessorySynergyBuff> Get(int synergy, int count)
	{
		return null;
	}

	public static void Load(Action callback = null)
	{
	}

	public string GetDescWithParam(Buff buff, Color color, bool activated)
	{
		return null;
	}
}
