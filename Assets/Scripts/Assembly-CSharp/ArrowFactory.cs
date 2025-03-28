using System.Collections.Generic;
using UnityEngine;

public class ArrowFactory : MonoBehaviour
{
	private static ArrowFactory _instance;

	private List<Arrow> _arrows;

	private readonly Dictionary<string, List<Arrow>> _poolDict;

	private bool _poolActivated;

	public static ArrowFactory Instance => null;

	public void Awake()
	{
	}

	public Arrow Make(string prefabName = "Arrow")
	{
		return null;
	}

	public void Return(Arrow arrow)
	{
	}

	public void NotifyDie(Arrow arrow)
	{
	}

	public void DestroyAll()
	{
	}
}
