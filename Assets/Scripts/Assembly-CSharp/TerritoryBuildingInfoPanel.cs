using System;
using System.Collections.Generic;
using Awesomepiece.Model;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class TerritoryBuildingInfoPanel : MonoBehaviour, IClosable
{
	public Canvas _canvas;

	[SerializeField]
	private TerritoryBuildingUI _buildingUI;

	[SerializeField]
	private TerritoryAssignedUnits _territoryAssignedUnits;

	[SerializeField]
	private Canvas _assignedUnitsCanvas;

	[SerializeField]
	private GameObject _unitAssignBenefitObj;

	[SerializeField]
	private Text _unitAssignmentBenefitText;

	[SerializeField]
	private Text _unitAssignmentBenefitRoleBonusText;

	[SerializeField]
	private Image _unitAssignmentBenefitBonusRoleIcon;

	[SerializeField]
	private GameObject _confirmButton;

	[SerializeField]
	private Text _confirmButtonText;

	[SerializeField]
	private List<GameObject> _partitions;

	[SerializeField]
	private Border _boxBorder;

	[SerializeField]
	private LayoutFitter _boxLayoutFitter;

	[SerializeField]
	private Border _subDescsBorder;

	[SerializeField]
	private LayoutFitter _subDescsLayoutFitter;

	[SerializeField]
	private LayoutFitter _unitAssignmentBenefitsLayoutFitter;

	[SerializeField]
	private CanvasGroup[] _bonusTooltips;

	[SerializeField]
	private GameObject _ownedCurrenciesObj;

	[SerializeField]
	private Text _ownedGoldText;

	[SerializeField]
	private Text _ownedLaborText;

	[SerializeField]
	private Text _ownedBuildingCoreText;

	[SerializeField]
	private Text _ownedTownHallCoreText;

	[SerializeField]
	private Text _ownedPointText;

	[SerializeField]
	private ConditionalGroup _territoryTypeCond;

	private TerritoryBuildingData _buildingData;

	private Action<ResourceTerritoryBuilding> _onClickConfirm;

	private TerritoryUnitAssignPanel _territoryUnitAssignPanel;

	private Action _onClose;

	private Tween _tooltipTween;

	public Canvas canvas => null;

	public TerritoryUnitAssignPanel territoryUnitAssignPanel => null;

	private void Awake()
	{
	}

	public void Show(TerritoryBuildingData buildingData, Action onClose = null)
	{
	}

	public void Show(int buildingId, string confirmButtonText, Action<ResourceTerritoryBuilding> onClickConfirm, Action onClose = null)
	{
	}

	private void ShowImpl(TerritoryBuildingData buildingData)
	{
	}

	public void Reload()
	{
	}

	public void ReloadCurrencies()
	{
	}

	public void SetAssignedUnitsSortingOrder(int order)
	{
	}

	public void BuildingSpecsObjActive(bool active)
	{
	}

	public void UnitAssignObjActive(bool active)
	{
	}

	public void UnitAssignBenefitObjActive(bool active)
	{
	}

	public void SetUIState(TerritoryBuildingData buildingData, bool showUpgradeGauge)
	{
	}

	public void OnClickAssignUnit()
	{
	}

	public void ReloadMarkers()
	{
	}

	public bool Close()
	{
		return false;
	}

	public void OnClickClose()
	{
	}

	public void OnClickConfirm()
	{
	}

	public void OnClickBonusTooltip(int index)
	{
	}

	public void OnClickShowBonusUnitTooltip()
	{
	}

	public Button GetAssignButton()
	{
		return null;
	}

	public void TestSetRemainTime()
	{
	}

	public void TestSetLastTokenAt()
	{
	}
}
