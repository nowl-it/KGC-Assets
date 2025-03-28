using UnityEngine;

public class GhostEffect : MonoBehaviour
{
	public GameObject prefab;

	public Sprite[] sprites;

	public float genInterval;

	public float moveDistance;

	public float liveTime;

	private float _timer;

	private Vector3[] _moveDirs;

	public void Awake()
	{
	}

	public void Update()
	{
	}

	private void GenGhost()
	{
	}
}
