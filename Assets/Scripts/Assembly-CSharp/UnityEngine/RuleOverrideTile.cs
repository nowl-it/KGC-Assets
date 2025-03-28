using System;
using System.Collections.Generic;
using UnityEngine.Tilemaps;

namespace UnityEngine
{
	[Serializable]
	[CreateAssetMenu(fileName = "New Rule Override Tile", menuName = "Tiles/Rule Override Tile")]
	public class RuleOverrideTile : TileBase
	{
		[Serializable]
		public class TileSpritePair
		{
			public Sprite m_OriginalSprite;

			public Sprite m_OverrideSprite;
		}

		[Serializable]
		public class OverrideTilingRule
		{
			public bool m_Enabled;

			public RuleTile.TilingRule m_TilingRule;
		}

		public RuleTile m_Tile;

		public bool m_OverrideSelf;

		public bool m_Advanced;

		public List<TileSpritePair> m_Sprites;

		public List<OverrideTilingRule> m_OverrideTilingRules;

		public OverrideTilingRule m_OverrideDefault;

		[HideInInspector]
		public RuleTile m_RuntimeTile;

		public Sprite this[Sprite originalSprite]
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public RuleTile.TilingRule this[RuleTile.TilingRule originalRule]
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public RuleTile.TilingRule m_OriginalDefault => null;

		public override bool GetTileAnimationData(Vector3Int position, ITilemap tilemap, ref TileAnimationData tileAnimationData)
		{
			return false;
		}

		public override void GetTileData(Vector3Int position, ITilemap tilemap, ref TileData tileData)
		{
		}

		public override void RefreshTile(Vector3Int position, ITilemap tilemap)
		{
		}

		public override bool StartUp(Vector3Int position, ITilemap tilemap, GameObject go)
		{
			return false;
		}

		public void ApplyOverrides(IList<KeyValuePair<Sprite, Sprite>> overrides)
		{
		}

		public void GetOverrides(List<KeyValuePair<Sprite, Sprite>> overrides)
		{
		}

		public void ApplyOverrides(IList<KeyValuePair<RuleTile.TilingRule, RuleTile.TilingRule>> overrides)
		{
		}

		public void GetOverrides(List<KeyValuePair<RuleTile.TilingRule, RuleTile.TilingRule>> overrides)
		{
		}

		public void Override()
		{
		}

		public RuleTile.TilingRule CloneTilingRule(RuleTile.TilingRule from)
		{
			return null;
		}

		public void CopyTilingRule(RuleTile.TilingRule from, RuleTile.TilingRule to, bool copyRule)
		{
		}
	}
}
