using System;
using UnityEngine.Tilemaps;

namespace UnityEngine
{
	public class HexagonalRuleTile<T> : HexagonalRuleTile
	{
		public sealed override Type m_NeighborType => null;
	}
	[Serializable]
	[CreateAssetMenu(fileName = "New Hexagonal Rule Tile", menuName = "Tiles/Hexagonal Rule Tile")]
	public class HexagonalRuleTile : RuleTile
	{
		private static readonly int[,] RotatedOrMirroredIndexes;

		private static readonly Vector3Int[,] PointedTopNeighborOffsets;

		private static readonly Vector3Int[,] FlatTopNeighborOffsets;

		private static readonly int NeighborCount;

		public bool m_FlatTop;

		public override int neighborCount => 0;

		public override void RefreshTile(Vector3Int location, ITilemap tileMap)
		{
		}

		protected override bool RuleMatches(TilingRule rule, ref TileBase[] neighboringTiles, ref Matrix4x4 transform)
		{
			return false;
		}

		protected override Matrix4x4 ApplyRandomTransform(TilingRule.Transform type, Matrix4x4 original, float perlinScale, Vector3Int position)
		{
			return default(Matrix4x4);
		}

		protected override void GetMatchingNeighboringTiles(ITilemap tilemap, Vector3Int position, ref TileBase[] neighboringTiles)
		{
		}

		protected override int GetRotatedIndex(int original, int rotation)
		{
			return 0;
		}

		protected override int GetMirroredIndex(int original, bool mirrorX, bool mirrorY)
		{
			return 0;
		}

		private Vector3Int GetOffsetPosition(Vector3Int location, int direction)
		{
			return default(Vector3Int);
		}
	}
}
