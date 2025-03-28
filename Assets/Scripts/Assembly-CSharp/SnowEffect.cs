using System.Collections.Generic;
using UnityEngine;

public class SnowEffect : MonoBehaviour
{
	public GameObject prefab;

	public Sprite[] sprites;

	private List<GameObject> _pools;

	public float genIntervalMin;

	public float genIntervalMax;

	public int genCount;

	public float moveDistance;

	public float liveTime;

	private float _timer;

	public void Awake()
	{
	}

	public void Update()
	{
	}

	private void GenSnow()
	{
	}
}
