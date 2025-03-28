using System;
using System.Xml;

public class ResourceClanTag : ResourceBase<ResourceClanTag>
{
	public enum Type
	{
		None = 0,
		Language = 1,
		Keyword = 2
	}

	public Type type;

	public string value;

	public string locale;

	public static int clanTagKeywordMinIdx;

	public override void Init(XmlNode n)
	{
	}

	public static void Load(Action callback = null)
	{
	}
}
