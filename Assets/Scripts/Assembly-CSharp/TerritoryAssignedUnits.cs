using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TerritoryAssignedUnits : MonoBehaviour
{
	[SerializeField]
	private ScrollRect _scrollRect;

	[SerializeField]
	private FlexibleUIElements _cardElements;

	[SerializeField]
	private FlexibleUIElements _roleBonusIconElements;

	private readonly List<DraggableCardBase<CardData>> _slots;

	private ResourceUnit.Role _bonusRole;

	public void Set(IDraggableCardBaseHandler<CardData> draggableCardBaseHandler, ResourceTerritoryBuilding resBuilding, List<int> assignedUnits)
	{
	}

	public List<DraggableCardBase<CardData>> GetAllSlots()
	{
		return null;
	}

	public void OnClickShowBonusUnitTooltip()
	{
	}
}
