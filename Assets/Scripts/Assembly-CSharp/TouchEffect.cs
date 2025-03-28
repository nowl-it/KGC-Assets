using System.Collections.Generic;
using UnityEngine;

public class TouchEffect : MonoBehaviour
{
	public static TouchEffect Instance;

	public GameObject prefab;

	private List<GameObject> _pools;

	private static float _scaleValue;

	public static bool on;

	public GameObject trailEffect;

	private Vector2 _lastScreenSize;

	private Canvas _canvas;

	public void Awake()
	{
	}

	public void RefreshScreenSize()
	{
	}

	public void Update()
	{
	}

	private void ShowEffect()
	{
	}

	public void DisableAll()
	{
	}
}
