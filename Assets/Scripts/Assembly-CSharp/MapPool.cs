using System.Collections.Generic;
using UnityEngine;

public class MapPool : MonoBehaviour
{
	public bool activated;

	private Dictionary<string, GameObject> _pool;

	public GameObject Rent(string prefab)
	{
		return null;
	}

	public void Return(GameObject map)
	{
	}

	public bool CanRent(string prefab)
	{
		return false;
	}

	public void DestroyAll()
	{
	}
}
