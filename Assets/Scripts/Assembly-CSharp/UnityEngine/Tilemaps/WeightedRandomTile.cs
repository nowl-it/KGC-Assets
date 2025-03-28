using System;

namespace UnityEngine.Tilemaps
{
	[Serializable]
	[CreateAssetMenu(fileName = "New Weighted Random Tile", menuName = "Tiles/Weighted Random Tile")]
	public class WeightedRandomTile : Tile
	{
		[SerializeField]
		public WeightedSprite[] Sprites;

		public override void GetTileData(Vector3Int location, ITilemap tileMap, ref TileData tileData)
		{
		}
	}
}
