using UnityEngine.UI;

public class ItemUnit : ItemUnitBase
{
	public ConditionalSpriteRenderer runeStarConditionalSprite;

	public Item item;

	public Text parameterText;

	public void Init(int id, int battleManagerIdx, int? seed = null)
	{
	}

	public void Init(Item item, int battleManagerIdx)
	{
	}

	protected override void IdleSequencing()
	{
	}

	public override void BeginDrag()
	{
	}

	public override void OnDrag()
	{
	}

	public override void EndDrag()
	{
	}

	public override void OnClick()
	{
	}

	public override bool CanMerge(GameUnit other)
	{
		return false;
	}

	public override bool CanMergeWithSomeone(bool onlyWaitingFields = false)
	{
		return false;
	}

	public bool CanEquipTo(GameUnit unit)
	{
		return false;
	}

	public bool CanEquipToSomeone(bool onlyWaitingFields = false)
	{
		return false;
	}

	public void MergeWith(ItemUnit other)
	{
	}

	public void TierUp(ItemUnit mergedWith)
	{
	}

	public void RefreshRepresentativeValue()
	{
	}

	private void ReloadRuneTierStar()
	{
	}

	public override void SetSpriteOrder(int order)
	{
	}
}
