using System.Collections.Generic;
using UnityEngine;

public class UnitGrid : MonoBehaviour
{
	public static UnitGrid Instance;

	public GameObject gridPrefab;

	public Vector2Int size;

	public Vector2Int bonusSize;

	public Vector2Int offset;

	public Vector2 cellSize;

	public Vector2 gapSize;

	private Dictionary<Vector2Int, GridTile> _tilesDict;

	private List<GridTile> _tiles;

	private float _width;

	private float _height;

	public BattleManager battle;

	private Vector2Int _lastSize;

	private int[] _posCenter;

	public int cellCount => 0;

	public List<GridTile> tiles => null;

	public void Awake()
	{
	}

	public void Init(BattleManager battleManager)
	{
	}

	public void Init(int width, int height)
	{
	}

	public void AddTile(int tileX, int tileY)
	{
	}

	public Vector2Int GetTilePos(Vector2 pos)
	{
		return default(Vector2Int);
	}

	public Vector2 GetPosFromTile(Vector2Int tilePos)
	{
		return default(Vector2);
	}

	public void Show()
	{
	}

	public void Hide()
	{
	}

	public void Reload()
	{
	}

	public void SetFocus(int x, int y, GameUnit unit, bool skill = false)
	{
	}

	public void SetFocusNoSkill(int x, int y, GameUnit unit)
	{
	}

	private void SetFieldFocus(int x, int y, GameUnit unit, bool skill)
	{
	}

	private void SetOtherFocus(int x, int y, GameUnit unit)
	{
	}

	public void SetHighlight(Vector2Int pos)
	{
	}

	public void ResetHighLight()
	{
	}

	public void ClearMergiable(List<Vector2Int> excepts = null)
	{
	}

	public void SetMergiable(Vector2Int pos, string color = "")
	{
	}

	public void SetTileBuffRange(Vector2Int pos, RangeInfo range)
	{
	}

	public void ClearFocus()
	{
	}

	public bool IsValid(int x, int y)
	{
		return false;
	}

	public Vector2Int GetEmptyPos()
	{
		return default(Vector2Int);
	}

	public GridTile GetTile(Vector2Int pos)
	{
		return null;
	}
}
