using System.Collections.Generic;
using UnityEngine;

public class UIUnitPrefabPool : MonoBehaviour
{
	private static UIUnitPrefabPool _instance;

	private static bool _isCreated;

	private readonly Dictionary<string, UnitController> _pool;

	public static UIUnitPrefabPool Instance => null;

	private void OnDestroy()
	{
	}

	public UnitController Rent(string name, Transform transform)
	{
		return null;
	}

	public void Return(UnitController unit)
	{
	}
}
