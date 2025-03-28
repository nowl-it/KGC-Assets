using System;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

public class ResourceSynergy : ResourceBase<ResourceSynergy>
{
	public string spriteName;

	public string desc;

	public List<int> units;

	public Dictionary<string, string> values;

	private Sprite _sprite;

	public Sprite sprite => null;

	public override void Init(XmlNode n)
	{
	}

	public int GetValueInt(string key, int @default = -1)
	{
		return 0;
	}

	public float GetValueFloat(string key, float @default = -1f)
	{
		return 0f;
	}

	public string GetValueText(string key, string @default = null)
	{
		return null;
	}

	public bool GetValueBool(string key, bool @default = false)
	{
		return false;
	}

	public bool HasValue(string key)
	{
		return false;
	}

	public static void Load(Action callback = null)
	{
	}
}
