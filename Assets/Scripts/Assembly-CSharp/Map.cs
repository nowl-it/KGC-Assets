using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Map : MonoBehaviour
{
	public Tilemap baseTilemap;

	public List<Vector2> path;

	public SpriteRenderer map;

	public string mapPatchPath;

	[Header("장애물 대신에 Object 배치할 때만 이용. 안쓰면 비워둬야 함!")]
	public ObstacleObject[] obstacleObjects;

	public ObstacleObject bossObstacleObject;

	public List<int> bannedObstacles;

	public void Awake()
	{
	}

	private void SetRoute(Transform route)
	{
	}

	public void Init(bool enableCameraBounds)
	{
	}

	public void SwitchMaterial()
	{
	}

	public bool InMap(Vector2 pos)
	{
		return false;
	}

	public bool IsBlock(Vector2 pos)
	{
		return false;
	}
}
