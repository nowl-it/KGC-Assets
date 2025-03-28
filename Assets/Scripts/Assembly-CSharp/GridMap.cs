using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using NMeCab.Core;
using UnityEngine;

public class GridMap
{
	public class PathNode : IComparable<PathNode>
	{
		public int operation;

		public PathNode before;

		public Vector2Int pos;

		public uint index;

		private static uint _staticIndex;

		public int fValue;

		private static readonly List<List<Vector2Int>> _listPool;

		private static readonly List<List<Vector2Int>> _rented;

		public List<Vector2Int> path => null;

		public static List<Vector2Int> Combine(PathNode node, PathNode inverseNode)
		{
			return null;
		}

		public void Set(PathNode from, Vector2Int pos)
		{
		}

		public int CompareTo(PathNode other)
		{
			return 0;
		}

		public override string ToString()
		{
			return null;
		}

		private static List<Vector2Int> RentList()
		{
			return null;
		}

		public static void ReturnList(List<Vector2Int> list)
		{
		}
	}

	private static bool _showLog;

	public const int Width = 7;

	public const int Height = 12;

	public const int TileSize = 51;

	public const float StartX = -153f;

	public const float StartY = 657.5f;

	public static List<Vector2Int> ZeroList;

	private int[] _map;

	private bool[] _visited;

	private bool[] _targetVisited;

	private HashSet<GameUnit> _holdedUnits;

	private HashSet<BaseAI> _aiMapChangeListeners;

	public BattleManager battle;

	private int[] _gValue;

	private int[] _hValue;

	private Queue<PathNode> _pathNodePool;

	private Queue<PathNode> _rented;

	private Queue<PathNode> _bfsQueue;

	private Queue<PathNode> _inverseBfsQueue;

	private List<PathNode> _lst;

	private List<PathNode> _failedNodes;

	private PriorityQueue<PathNode> _aStarPriorityQueue;

	private static Vector2Int _tileDistSortTarget;

	private static GameUnit _targetForSort;

	private static readonly List<Vector2Int> _tmpList;

	[MethodImpl(256)]
	private static int Vector2ToInt(in Vector2Int vec)
	{
		return 0;
	}

	[MethodImpl(256)]
	private int GetFromMap(int x, int y)
	{
		return 0;
	}

	private void SetToMap(int x, int y, GameUnit unit)
	{
	}

	public bool Reserve(in Vector2Int pos, GameUnit unit)
	{
		return false;
	}

	public bool Unreserve(in Vector2Int pos, GameUnit unit)
	{
		return false;
	}

	public void ClearHoldedUnits()
	{
	}

	public void AddHoldedUnit(GameUnit unit)
	{
	}

	public void RemoveHoldedUnit(GameUnit unit)
	{
	}

	public bool IsHolded(GameUnit unit)
	{
		return false;
	}

	public void RegisterAIMapChangeLister(BaseAI ai)
	{
	}

	public void UnregisterAIMapChangeLister(BaseAI ai)
	{
	}

	public bool MoveTo(GameUnit unit, Vector2Int before, Vector2Int after)
	{
		return false;
	}

	[MethodImpl(256)]
	public bool IsReserved(int x, int y)
	{
		return false;
	}

	public bool IsReserved(int x, int y, GameUnit from)
	{
		return false;
	}

	public void Clear()
	{
	}

	public Vector2 GetPosition(Vector2Int tilePos)
	{
		return default(Vector2);
	}

	public Vector2Int GetTilePosition(Vector2 pos)
	{
		return default(Vector2Int);
	}

	public Vector3 ToWorldPosition(Vector3 pos)
	{
		return default(Vector3);
	}

	[MethodImpl(256)]
	public static bool IsInEdge(int x, int y)
	{
		return false;
	}

	[MethodImpl(256)]
	public static bool IsInMap(int x, int y)
	{
		return false;
	}

	public void ShowDebugMap()
	{
	}

	private PathNode GetNewPathNode()
	{
		return null;
	}

