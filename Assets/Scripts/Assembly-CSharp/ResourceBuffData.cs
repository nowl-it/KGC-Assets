using System;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

public class ResourceBuffData : ResourceBase<ResourceBuffData>, IRecursiveInheritable<ResourceBuffData>
{
	public enum BuffType
	{
		StatusBuff = 0,
		TickIntervalBuff = 1,
		DotDamageBuff = 2,
		FromBuffOption = 3
	}

	public enum KeyType
	{
		ID = 0,
		IDWithCaster = 1
	}

	public enum StackType
	{
		Reset = 0,
		Stack = 1,
		ResetAndStack = 2
	}

	public enum ModifyType
	{
		Add = 0,
		Minus = 1,
		Multiply = 2,
		Overwrite = 3
	}

	public class StatusFormula
	{
		public BuffManager.StatType statType;

		public ModifyType modifyType;

		public float value;

		public bool baseTargetStat;
	}

	private XmlNode xmlNode;

	public BuffType buffType;

	public KeyType keyType;

	public StackType stackType;

	public int maxStackCount;

	public float duration;

	public float intervalSecond;

	public StatusFormula statusFormula;

	public Dictionary<string, string> values;

	private OptimizedReadOnlyStringDict<string> _optimizedValueDict;

	public List<BuffOption> buffOptionList;

	public List<Func<Buff, string>> paramFuncs;

	public List<Func<Buff, string>> totalParamFuncs;

	public int inheritFrom;

	public Action<Buff> buffInitializeAction;

	public Action<Buff> buffDisposeAction;

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

	public static string GetDescKey(Buff buff, string format = "BuffDataDesc_{0}")
	{
		return null;
	}

	public static string GetTotalDescWithParam(Buff buff, Color color, bool activated)
	{
		return null;
	}

	public static string GetDescWithParam(Buff buff, Color color, bool activated)
	{
		return null;
	}

	public string GetDescWithParam(string descKey, Color color)
	{
		return null;
	}

	public static List<string> GetDescParamString(Buff buff, Color color, bool totalParam = false, bool activated = true)
	{
		return null;
	}

	public static Func<Buff, string> ParseParamFunc(ResourceBuffData resRoot, XmlNode xmlRoot, XmlNode inherit, XmlNode descParam, List<BuffOption> buffOptionList)
	{
		return null;
	}

	private static float BuffDataOutGameStatFunc(Buff buff, BuffManager.StatType statType)
	{
		return 0f;
	}

	public IRecursiveInheritable<ResourceBuffData> GetParentResource()
	{
		return null;
	}

	public XmlNode GetXmlNode()
	{
		return null;
	}
}
