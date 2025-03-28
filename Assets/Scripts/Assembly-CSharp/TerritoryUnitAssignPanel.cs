using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Awesomepiece.Model;
using Cysharp.Threading.Tasks;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class TerritoryUnitAssignPanel : MonoBehaviour, IClosable, IDraggableCardBaseHandler<CardData>
{
	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003COnSwapCard_003Ed__23 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public TerritoryUnitAssignPanel _003C_003E4__this;

		public DraggableCardBase<CardData> fromCard;

		public DraggableCardBase<CardData> toCard;

		public int fromIndex;

		public int toIndex;

		private TerritoryBuildingData _003CbuildingData_003E5__2;

		private TerritoryBuildingData _003CotherBuildingData_003E5__3;

		private UniTask<bool>.Awaiter _003C_003Eu__1;

		private UniTask<SwapAssignedHeroesFromBuildingsResponseModel>.Awaiter _003C_003Eu__2;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CSaveAssignedUnits_003Ed__38 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public TerritoryUnitAssignPanel _003C_003E4__this;

		private UniTask.Awaiter _003C_003Eu__1;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[SerializeField]
	private TerritoryAssignedUnits _territoryAssignedUnits;

	[SerializeField]
	private Text _assignBenefitDescText;

	[SerializeField]
	private Text _benefitRoleBonusDescText;

	[SerializeField]
	private DraggableUnitCardGridPanel _unitCardGridPanel;

	[SerializeField]
	private RectTransform _cardUnEquipArea;

	[SerializeField]
	private CanvasGroup[] _bonusTooltips;

	private TerritoryBuilding _building;

	private ResourceTerritoryBuilding _resBuilding;

	private List<int> _assignedUnits;

	private readonly List<CardData> _cards;

	private bool _assignedUnitsChanged;

	private Tween _tooltipTween;

	public DraggableUnitCardGridPanel unitCardGridPanel => null;

	public DraggableCardBase<CardData> currentDraggingCard { get; set; }

	public static TerritoryUnitAssignPanel Instance => null;

	public void Show(TerritoryBuilding building)
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

	[AsyncStateMachine(typeof(_003COnSwapCard_003Ed__23))]
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

	public bool CanEquipImpl(CardData cardData)
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

	private void OnAddUnitItem(int index, CardData card, TerritoryDraggableUnitCard unitItem)
	{
	}

	private void ReloadBenefitText()
	{
	}

	public TerritoryBuildingData GetUnitAssignedBuilding(int unitId)
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

	[AsyncStateMachine(typeof(_003CSaveAssignedUnits_003Ed__38))]
	public void SaveAssignedUnits()
	{
	}

	public void OnClickAutoSelect()
	{
	}

	public void OnClickClear()
	{
	}

	public void OnClickBonusTooltip(int index)
	{
	}

	public bool IsAnyoneAssigned()
	{
		return false;
	}

	private bool Filter(CardData cardData)
	{
		return false;
	}
}
