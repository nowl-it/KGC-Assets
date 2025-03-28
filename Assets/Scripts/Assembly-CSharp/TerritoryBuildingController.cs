using UnityEngine;

public class TerritoryBuildingController : MonoBehaviour
{
	public SpriteRenderer[] sprites;

	[SerializeField]
	private SpriteOutlineTerritory[] _spriteOutlines;

	public Collider2D[] colliders;

	private GameObject _craftingEffect;

	public void ShowOutline(bool set, Color color)
	{
	}

	public void SetUpgrading(bool inUpgrade)
	{
	}
}
