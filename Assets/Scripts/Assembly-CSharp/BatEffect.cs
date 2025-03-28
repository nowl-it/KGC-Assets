using System.Collections.Generic;
using UnityEngine;

public class BatEffect : MonoBehaviour
{
	public GameObject prefab;

	private List<GameObject> _pools;

	public int batCountMin;

	public int batCountMax;

	public float genInterval;

	public float moveDistance;

	public float liveTime;

	private float _timer;

	public void Awake()
	{
	}

	public void Update()
	{
	}

	private void GenBat()
	{
	}
}
