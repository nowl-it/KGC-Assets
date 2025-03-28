using System.Collections.Generic;
using Awesomepiece.Model;
using UnityEngine;
using UnityEngine.UI;

public class TerritoryHuntingPanel : TerritoryBuildingMenuBase
{
	[SerializeField]
	private Text _ticketText;

	[SerializeField]
	private Text _ticketLeftTimeText;

	[SerializeField]
	private UITableView _huntingItemsTableView;

	[SerializeField]
	private GameObject _huntingListPanel;

	public TerritoryHuntingInfoPanel infoPanel;

	public TerritoryHuntingResultPanel resultPanel;

	private TerritoryBuildingData _buildingData;

	private ResourceTerritoryBuilding _resBuilding;

	private List<TerritoryHuntingData> _huntingDatas;

	private bool _canGetHuntingReward;

	public override void Show(TerritoryBuilding building)
	{
	}

	public void ReloadHuntings()
	{
	}

	protected override void Update()
	{
	}

	private void SetHuntingItem(int index, GameObject go)
	{
	}

	public void ReloadTicket()
	{
	}

	public void ShowHuntingInfoPanel(TerritoryHuntingData huntingData)
	{
	}

	public void OnClickReroll()
	{
	}

	public void OnClickBuyTicket()
	{
	}

	public override void OnClickClose()
	{
	}

	public override bool Close()
	{
		return false;
	}

	public void TestRefreshFlagTime()
	{
	}
}
