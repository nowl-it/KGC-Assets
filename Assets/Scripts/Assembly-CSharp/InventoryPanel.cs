using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AwesomeData.Encrypted;
using Awesomepiece.Model;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class InventoryPanel : PopupPanel, IInventorySortFilterHandler
{
	public enum InventoryCategory
	{
		ETC = 0,
		Artifact = 1,
		Treasure = 2,
		Accessory = 3
	}

	[Serializable]
	public class TreasureSkillUI
	{
		public Image skillIcon;

		public Text skillNameText;

		public Text skillDescText;
	}

	[Serializable]
	public class TreasureInformationGroup
	{
		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003COnClickState_003Ed__32 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public TreasureInformationGroup _003C_003E4__this;

			public int state;

			private UniTask<TreasureResultResponseModel>.Awaiter _003C_003Eu__1;

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

		[CompilerGenerated]
		private sealed class _003CTimeTextRoutine_003Ed__28 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public TreasureInformationGroup _003C_003E4__this;

			private WaitForSeconds _003Csecond_003E5__2;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CTimeTextRoutine_003Ed__28(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		public GameObject gameObject;

		public TreasureCardItem treasureCardItem;

		public Image unitPortrait;

		public Text unitName;

		public Text noUnitText;

		public TreasureSkillUI skillUI;

		public ClickOutsideClose skillDescTooltip;

		public ConditionalGroup stateCond;

		[SerializeField]
		private Text _nameText;

		[SerializeField]
		private Text _subNameText;

		[SerializeField]
		private GameObject _roleObj;

		[SerializeField]
		private Image _roleIcon;

		[SerializeField]
		private List<Image> _overcomeIcons;

		[SerializeField]
		private Button _skillDescButton;

		[SerializeField]
		private Button _informationButton;

		[SerializeField]
		private Button[] _stateButtons;

		[SerializeField]
		private ConditionalGroup _equipButton;

		[SerializeField]
		private Price _buttonUnlockPrice;

		[SerializeField]
		private Text _buttonTimeText;

		[SerializeField]
		private Image _buttonRoleIcon;

		[SerializeField]
		private Text _buttonRoleText;

		[NonSerialized]
		public int originUnit;

		private Action<int> _callback;

		private TreasureModel _treasure;

		private Coroutine _timeTextCoroutine;

		private bool _stateProcessing;

		public void Init(Action<int> callback, int originUnit)
		{
		}

		public void Reload()
		{
		}

		public void Set(TreasureModel treasure)
		{
		}

		[IteratorStateMachine(typeof(_003CTimeTextRoutine_003Ed__28))]
		private IEnumerator TimeTextRoutine()
		{
			return null;
		}

		public void OnClickSkillDesc()
		{
		}

		private void OnClickInformation()
		{
		}

		[AsyncStateMachine(typeof(_003COnClickState_003Ed__32))]
		private void OnClickState(int state)
		{
		}

		public void Equip()
		{
		}

		public void Close()
		{
		}
	}

	[Serializable]
	public class InventoryCountPanel
	{
		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003COnClickConfirm_003Ed__22 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public bool cancel;

			public InventoryCountPanel _003C_003E4__this;

			private UniTask<PlayerInventoryCountResponseModel>.Awaiter _003C_003Eu__1;

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

		public GameObject gameObject;

		public Text titleText;

		public Text descText;

		public Text addCountText;

		public Button minusCountButton;

		public Text minusCountText;

		public Button plusCountButton;

		public Text plusCountText;

		[FormerlySerializedAs("amountSlider")]
		public Slider countSlider;

		public Price price;

		public Button yesButton;

		private EncryptedInt _curCount;

		private EncryptedInt _baseCount;

		private EncryptedInt _addCount;

		private EncryptedInt _maxCount;

		private EncryptedInt _cashPrice;

		private EncryptedInt _curAddCount;

		private string _inventoryTypeStr;

		public void Set(InventoryCategory inventoryCategory)
		{
		}

		public void OnClickAmount(int idx)
		{
		}

		public void SetCount(int count)
		{
		}

		private void Reload()
		{
		}

		[AsyncStateMachine(typeof(_003COnClickConfirm_003Ed__22))]
		public void OnClickConfirm(bool cancel)
		{
		}
	}

	public abstract class FilterSaveDataBase
	{
		internal string key;

		public void Save()
		{
		}
	}

	[Serializable]
	public class ETCFilterSaveData : FilterSaveDataBase
	{
		public bool[] etcFilter_0;
	}

	[Serializable]
	public class ArtifactFilterSaveData : FilterSaveDataBase
	{
		public bool[] artifactFilter_0;

		public bool[] artifactFilter_1;
	}

	[Serializable]
	public class TreasureFilterSaveData : FilterSaveDataBase
	{
		public bool[] treasureFilter_0;

		public bool[] treasureFilter_1;

		public bool[] treasureToggleFilter;
	}

	[Serializable]
	public class AccessoryFilterSaveData : FilterSaveDataBase
	{
		public bool[] accessoryFilter_Multi_0_0;

		public bool[] accessoryFilter_Multi_0_1;

		public bool[] accessoryFilter_Single_1_0;

		public bool[] accessoryFilter_Single_1_1;

		public bool[] accessoryFilter_Single_1_2;

		public bool[] accessoryFilter_Single_1_3;

		public bool[] accessoryToggleFilter;
	}

	[Serializable]
	public class AccessoryDismantleFilterSaveData : FilterSaveDataBase
	{
		public bool[] accessoryFilter_Multi_0_0;

		public bool[] accessoryFilter_Multi_0_1;

		public bool[] accessoryFilter_Multi_0_2;

		public bool[] accessoryFilter_Multi_1_0;

		public bool[] accessoryFilter_Multi_1_1;

		public bool[] accessoryFilter_Multi_1_2;

		public bool[] accessoryFilter_Multi_1_3;
	}

	[Serializable]
	public class InventoryFilterSaveData
	{
		private ETCFilterSaveData _etcFilterData;

		private ArtifactFilterSaveData _artifactFilterData;

		private ArtifactFilterSaveData _artifactDismantleFilterData;

		private TreasureFilterSaveData _treasureFilterData;

		private TreasureFilterSaveData _treasureDismantleFilterData;

		private AccessoryFilterSaveData _accFilterData;

		private AccessoryFilterSaveData _accEquipFilterData;

		private AccessoryDismantleFilterSaveData[] _accDismantleFilterData;

		private int _accDismantleFilterPreset;

		public ETCFilterSaveData etcFilterData => null;

		public ArtifactFilterSaveData artifactFilterData => null;

		public ArtifactFilterSaveData artifactDismantleFilterData => null;

		public TreasureFilterSaveData treasureFilterData => null;

		public TreasureFilterSaveData treasureDismantleFilterData => null;

		public AccessoryFilterSaveData accFilterData => null;

		public AccessoryFilterSaveData accEquipFilterData => null;

		public AccessoryDismantleFilterSaveData[] accDismantleFilterData => null;

		public int accDismantleFilterPreset
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CGetDismantleAmount_003Ed__146 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder<(int count, bool isCanceled)> _003C_003Et__builder;

		public InventoryPanel _003C_003E4__this;

		public InventoryPanelItem item;

		public int curAmount;

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

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003COnClickDismantle_003Ed__130 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public InventoryPanel _003C_003E4__this;

		private Dictionary<int, int> _003CrewardItems_003E5__2;

		private List<ArtifactModel> _003Cartifacts_003E5__3;

		private UniTask<bool>.Awaiter _003C_003Eu__1;

		private UniTask<ArtifactResultResponseModel>.Awaiter _003C_003Eu__2;

		private UniTask.Awaiter _003C_003Eu__3;

		private List<int> _003Ctreasures_003E5__4;

		private UniTask<TreasureResultResponseModel>.Awaiter _003C_003Eu__4;

		private AccessoryResultResponseModel _003Cret_003E5__5;

		private UniTask<(Dictionary<int, int>, AccessoryResultResponseModel)>.Awaiter _003C_003Eu__5;

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
	private struct _003CTestAddAccessory_003Ed__192 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public InventoryPanel _003C_003E4__this;

		private UniTask<AccessoryResultResponseModel>.Awaiter _003C_003Eu__1;

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
	private struct _003CTestAddAllConsumable_003Ed__193 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		private UniTask<ResponseModel>.Awaiter _003C_003Eu__1;

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
	private struct _003CTestAddTreasure_003Ed__189 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public InventoryPanel _003C_003E4__this;

		private UniTask<TreasureResultResponseModel>.Awaiter _003C_003Eu__1;

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

	public static string[] ETCCategories;

	public static List<string[]> ArtifactCategories;

	public static List<string[]> TreasureCategories;

	public static bool IsDismantleFilter;

	public static string[] AccessoryMainStats;

	public static string[] AccessorySubStats;

	public const int ACCESSORY_SCORE_BASE = 1200;

	public const int ACCESSORY_SCORE_INTERVAL = 200;

	[NonSerialized]
	public InventoryCategory inventoryCategory;

	[NonSerialized]
	public int curAccType;

	[SerializeField]
	[Space(20f)]
	private Text _titleText;

	[SerializeField]
	private Image _bgImage;

	[SerializeField]
	private TabManager _categoryTabManager;

	[SerializeField]
	private GameObject _categoryTabsRoot;

	[SerializeField]
	private UIGridView[] _elementGrids;

	[FormerlySerializedAs("_inventoryBox")]
	[SerializeField]
	private RectTransform _viewport;

	[SerializeField]
	private InventoryItemTooltipPanel _inventoryTooltipPanel;

	[SerializeField]
	[Space(20f)]
	private InventoryFilterComponent _inventoryFilterComponent;

	[SerializeField]
	private InventorySortComponent _sortComponent;

	[SerializeField]
	private Text[] _curSortCategoryTexts;

	private SortState _curSortState;

	private SortState[] _sortStates;

	private int _curSortIdx;

	private bool _curSortDesc;

	private InventorySortContent _lastSortContent;

	private InventorySortContent _lastAccessorySortContent;

	[SerializeField]
	[Space(20f)]
	private GameObject _selectDismantleAmountPanel;

	[SerializeField]
	private Slider _selectDismantleAmountSlider;

	[SerializeField]
	private Text _selectDismantleAmountText;

	[SerializeField]
	private RewardPopup _dismantleConfirmPopup;

	[SerializeField]
	private InventoryFilterComponent _dismantleFilterComponent;

	[SerializeField]
	private InventoryFilterComponent _dismantleAccessoryFilterComponent;

	[SerializeField]
	private TabManager _dismantleAccessoryFilterPresetManager;

	[SerializeField]
	private GameObject _dismantleFilterFilledObj;

	[NonSerialized]
	public bool isDismantleMode;

	[NonSerialized]
	public Dictionary<int, int> artifactDismantleInfo;

	[NonSerialized]
	public HashSet<int> treasureDismantleInfo;

	[NonSerialized]
	public HashSet<int> accessoryDismantleInfo;

	[SerializeField]
	private ConditionalGroup _dismantleConfirmButton;

	[Space(20f)]
	[SerializeField]
	private GameObject _bottomTab;

	[SerializeField]
	private GameObject _bottomDismantleTab;

	[SerializeField]
	private Button _dismantleButton;

	[SerializeField]
	private GameObject[] _filterFilledObjs;

	[SerializeField]
	private Button[] _inventoryCountButtons;

	[SerializeField]
	private Text[] _inventoryCountTexts;

	[SerializeField]
	private Text _dismantleAmountText;

	[SerializeField]
	private GameObject[] _filterRefreshButtons;

	[SerializeField]
	private Text[] _sortButtonIcons;

	[Space(20f)]
	[SerializeField]
	private TreasureInformationGroup _treasureInformationGroup;

	[SerializeField]
	[Space(20f)]
	private TabManager _accessoryCategoryManager;

	[SerializeField]
	private InventoryFilterComponent _accessoryFilterComponent;

	[SerializeField]
	private InventorySortComponent _accessorySortComponent;

	[SerializeField]
	private GameObject _accessorySimpleViewOnObj;

	public bool accessorySimpleView;

	[SerializeField]
	private ConditionalGroup _accessorySelectButton;

	[SerializeField]
	private Button[] _toTopButton;

	[SerializeField]
	private Button[] _toBottomButton;

	[Space(20f)]
	[SerializeField]
	private InventoryCountPanel _inventoryCountPanel;

	[SerializeField]
	private GetMoneyEffect _moneyEffectPrefab;

	[SerializeField]
	private RectTransform _moneyEffectArea;

	private List<ETCItemModel> _etcItems;

	private List<ArtifactModel> _artifactItems;

	private List<TreasureModel> _treasureItems;

	private List<AccessoryModel> _accessoryItems;

	private object _currentInventoryItems;

	private List<InventoryPanelItem> _dismantleRewardItems;

	private List<GetMoneyEffect> _getMoneyEffects;

	private int _lastSelectedTabIdx;

	private bool _forceReload;

	private AccessoryModel _lastSelectedAccessory;

	private bool _callFromDismantleFilter;

	private bool _dismantleAmountCanceled;

	private bool _dismantleAmountSelected;

	private EncryptedInt _dismantleAmount;

	private EncryptedInt _dismantleOwnAmount;

	private int _originUnit;

	private bool _showingByEquipTreasure;

	private TreasureModel _lastSelectedTreasure;

	private TreasureModel _originEquippedTreasure;

	private bool _showingBySelectAccessory;

	private Action<AccessoryModel> _selectAccessoryCallback;

	[SerializeField]
	private InputField _testTreasureIDInput;

	[SerializeField]
	private InputField _testTreasureCountInput;

	[SerializeField]
	private InputField _testAccessoryCountInput;

	[SerializeField]
	private InputField _synergyInput;

	public static InventoryFilterSaveData FilterSaveData;

	public static InventoryPanel Instance => null;

	public TreasureInformationGroup treasureInformationGroup => null;

	public UIGridView accessoryItemView => null;

	public object currentInventoryItems => null;

	public bool showingByEquipTreasure => false;

	public static bool ETCCategoryFilter(object obj, int idx)
	{
		return false;
	}

	public static bool ArtifactTypeFilter(object obj, int idx)
	{
		return false;
	}

	public static bool ArtifactFromTypeFilter(object obj, int idx)
	{
		return false;
	}

	public static bool TreasureLevelFilter(object obj, int idx)
	{
		return false;
	}

	public static bool TreasureRarityFilter(object obj, int idx)
	{
		return false;
	}

	public static bool TreasureStateToggleFilter(object obj)
	{
		return false;
	}

	public static bool TreasureMaxLevelToggleFilter(object obj)
	{
		return false;
	}

	public static bool TreasureEquippedToggleFilter(object obj)
	{
		return false;
	}

	public static bool AccessoryRarityFilter(object obj, int idx)
	{
		return false;
	}

	public static bool AccessoryLevelFilter(object obj, int idx)
	{
		return false;
	}

	public static bool AccessorySynergyFilter(object obj, int idx)
	{
		return false;
	}

	public static bool AccessoryMainStatFilter(object obj, int idx)
	{
		return false;
	}

	public static bool AccessoryContainsSubStatFilter(object obj, int idx)
	{
		return false;
	}

	public static bool AccessoryExceptSubStatFilter(object obj, int idx)
	{
		return false;
	}

	public static bool AccessoryScoreFilter(object obj, int idx)
	{
		return false;
	}

	public static bool AccessoryStateToggleFilter(object obj)
	{
		return false;
	}

	public static bool AccessoryMaxLevelToggleFilter(object obj)
	{
		return false;
	}

	public static bool AccessoryEquippedToggleFilter(object obj)
	{
		return false;
	}

	private void ForceReloadCategory_Artifact()
	{
	}

	private void ForceReloadCategory_Treasure()
	{
	}

	private void ForceReloadCategory_Accessory()
	{
	}

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void ShootGetMoneyEffects(List<InventoryItem> inventories)
	{
	}

	public GetMoneyEffect GetMoneyEffect()
	{
		return null;
	}

	public void ForceReloadCategory(InventoryCategory category)
	{
	}

	public void Show(int tab = 0)
	{
	}

	private void ReloadInventoryCountTexts()
	{
	}

	private void OnClickTab(int idx)
	{
	}

	public void Reload(int idx)
	{
	}

	public void OnClickInventoryItem(InventoryPanelItem panelItem)
	{
	}

	private List<T> SetCurrentInventoryItems<T>(List<T> elements = null)
	{
		return null;
	}

	public void SetGridView<T>(List<T> elements = null)
	{
	}

	public UIGridView GetCurrentGrid()
	{
		return null;
	}

	public void ForEachCurrentElement(Action<InventoryPanelItem> action)
	{
	}

	public void HandleInitSortComponent()
	{
	}

	public static void SetSortComponent(IInventorySortFilterHandler handler, SortState[] sortStates, int tabIdx, ref SortState curSortState, bool doSort = true)
	{
	}

	public void SortItemsByIdx(int tabIdx, int sortIdx)
	{
	}

	public void SetSortReverse()
	{
	}

	public void OnClickFilterButton()
	{
	}

	public static void SetFilterComponent(IInventorySortFilterHandler handler, InventoryFilterComponent filterComponent, bool dismantleFilter = false)
	{
	}

	private void ReloadDismantleFilledState()
	{
	}

	public void DoDismantleFiltering()
	{
	}

	public void DoFiltering()
	{
	}

	public void OnClickRefreshFilter()
	{
	}

	public void ShowNextArtifact(DraggableArtifactCard artifactCard, bool next)
	{
	}

	public InventoryPanelItem GetFirstItem()
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003COnClickDismantle_003Ed__130))]
	public void OnClickDismantle()
	{
	}

	public void OnClickOutsideDuringDismantle()
	{
	}

	public void ReloadViewportSize()
	{
	}

	public void OnClickDismantleStart()
	{
	}

	public void OnClickDismantleEnd()
	{
	}

	private void DismantleEndImpl()
	{
	}

	public void OnClickDismantleFilter()
	{
	}

	private void OnClickAccessoryDismantlePreset(int idx)
	{
	}

	private void ReloadBottomTab()
	{
	}

	private void ClampFilterPanelPos(RectTransform tr)
	{
	}

	private void InitToTopBottomButtons(UIGridView elementGrid)
	{
	}

	private void ReloadToTopBottomButtons(ScrollRect scroll)
	{
	}

	[AsyncStateMachine(typeof(_003CGetDismantleAmount_003Ed__146))]
	public UniTask<(int, bool)> GetDismantleAmount(InventoryPanelItem item, int curAmount)
	{
		return default(UniTask<(int, bool)>);
	}

	public void SetDismantleAmount(int index = 0)
	{
	}

	public void SetDismantleAmountHard(bool max)
	{
	}

	public void OnClickDismantleAmountClose(bool select)
	{
	}

	public void ReloadDismantleAmountText()
	{
	}

	public void ShowTreasureEquipPanel(Action<int> callback, TreasureModel treasure, int originUnit)
	{
	}

	public void CloseTreasureInformation()
	{
	}

	public void SetTreasureInformation(bool show, TreasureModel treasure = null)
	{
	}

	private void ReloadAccessory(int type)
	{
	}

	public void ToggleAccessorySimpleView()
	{
	}

	public void ShowSelectAccessoryPanel(Action<AccessoryModel> callback)
	{
	}

	public void OnClickSelectAccessory()
	{
	}

	public List<ETCItemModel> GetETCItems()
	{
		return null;
	}

	public List<ArtifactModel> GetArtifactItems()
	{
		return null;
	}

	public List<TreasureModel> GetTreasureItems()
	{
		return null;
	}

	public List<AccessoryModel> GetAccessoryItems(int type = 0)
	{
		return null;
	}

	private void SetETCItem(int idx, GameObject go, List<ETCItemModel> etcItems)
	{
	}

	private void SetArtifactItem(int idx, GameObject go, List<ArtifactModel> artifactItems, ScrollRect scrollRect)
	{
	}

	private void SetTreasureItem(int idx, GameObject go, List<TreasureModel> treasureItems)
	{
	}

	private void SetAccessoryItem(int idx, GameObject go, List<AccessoryModel> accessoryItems)
	{
	}

	public override bool Close()
	{
		return false;
	}

	public InventoryCategory GetInventoryCategory()
	{
		return default(InventoryCategory);
	}

	public T GetCurrentInventoryItems<T>()
	{
		return default(T);
	}

	public List<T> GetAllInventoryItems<T>()
	{
		return null;
	}

	public InventoryFilterComponent GetActivatedFilterComponent()
	{
		return null;
	}

	public InventorySortComponent GetActivatedSortComponent()
	{
		return null;
	}

	public bool InventoryMaxCountIsMax()
	{
		return false;
	}

	public void OnClickInventoryCountPanel()
	{
	}

	public void OnClickInventoryCount(int idx)
	{
	}

	public void OnInventoryCountSliderChanged(Slider slider)
	{
	}

	public void OnClickInventoryCountConfirm(bool cancel)
	{
	}

	public void ScrollTo(bool top)
	{
	}

	public override void OnClickClose()
	{
	}

	[AsyncStateMachine(typeof(_003CTestAddTreasure_003Ed__189))]
	public void TestAddTreasure()
	{
	}

	[AsyncStateMachine(typeof(_003CTestAddAccessory_003Ed__192))]
	public void TestAddAccessory()
	{
	}

	[AsyncStateMachine(typeof(_003CTestAddAllConsumable_003Ed__193))]
	public void TestAddAllConsumable()
	{
	}

	private static T Load<T>(string key) where T : FilterSaveDataBase, new()
	{
		return null;
	}

	private static T[] Load<T>(string key, int count) where T : FilterSaveDataBase, new()
	{
		return null;
	}

	public static void Save<T>(string key, T data)
	{
	}
}
