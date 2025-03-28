using System;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

public class ResourceBuilding : ResourceBase<ResourceBuilding>
{
	public class Effect
	{
		public string key;

		public string descKey;

		public List<EffectValue> values;

		private static IComparer<EffectValue> _comparer;

		public string desc => null;

		public float GetValue(int level, bool preview = false)
		{
			return 0f;
		}

		public EffectValue GetEffectValue(int level, bool preView = false)
		{
			return null;
		}

		public string GetDesc(int level, bool longVersion = false)
		{
			return null;
		}
	}

	public class EffectValue
	{
		public int level;

		public float value;

		public float maxValue;
	}

	public static int MaxLevel;

	public List<Effect> effects;

	public Color color;

	public Color levelColor;

	public Color levelGlowColor;

	public int index;

	public List<int> hideThemes;

	public List<int> availableThemes;

	public bool needBuy;

	private Dictionary<string, int> _indexCache;

	public override void Init(XmlNode n)
	{
	}

	public bool HasEffect(string key)
	{
		return false;
	}

	public float GetEffectValue(string key, int level)
	{
		return 0f;
	}

	public EffectValue GetEffect(string key, int level)
	{
		return null;
	}

	public static ResourceBuilding GetByIndexAndTheme(int index)
	{
		return null;
	}

	public static ResourceBuilding GetByIndexAndTheme(int index, int theme)
	{
		return null;
	}

	public static int GetBuildingIdOffset(int theme)
	{
		return 0;
	}

	public static void Load(Action callback = null)
	{
	}
}
