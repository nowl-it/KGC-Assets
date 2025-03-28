using System.Collections.Generic;
using UnityEngine;

public class TerritoryUIPanel : MonoBehaviour
{
	[SerializeField]
	private List<TerritoryBuildingShortCutButton> _buildingShortCutButtons;

	private TerritoryBuildingListPanel _territoryBuildingListPanel;

	private BuyItemPanel_Voucher _buyItemPanelVoucher;

	public TerritoryBuildingListPanel territoryBuildingListPanel => null;

	public BuyItemPanel_Voucher buyItemPanelVoucher => null;

	public void Show(bool show)
	{
	}

	public void OnBuildingUpdated()
	{
	}

	public void ShowBuildingShortCutButtonBadge(int buildingRootId, bool show)
	{
	}

	public void OnClickBuildButton(bool includeUpgrade)
	{
	}

	public void OnClickGoToLobbyButton()
	{
	}
}
