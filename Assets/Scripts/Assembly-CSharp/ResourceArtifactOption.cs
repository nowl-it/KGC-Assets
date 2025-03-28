using System;
using System.Collections.Generic;
using System.Xml;

public class ResourceArtifactOption : ResourceBase<ResourceArtifactOption>
{
	private static Dictionary<string, List<ResourceArtifactOption>> _optionsByTypeDict;

	public int level;

	public string type;

	public List<int> values;

	public override void Init(XmlNode n)
	{
	}

	public static void Load(Action callback = null)
	{
	}

	public static int GetValue(string type, int level, int targetCount)
	{
		return 0;
	}
}
