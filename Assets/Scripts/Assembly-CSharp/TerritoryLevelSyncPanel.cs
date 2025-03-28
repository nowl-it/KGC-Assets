using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Awesomepiece.Model;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class TerritoryLevelSyncPanel : TerritoryBuildingMenuBase, IDraggableCardBaseHandler<CardData>
{
	public enum State
	{
		Info = 0,
		SelectSyncedUnit = 1
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003COnClickConfirm_003Ed__41 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public TerritoryLevelSyncPanel _003C_003E4__this;

		private int _003CchangedIdx_003E5__2;

		private UniTask<bool>.Awaiter _003C_003Eu__1;

		private UniTask.Awaiter _003C_003Eu__2;

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
	private struct _003COnSwapCard_003Ed__27 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

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
	[Space(20f)]
	private ConditionalGroup _stateConditional;

	[SerializeField]
	private GameObject _mainBgObject;

	[Header("InfoTop")]
	[SerializeField]
	private Text _syncLevel;

	[SerializeField]
	private ConditionalImage _syncPotentialBg;

	[SerializeField]
	private Image _buildingIcon;

	[SerializeField]
	[Header("InfoBottom")]
	private LayoutFitter _syncInfoItemLayout;

	[SerializeField]
	private GameObject _passPremiumBenefitObj;

	[Header("SelectBottom")]
	[SerializeField]
	private DraggableUnitCardGridPanel _unitCardGridPanel;

	[SerializeField]
	[Header("SelectTop")]
	private LevelSyncSelectedUnitPanel _selectedUnitPanel;

	private readonly List<TerritoryLevelSyncItem> _territoryLevelSyncItems;

	private State _state;

	private List<int> _syncedUnits;

	private bool _assignedUnitsChanged;

	private List<CardData> _cards;

	private int _selectedSlot;

	private const int NORMAL_POPUP_POSITION_Y = 100;

	private const int PREMIUM_POPUP_POSITION_Y = 270;

	public DraggableCardBase<CardData> currentDraggingCard { get; set; }

	public override void Show(TerritoryBuilding building)
	{
	}

	public void ReloadByState(bool checkMarkers = true)
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

	[AsyncStateMachine(typeof(_003COnSwapCard_003Ed__27))]
	public void OnSwapCard(DraggableCardBase<CardData> fromCard, DraggableCardBase<CardData> toCard, int fromIndex, int toIndex)
	{
	}

	public bool IsCardInUse(DraggableCardBase<CardData> card)
	{
		return false;
	}

	private bool IsCardInUseImpl(CardData cardData)
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

	public TerritoryBuildingData GetUnitAssignedBuilding(int unitId)
	{
		return null;
	}

	private void OnAddUnitItem(int index, CardData card, TerritoryDraggableUnitCard unitItem)
	{
	}

	private bool SyncedUnitFilter(CardData cardData)
	{
		return false;
	}

	private bool SyncedUnitFilter(CardData cardData, State state)
	{
		return false;
	}

	private void OnApplicationFocus(bool hasFocus)
	{
	}

	private void OnApplicationPause(bool hasFocus)
	{
	}

	[AsyncStateMachine(typeof(_003COnClickConfirm_003Ed__41))]
	public void OnClickConfirm()
	{
	}

	public void OnClickCloseOnSelectSyncedUnit()
	{
	}

	public void OnClickReleaseSyncedUnit(int slotIdx)
	{
	}

	public void OnClickSelectSyncedUnit(int slotIdx)
	{
	}

	public void SetState(State state)
	{
	}

	public int SortFunc(CardData a, CardData b)
	{
		return 0;
	}

	public void OnClickAutoSelect()
	{
	}

	public void OnClickClear()
	{
	}

	public override bool Close()
	{
		return false;
	}

	public void OnClickPassPremium()
	{
	}
}
