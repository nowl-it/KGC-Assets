using System;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

public class ResourceBase<T>
{
	public int id;

	protected string nameKey;

	public static bool loaded;

	protected static Dictionary<int, object> datas;

	public string name => null;

	public virtual void Init(XmlNode n)
	{
	}

	protected static void Load<T>(string fileName, Action callback = null, bool clear = true) where T : ResourceBase<T>, new()
	{
	}

	protected static void LoadMultiThread<T>(string fileName, Action callback = null, bool clear = true) where T : ResourceBase<T>, new()
	{
	}

	public static TextAsset LoadData(string fileName)
	{
		return null;
	}

	protected static void LoadFromString<T>(string dataText, Action callback, bool clear = true) where T : ResourceBase<T>, new()
	{
	}

	public static T Get(int id)
	{
		return default(T);
	}

	public static List<int> GetAllID(Func<T, bool> checkFunc = null)
	{
		return null;
	}

	public static T Get(Func<T, bool> checkFunc = null)
	{
		return default(T);
	}

	public static List<T> GetAll(Func<T, bool> checkFunc = null)
	{
		return null;
	}

	public static int Count()
	{
		return 0;
	}
}
