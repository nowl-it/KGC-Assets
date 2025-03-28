using System;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

public class ResourceSkillTagParseRule : ResourceBase<ResourceSkillTagParseRule>
{
	public enum RoundingRule
	{
		Round = 0,
		Ceil = 1,
		Floor = 2
	}

	public string tag;

	public RoundingRule roundingRule;

	public int digit;

	public string postfix;

	public string prefix;

	public string colorStr;

	private static List<ResourceSkillTagParseRule> _list;

	public Color color => default(Color);

	public override void Init(XmlNode n)
	{
	}

	public static void Load(Action callback = null)
	{
	}

	private static ResourceSkillTagParseRule FindRule(string tag)
	{
		return null;
	}

	public static float GetValue(string tag, float value)
	{
		return 0f;
	}

	public static string GetText(ResourceSkill resSkill, bool isBaseValue, string tag, float value)
	{
		return null;
	}
}
