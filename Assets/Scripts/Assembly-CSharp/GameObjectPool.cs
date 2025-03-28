using System.Collections.Generic;
using UnityEngine;

public class GameObjectPool : MonoBehaviour
{
	private List<GameObject> _list;

	[SerializeField]
	private GameObject _prefab;

	[SerializeField]
	private int _initSize;

	private string _originName;

	private Transform _transform;

	public void Awake()
	{
	}

	private void Enqueue(GameObject obj)
	{
	}

	private GameObject Dequeue()
	{
		return null;
	}

	public GameObject CreateInstance(bool store = false)
	{
		return null;
	}

	public GameObject Rent()
	{
		return null;
	}

	public void Return(MonoBehaviour component)
	{
	}

	public void Return(GameObject obj)
	{
	}

	private void RefreshName(int count)
	{
	}

	public GameObject GetPrefab()
	{
		return null;
	}
}
