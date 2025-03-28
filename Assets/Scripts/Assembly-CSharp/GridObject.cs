using UnityEngine;

public class GridObject : MonoBehaviour
{
	public UnitGrid parentGrid;

	public Vector2Int tilePos;

	public Vector3 offset;

	public bool applyZPosition;

	public void SetParent(UnitGrid grid)
	{
	}

	public void Set(Vector2Int pos)
	{
	}

	public GridTile GetGridTile()
	{
		return null;
	}
}
