using System.Collections.Generic;
using UnityEngine;

public class ObstacleUnit : GameUnit
{
	public void Init(int battleManagerIdx, Vector2 pos, string prefab = "Barricade_01a")
	{
	}

	private void SetPrefab(string prefabName)
	{
	}

	public override List<Vector2Int> GetTileSize()
	{
		return null;
	}
}