	private void ReturnAllNodeToPool()
	{
	}

	private static int TileDistSort(PathNode a, PathNode b)
	{
		return 0;
	}

	public List<Vector2Int> GetPathBfs(GameUnit from, Vector2Int to, bool allowFailed = true, int? seed = null)
	{
		return null;
	}

	public Vector2Int GetNearestEmptyPos(Vector2Int from, Vector2Int[] dirs = null, int? seed = null, Vector2Int[] bannedDirs = null)
	{
		return default(Vector2Int);
	}

	private Vector2Int GetIndexedPos(Vector2Int from, int dist, int idx)
	{
		return default(Vector2Int);
	}

	public List<Vector2Int> GetRangePath(GameUnit me, GameUnit target, RangeInfo range, int? seed = null)
	{
		return null;
	}

	private void ClearVisited()
	{
	}

	[MethodImpl(256)]
	private bool CheckVisited(in Vector2Int pos)
	{
		return false;
	}

	[MethodImpl(256)]
	private bool CheckVisited(int x, int y)
	{
		return false;
	}

	[MethodImpl(256)]
	private void SetVisited(in Vector2Int pos, bool v)
	{
	}

	private void ClearTargetVisited()
	{
	}

	private bool CheckTargetVisited(in Vector2Int pos)
	{
		return false;
	}

	private void SetTargetVisited(in Vector2Int pos, bool v)
	{
	}

	private void ClearAStarValues()
	{
	}

	[MethodImpl(256)]
	private void SetAStarValues(int x, int y, int gValue, int hValue)
	{
	}

	public List<Vector2Int> GetRangePathAStar(GameUnit me, GameUnit target, RangeInfo range, int? seed = null)
	{
		return null;
	}

	public List<Vector2Int> GetPathAStar(GameUnit from, Vector2Int to, bool allowFailed = true, int? seed = null)
	{
		return null;
	}

	private List<Vector2Int> MakeAStarPathFromFinalNode(PathNode node)
	{
		return null;
	}

	public List<Vector2Int> GetAllValidPoses()
	{
		return null;
	}

	public List<Vector2Int> GetPoses(Vector2Int from, RangeInfo range, Vector2Int dir = default(Vector2Int))
	{
		return null;
	}

	public Vector2Int GetRandomEmptyPos(Vector2Int from, RangeInfo range, Vector2Int dir = default(Vector2Int), int? seed = null)
	{
		return default(Vector2Int);
	}

	public Vector2Int GetRandomEmptyPosByUnits(Vector2Int from, RangeInfo range, int team, Vector2Int dir = default(Vector2Int), int? seed = null)
	{
		return default(Vector2Int);
	}

	public Vector2Int GetRandomEmptyTeamPos(int team, int? seed = null, List<GameUnit> targets = null, List<Vector2Int> excepts = null)
	{
		return default(Vector2Int);
	}

	public List<Vector2Int> GetAllEmptyTeamPos(List<Vector2Int> candidates, List<GameUnit> targets = null, List<Vector2Int> excepts = null)
	{
		return null;
	}

	public List<Vector2Int> GetAllTilePos(int team, Predicate<Vector2Int> checker = null)
	{
		return null;
	}

	public List<Vector2Int> GetPathAttackList(Vector2Int from, Vector2Int to)
	{
		return null;
	}

	public bool CheckPath(GameUnit from, Vector2Int to, bool allowFailed = true, int? seed = null)
	{
		return false;
	}

	public int GetPathDistance(GameUnit from, Vector2Int to, bool allowFailed = true, int? seed = null)
	{
		return 0;
	}

	public Vector2Int ChooseFarthestTileFromEnemies(List<Vector2Int> targetTiles, int myTeam, GameUnit unit, int? seed = null)
	{
		return default(Vector2Int);
	}

	public List<Vector2Int> GetBoundaryTilesOfRange(GameUnit from, Vector2Int targetPos, RangeInfo range)
	{
		return null;
	}
}
