using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class BackgroundLoop : MonoBehaviour
{
	public struct AnimCircle
	{
		public Transform transform;

		public Sequence sequence;
	}

	public GameObject singlePrefab;

	public float speed;

	public Vector2 gap;

	public Vector2 offset;

	public Vector2 size;

	public Vector2Int counts;

	private float _stopTime;

	private List<AnimCircle> _circles;

	public void Start()
	{
	}

	private void SpawnCircle(Vector3 pos)
	{
	}

	public void Init()
	{
	}

	public void SetSpeed(float speed)
	{
	}

	public void Break(float time = 0.1f)
	{
	}

	public void Bounce()
	{
	}

	public void Update()
	{
	}
}
