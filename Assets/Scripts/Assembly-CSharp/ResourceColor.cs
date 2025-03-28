using System;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

public class ResourceColor : ResourceBase<ResourceColor>
{
	public enum Type
	{
		None = 0,
		SeasonPass = 1,
		Skin_Limited = 2,
		Skin_FirstTimeOnly = 3,
		Event = 4,
		HardMode = 5,
		Skin_Season = 6,
		ThemeColor = 7,
		GodSkin = 8,
		SkinGrade = 9,
		ArtifactOption_AtkPer = 10,
		ArtifactOption_MAtkPer = 11,
		ArtifactOption_AtkSpeedPer = 12,
		ArtifactOption_HpPer = 13
	}

	public Type type;

	public int index;

	public Color value;

	private static readonly Dictionary<Type, Dictionary<int, Color>> values;

	public override void Init(XmlNode n)
	{
	}

	public static void Load(Action callback = null)
	{
	}

	public static Color Get(Type type, int index = -1)
	{
		return default(Color);
	}
}
