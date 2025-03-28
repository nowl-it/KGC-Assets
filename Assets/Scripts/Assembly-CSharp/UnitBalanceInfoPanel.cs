using UnityEngine;
using UnityEngine.UI;

public class UnitBalanceInfoPanel : MonoBehaviour
{
	public Button statAreaButton;

	public Button totalAreaButton;

	public Button infoPopupButton;

	[SerializeField]
	private UnitBalanceInfoItem[] _unitBalanceInfo;

	[Header("For Simple Tooltip")]
	[SerializeField]
	private Tooltip _tooltip;

	[Header("For Detail Tooltip")]
	[SerializeField]
	private ClosableObject _tooltipPopup;

	private int _currentTheme;

	private bool _initialized;

	public ClosableObject tooltipPopup => null;

	public void Set(int[] cards, int theme)
	{
	}

	public void ShowTooltip()
	{
	}

	public void ShowDetailTooltip()
	{
	}
}
