using UnityEngine;
using UnityEngine.UI;

public class ThirdHalfAnniversaryMissionPanel : MissionPanel
{
	[SerializeField]
	private ThirdHalfAnniversaryMissionPanel_Base _exclusiveBasePanel;

	[SerializeField]
	private PopupPanel _buyPassPopup;

	[SerializeField]
	private ConditionalGroup _conditionalBuyPassButtonGroup;

	[SerializeField]
	private Text _passPriceText;

	private ResourceShopItem _resShopItem;

	private bool _isEventEnd;

	private static int _dayPassedFromStart => 0;

	private bool _isBuyPass => false;

	protected override void Init()
	{
	}

	public void Show()
	{
	}

	protected override void BeforeShow()
	{
	}

	protected override void OnReceive(MissionPanel_Base panelBase)
	{
	}

	private void RefreshTabLocks()
	{
	}

	private new static bool CheckShowCondition(int tabIdx, ResourceMission resMission, bool isConditionForClearedCountBadge)
	{
		return false;
	}

	public void OnClickShowPassPopup()
	{
	}

	public void OnClickClosePassPopup()
	{
	}

	public void OnClickBuyPass()
	{
	}

	public void HandleBuyComplete()
	{
	}

	private void Reload()
	{
	}

	public void OnEventEnd()
	{
	}

	public new static int GetTotalClearedMissionCount()
	{
		return 0;
	}
}
