using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TerritoryBuildingListPanel : MonoBehaviour, IClosable
{
	private struct BuildDataWithBuilding
	{
		public Scene_Territory.BuildData buildData;

		public TerritoryBuilding building;
	}

	[SerializeField]
	private UIGridView _gridView;

	[SerializeField]
	private TabManager _tabManager;

	[SerializeField]
	private Text _goldText;

	[SerializeField]
	private Text _laborText;

	[SerializeField]
	private Text _buildingCoreText;

	[SerializeField]
	private Text _townHallCoreText;

	[SerializeField]
	private Text _pointText;

	[SerializeField]
	private Text _noneBuildingText;

	[SerializeField]
	private ConditionalGroup _territoryTypeCond;

	private readonly List<BuildDataWithBuilding> _buildings;

	private List<BuildDataWithBuilding> _curShowBuildings;

	private ResourceTerritoryBuilding.Category _currentTab;

	private ResourceTerritoryBuilding.EventBuildingType _currentEventBuildingType;

	private bool _includeUpgrade;

	private TerritoryBuilding _lastClickedBuilding;

	public static TerritoryBuildingListPanel Instance => null;

	private void Awake()
	{
	}

	public void Show(bool includeUpgrade)
	{
	}

	public void ReloadCurrencies()
	{
	}

	public void ReloadBuildings()
	{
	}

	public void Reload()
	{
	}

	public void ClickLastClickedBuilding()
	{
	}

	private void SetBuildingItem(int index, GameObject go)
	{
	}

	private void OnClickBuildingItem(TerritoryBuildingUI item, Scene_Territory.BuildData buildData, TerritoryBuilding building)
	{
	}

	public bool Close()
	{
		return false;
	}

	public void OnClickClose()
	{
	}

	public void OnClickTab(TabComponent tab)
	{
	}

	public TerritoryBuildingUI GetBuildingCell(int rootId)
	{
		return null;
	}
}
