using System;
using System.Collections.Generic;
using System.Xml;

public class ResourceUnitPanelData : ResourceBase<ResourceUnitPanelData>
{
	public enum Type
	{
		None = 0,
		Profile = 1
	}

	public Type type;

	public List<(string title, string data)> profileData;

	public override void Init(XmlNode n)
	{
	}

	public static void Load(Action callback = null)
	{
	}
}
