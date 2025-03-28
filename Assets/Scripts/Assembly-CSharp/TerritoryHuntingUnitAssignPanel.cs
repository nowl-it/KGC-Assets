using System.Collections.Generic;
using Awesomepiece.Model;
using UnityEngine;
using UnityEngine.UI;

public class TerritoryHuntingUnitAssignPanel : MonoBehaviour, IClosable, IDraggableCardBaseHandler<CardData>
{
	[SerializeField]
	private GameObject _unitItemPrefab;

	[SerializeField]
	private Transform _assignedUnitsRoot;

	[SerializeField]
	private List<DraggableCardBase<CardData>> _assignedUnitSlots;

	[SerializeField]
	private Image _huntingRegionIcon;

	[SerializeField]
	private Text _huntingRegionText;

	[SerializeField]
	private Text _lowestPossibleRankText;

	[SerializeField]
	private Text _regionBonusText;

	[SerializeField]
	private DraggableUnitCardGridPanel _unitCardGridPanel;

	[SerializeField]
	private RectTransform _cardUnEquipArea;

	private TerritoryHuntingData _huntingData;

	private ResourceTerritoryHunting _resHunting;

	private List<int> _assignedUnits;

	private readonly List<CardData> _cards;

	public DraggableCardBase<CardData> currentDraggingCard { get; set; }

	public void Show(TerritoryHuntingData huntingData, int difficulty, List<int> assignedUnits)
	{
	}

	public void ReloadAll()
	{
	}

	public void SetCardStatus(DraggableCardBase<CardData> card)
	{
	}

	public void OnDragIntoSlot(DraggableCardBase<CardData> fromCard, DraggableCardBase<CardData> toCard, int fromIndex, int toIndex)
	{
	}

	public void OnSwapCard(DraggableCardBase<CardData> fromCard, DraggableCardBase<CardData> toCard, int fromIndex, int toIndex)
	{
	}

	public bool IsCardInUse(DraggableCardBase<CardData> card)
	{
		return false;
	}

	public bool CanEquip(DraggableCardBase<CardData> card)
	{
		return false;
	}

	public void OnDragFailed(DraggableCardBase<CardData> card)
	{
	}

	public void OnUnEquip(DraggableCardBase<CardData> card, int fromIndex)
	{
	}

	public List<DraggableCardBase<CardData>> GetAllSlots()
	{
		return null;
	}

	public RectTransform GetUnEquipArea()
	{
		return null;
	}

	private TerritoryDraggableUnitCard AddUnitItem(Transform root, int index, CardData card)
	{
		return null;
	}

	private void OnAddUnitItem(int index, CardData card, TerritoryDraggableUnitCard unitItem)
	{
	}

	private void OnAddUnitItem(int index, CardData card, TerritoryDraggableUnitCard unitItem, bool bgActive)
	{
	}

	public TerritoryHuntingData GetUnitAssignedHunting(int unitId)
	{
		return null;
	}

	private void OnApplicationFocus(bool hasFocus)
	{
	}

	private void OnApplicationPause(bool hasFocus)
	{
	}

	public bool Close()
	{
		return false;
	}

	public void OnClickClose()
	{
	}

	public void OnClickShowBonusUnitTooltip()
	{
	}

	private bool Filter(CardData cardData)
	{
		return false;
	}

	public void OnClickAutoSelect()
	{
	}

	public void OnClickClear()
	{
	}
}
