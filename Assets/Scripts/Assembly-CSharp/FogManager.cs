using System.Collections.Generic;
using UnityEngine;

public class FogManager : MonoBehaviour
{
	public struct FogData
	{
		public Transform transform;

		public float speed;
	}

	private string fogPrefabName;

	public float startY;

	public int fogCount;

	public Vector2 speedRange;

	public Vector2 yGapRange;

	private List<FogData> _fogs;

	public void Awake()
	{
	}

	public void Show(string fogPrefabName)
	{
	}

	private void SpawnFog(Vector3 pos, float speed)
	{
	}

	public void Init()
	{
	}

	public void Update()
	{
	}
}
