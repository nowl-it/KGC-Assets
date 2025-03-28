using System;
using System.Xml;

public class ResourceClanMark : ResourceBase<ResourceClanMark>
{
	public string image;

	public bool visible;

	public int sortIndex;

	public int minVersion;

	public override void Init(XmlNode n)
	{
	}

	public static void Load(Action callback = null)
	{
	}
}
