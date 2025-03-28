using System;
using UnityEngine;

public class RogueLikeInventoryIcon : MonoBehaviour
{
	[SerializeField]
	private RogueLikeItemIcon _itemIcon;

	private Action<RogueLikeInventoryIcon> _onClick;

	public Constants.RogueLikeItemType type { get; private set; }

	public Item item { get; private set; }

	public ItemUnit itemUnit { get; private set; }

	public GameUnit equippedBy { get; private set; }

	public RogueLikeArtifactModel artifactModel { get; private set; }

	public RogueLikeCardData cardData { get; private set; }

	private void Clear()
	{
	}

	public void SetItem(Constants.RogueLikeItemType type, Item item, ItemUnit itemUnit, GameUnit equippedBy, Action<RogueLikeInventoryIcon> onClick)
	{
	}

	public void SetRune(Rune rune, ItemUnit itemUnit, GameUnit equippedBy, Action<RogueLikeInventoryIcon> onClick)
	{
	}

	public void SetArtifact(RogueLikeArtifactModel artifact, Action<RogueLikeInventoryIcon> onClick)
	{
	}

	public void SetHero(RogueLikeCardData cardData, Action<RogueLikeInventoryIcon> onClick)
	{
	}

	public void OnClick()
	{
	}

	public void SetSelected(bool set)
	{
	}
}
