using System;
using System.Collections.Generic;
using System.Xml;

public class ResourceGachaPool : ResourceBase<ResourceGachaPool>
{
	public List<int> pool;

	public bool incompatibleWithPermanentPool;

	public override void Init(XmlNode n)
	{
	}

	public List<T> GetPoolAsResource<T>() where T : ResourceBase<T>
	{
		return null;
	}

	public static void Load(Action callback = null)
	{
	}
}
