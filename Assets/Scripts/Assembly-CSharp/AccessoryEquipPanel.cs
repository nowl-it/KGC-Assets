using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Awesomepiece.Model;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class AccessoryEquipPanel : PopupPanel, IInventorySortFilterHandler
{
	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CCanEquipAccessoryCheck_003Ed__56 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder<MultiPriceButtonPopup.Response> _003C_003Et__builder;

		public List<AccessoryModel> accessories;

		public bool showAlert;

		private int _003CneedGold_003E5__2;

		private UniTask<MultiPriceButtonPopup.Response>.Awaiter _003C_003Eu__1;

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
	private struct _003COnClickEquip_003Ed__55 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public AccessoryEquipPanel _003C_003E4__this;

		private UniTask<bool>.Awaiter _003C_003Eu__1;

		private UniTask<MultiPriceButtonPopup.Response>.Awaiter _003C_003Eu__2;

		private UniTask<AccessoryResultResponseModel>.Awaiter _003C_003Eu__3;

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
	private AccessoryStatUI _originStatUIPrefab;

	[SerializeField]
	private RectTransform _originStatUIsRoot;

	private List<AccessoryStatUI> _originStatUIs;

	[SerializeField]
	private AccessoryStatUI _newStatUIPrefab;

	[SerializeField]
	private RectTransform _newStatUIsRoot;

	private List<AccessoryStatUI> _newStatUIs;

	[Space(20f)]
	[SerializeField]
	private ImageTextPair[] _originSynergyUI;

	[SerializeField]
	private AwesomeOutline[] _originSynergyBorder;

	[SerializeField]
	private ImageTextPair[] _newSynergyUI;

	[SerializeField]
	private AwesomeOutline[] _newSynergyBorder;

	[SerializeField]
	private AccessorySynergyToolTip _synergyToolTip;

	[SerializeField]
	[Space(20f)]
	private RectTransform _equipArea;

	[SerializeField]
	private Button _equipAreaExtendButton;

	private float _originEquipAreaTop;

	[SerializeField]
	private List<AccessoryUIItem> _accessories;

	[SerializeField]
	private List<Button> _accessoryRootButtons;

	[SerializeField]
	private List<GameObject> _slotEmptyIcons;

	[SerializeField]
	private RectTransform[] _selectedObjs;

	[SerializeField]
	private RectTransform _highlightObj;

	[SerializeField]
	private TabManager _accessoryCategoryTabManager;

	[SerializeField]
	[Space(20f)]
	private UIGridView _gridView;

	[Space(20f)]
	[SerializeField]
	private InventoryFilterComponent _filterComponent;

	[SerializeField]
	private GameObject _filterFilledObj;

	[SerializeField]
	private InventorySortComponent _sortComponent;

	[SerializeField]
	private GameObject _sortButtonDescIcon;

	[SerializeField]
	private Text _curSortCategoryText;

	private SortState _curSortState;

	private int _curSortIdx;

	private bool _curSortDesc;

	private InventorySortContent _lastSortContent;

	private int _curCategoryIdx;

	[SerializeField]
	private GameObject _accessorySimpleViewOnObj;

	private bool _accessorySimpleView;

	[Space(20f)]
	[SerializeField]
	private ConditionalGroup _equipButton;

	[SerializeField]
	private Price _equipButtonPrice;

	[SerializeField]
	private ConditionalGroup _equipOrChange;

	private List<AccessoryModel> _equippedAccessories;

	private AccessoryModel[] _selectAccessories;

	private CardData _cardData;

	private int _curAccessoryCategory;

	private List<AccessoryModel> _accessoryItems;

	private List<AccessoryModel> _curAccessoryItems;

	private Tween _extendTween;

	private Coroutine _updateCoolTimeTextCoroutine;

	private float _lastAccessoryEquipTime;

	private void OnEnable()
	{
	}

	public void Show(CardData cardData, int accessoryCategory)
	{
	}

	private void ResetSelectedAccessories()
	{
	}

	public void ToggleEquipAreaExtend()
	{
	}

	private void ExtendEquipArea(bool extend, bool tween = true)
	{
	}

	private void Reload()
	{
	}

	private void SetSelectedCategory(int category)
	{
	}

	private void ReloadAccessoryElement(int category, bool reset)
	{
	}

	private void ReloadGridView(int category, List<AccessoryModel> accessories)
	{
	}

	private List<AccessoryModel> GetNewEquipList()
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003COnClickEquip_003Ed__55))]
	public void OnClickEquip()
	{
	}

	[AsyncStateMachine(typeof(_003CCanEquipAccessoryCheck_003Ed__56))]
	private UniTask<MultiPriceButtonPopup.Response> CanEquipAccessoryCheck(List<AccessoryModel> accessories, bool showAlert)
	{
		return default(UniTask<MultiPriceButtonPopup.Response>);
	}

	public void DoFiltering()
	{
	}

	public InventoryFilterComponent GetActivatedFilterComponent()
	{
		return null;
	}

	public InventoryPanel.InventoryCategory GetInventoryCategory()
	{
		return default(InventoryPanel.InventoryCategory);
	}

	public T GetCurrentInventoryItems<T>()
	{
		return default(T);
	}

	public List<T> GetAllInventoryItems<T>()
	{
		return null;
	}

	public void HandleInitSortComponent()
	{
	}

	public void SortItemsByIdx(int tabIdx, int sortIdx)
	{
	}

	public InventorySortComponent GetActivatedSortComponent()
	{
		return null;
	}

	public void SetSortReverse()
	{
	}

	public void OnClickFilterButton()
	{
	}

	public void ToggleAccessorySimpleView()
	{
	}

	public override void OnClickClose()
	{
	}

	public override bool Close()
	{
		return false;
	}

	public void ShowStatPopup()
	{
	}
}
