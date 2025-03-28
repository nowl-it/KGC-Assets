using UnityEngine;

public class InvasionDifficultyTooltipPanel : PopupPanel
{
	[SerializeField]
	private RectTransform _tooltipItemRoot;

	[SerializeField]
	private InvasionDifficultyTooltipItem _tooltipPrefab;

	private bool _initialized;

	public override void Show()
	{
	}

	private void InitializeItems()
	{
	}
}
