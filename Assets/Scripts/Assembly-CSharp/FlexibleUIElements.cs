using System;
using System.Collections.Generic;
using UnityEngine;

public class FlexibleUIElements : MonoBehaviour
{
	[SerializeField]
	private LayoutFitter _layoutFitter;

	private bool _isInitialized;

	private readonly List<GameObject> _elements;

	private GameObject _prefab;

	private int _enabledCount;

	private void Initialize()
	{
	}

	public void Set<T>(int count, Action<int, GameObject, T> setCallback) where T : MonoBehaviour
	{
	}

	public void ForEach<T>(Action<int, GameObject, T> func) where T : MonoBehaviour
	{
	}

	public GameObject GetElement(int index)
	{
		return null;
	}

	public void Fit()
	{
	}
}
