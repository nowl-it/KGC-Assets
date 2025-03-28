using UnityEngine;
using UnityEngine.UI;

public class RogueLikeRandomRewardsPanelItem : RogueLikeEventPanelItem
{
	[SerializeField]
	private RogueLikeItemUI _itemUI;

	[SerializeField]
	private Image _flashMask;

	[SerializeField]
	private CanvasGroup _cg;

	public RogueLikeItemUI itemUI => null;

	public void Set(Constants.RogueLikeItemType type, int tier, int id, int amount)
	{
	}

	public override void SetSelected(int state)
	{
	}

	public void SetAlpha(float alpha)
	{
	}

	public void DoFade(float alpha, float time)
	{
	}

	public void DoFlash()
	{
	}

	public override void OnClick()
	{
	}
}
