using System;
using System.Collections.Generic;
using UnityEngine.Tilemaps;

namespace UnityEngine
{
	public class RuleTile<T> : RuleTile
	{
		public sealed override Type m_NeighborType => null;
	}
	[Serializable]
	[CreateAssetMenu(fileName = "New Rule Tile", menuName = "Tiles/Rule Tile")]
	public class RuleTile : TileBase
	{
		[Serializable]
		public class TilingRule
		{
			public class Neighbor
			{
				public const int DontCare = 0;

				public const int This = 1;

				public const int NotThis = 2;
			}

			public enum Transform
			{
				Fixed = 0,
				Rotated = 1,
				MirrorX = 2,
				MirrorY = 3
			}

			public enum OutputSprite
			{
				Single = 0,
				Random = 1,
				Animation = 2,
				AnimatedOffsetRandom = 3
			}

			public int[] m_Neighbors;

			public Sprite[] m_Sprites;

			public GameObject m_GameObject;

			public float m_AnimationSpeed;

			public float m_PerlinScale;

			public Transform m_RuleTransform;

			public OutputSprite m_Output;

			public Tile.ColliderType m_ColliderType;

			public Transform m_RandomTransform;
		}

		private static readonly int[,] RotatedOrMirroredIndexes;

		private static readonly int NeighborCount;

		public Sprite m_DefaultSprite;

		public GameObject m_DefaultGameObject;

		public Tile.ColliderType m_DefaultColliderType;

		protected TileBase[] m_CachedNeighboringTiles;

		private TileBase m_OverrideSelf;

		private Quaternion m_GameObjectQuaternion;

		[HideInInspector]
		public List<TilingRule> m_TilingRules;

		public virtual Type m_NeighborType => null;

		public virtual int neighborCount => 0;

		public TileBase m_Self
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override bool StartUp(Vector3Int location, ITilemap tilemap, GameObject instantiateedGameObject)
		{
			return false;
		}

		public override void GetTileData(Vector3Int position, ITilemap tilemap, ref TileData tileData)
		{
		}

		public TilingRule GetRule(Vector3Int position, Tilemap tilemap)
		{
			return null;
		}

		protected static float GetPerlinValue(Vector3Int position, float scale, float offset)
		{
			return 0f;
		}

		public static void ShuffleArray<T>(T[] array)
		{
		}

		public override bool GetTileAnimationData(Vector3Int position, ITilemap tilemap, ref TileAnimationData tileAnimationData)
		{
			return false;
		}

		public bool GetTileAnimationData1(Vector3Int position, Tilemap tilemap, ref TileAnimationData tileAnimationData)
		{
			return false;
		}

		public override void RefreshTile(Vector3Int location, ITilemap tileMap)
		{
		}

		protected virtual bool RuleMatches(TilingRule rule, ref TileBase[] neighboringTiles, ref Matrix4x4 transform)
		{
			return false;
		}

		protected virtual Matrix4x4 ApplyRandomTransform(TilingRule.Transform type, Matrix4x4 original, float perlinScale, Vector3Int position)
		{
			return default(Matrix4x4);
		}

		public virtual bool RuleMatch(int neighbor, TileBase tile)
		{
			return false;
		}

		protected bool RuleMatches(TilingRule rule, ref TileBase[] neighboringTiles, int angle)
		{
			return false;
		}

		protected bool RuleMatches(TilingRule rule, ref TileBase[] neighboringTiles, bool mirrorX, bool mirrorY)
		{
			return false;
		}

		protected virtual void GetMatchingNeighboringTiles(ITilemap tilemap, Vector3Int position, ref TileBase[] neighboringTiles)
		{
		}

		protected void GetMatchingNeighboringTiles1(Tilemap tilemap, Vector3Int position, ref TileBase[] neighboringTiles)
		{
		}

		protected virtual int GetRotatedIndex(int original, int rotation)
		{
			return 0;
		}

		protected virtual int GetMirroredIndex(int original, bool mirrorX, bool mirrorY)
		{
			return 0;
		}
	}
}
