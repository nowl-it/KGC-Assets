using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AlphaRaycaster;
using Awesomepiece.Model;
using Crystal;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class Scene_Territory : Scene_Base
{
	public enum Mode
	{
		Normal = 0,
		SelectBuildableArea = 1,
		ReplaceBuilding = 2
	}

	public struct BuildData
	{
		public int buildingId;

		public bool isStored;
	}

	public enum TerritoryType
	{
		Default = 0,
		TerritoryTycoon = 1
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CBuildBuilding_003Ed__100 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public Scene_Territory _003C_003E4__this;

		public int buildingId;

		public int posIndex;

		private UniTask<TerritoryBuildBuildingResponseModel>.Awaiter _003C_003Eu__1;

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
	private struct _003CCollectLabor_003Ed__121 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public int amount;

		public Scene_Territory _003C_003E4__this;

		private UniTask<TerritoryCollectLaborResponseModel>.Awaiter _003C_003Eu__1;

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
	private struct _003CCollectSkinToken_003Ed__122 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public int amount;

		private UniTask<TerritoryTycoonTokenResponseModel>.Awaiter _003C_003Eu__1;

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
	private struct _003CFetchInventory_003Ed__88 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public Scene_Territory _003C_003E4__this;

		private UniTask<InventoryResponseModel>.Awaiter _003C_003Eu__1;

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
	private struct _003CFetchPlayerInfo_003Ed__86 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		private UniTask<PlayerDataResponseModel>.Awaiter _003C_003Eu__1;

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
	private struct _003CFetchShop_003Ed__87 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		private UniTask<ShopResponseModel>.Awaiter _003C_003Eu__1;

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
	private struct _003CFetchTerritory_003Ed__89 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public Scene_Territory _003C_003E4__this;

		private UniTask<PlayerTerritoryResponseModel>.Awaiter _003C_003Eu__1;

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
	private struct _003CFetchTerritoryTycoon_003Ed__90 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public Scene_Territory _003C_003E4__this;

		private UniTask<PlayerSeasonalEventDataResponseModel>.Awaiter _003C_003Eu__1;

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
	private struct _003CHandleBuyTerritoryPass_003Ed__134 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public Scene_Territory _003C_003E4__this;

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
	private struct _003CRefreshBuildingData_003Ed__105 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder<bool> _003C_003Et__builder;

		public TerritoryBuildingData data;

		public Scene_Territory _003C_003E4__this;

		public Action<TerritoryBuildingData> completeCallback;

		private UniTask<TerritoryRefreshBuildingResponseModel>.Awaiter _003C_003Eu__1;

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
	private struct _003CRefreshBuildingDataImpl_003Ed__106 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public TerritoryBuildingData data;

		public TerritoryRefreshBuildingResponseModel model;

		public Scene_Territory _003C_003E4__this;

		public bool handleLevelSync;

		private TerritoryBuilding _003Cbuilding_003E5__2;

		private UniTask<TerritoryHuntingResponseModel>.Awaiter _003C_003Eu__1;

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
	private struct _003CTycoonCheckAttendance_003Ed__91 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public Scene_Territory _003C_003E4__this;

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
	private struct _003CUnStoreBuilding_003Ed__102 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public Scene_Territory _003C_003E4__this;

		public int buildingId;

		public int posIndex;

		private UniTask<TerritoryBuildingResponseModel>.Awaiter _003C_003Eu__1;

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

	public static Scene_Territory Instance;

	public global::AlphaRaycaster.AlphaRaycaster alphaRaycaster;

	[SerializeField]
	private Transform _popupHierachyIndexer;

	public ItemTooltipPanel itemTooltipPanel;

	[SerializeField]
	private GameObject _map;

	[SerializeField]
	private GameObject _buildingPrefab;

	[SerializeField]
	private GameObject _unitPrefab;

	[SerializeField]
	private SafeArea _safeArea;

	[SerializeField]
	private SafeArea _tutorialSafeArea;

	[SerializeField]
	private TerritoryTopPanel _topPanel;

	[SerializeField]
	private Text _passTimeText;

	public Transform gameRoot;

	private GameObject _background;

	public TerritoryUIPanel uiPanel;

	public TerritoryBuildingMenuBase buildingMenu;

	[SerializeField]
	private GameObject _backToNormalModeButton;

	[SerializeField]
	private GameObjectPool _fireworkObjectPool;

	private List<GameObject> _fireworkParticleList;

	public ArtifactInfoPanel artifactInfoPanel;

	private TerritoryBuildingInfoPanel _territoryBuildingInfoPanel;

	private TerritoryPassPanel _territoryPassPanel;

	private TerritoryBonusUnitTooltip _territoryBonusUnitTooltip;

	private TerritoryTycoonMissionPanel _territoryTycoonMissionPanel;

	private SpecialSeasonalEventShopPanel _specialSeasonalEventShopPanel;

	private SkinInfoPanel _skinPreviewPanel;

	private GachaNewUnitPanel _gachaNewUnitPanel;

	private TreasureGachaResultPanel _treasureGachaResultPanel;

	private Mode _mode;

	private List<BuildableArea> _buildableAreas;

	private TerritoryBuilding[] _buildings;

	public BuildData buildData;

	[NonSerialized]
	public BuildableArea selectedBuildableArea;

	public OutgameTutorialPanel outgameTutorialPanel;

	private TerritoryBuilding _selectedBuilding;

	private TerritoryBuildingMenuBase _selectedPanel;

	private Action<BuildableArea, TerritoryBuilding> _onClickBuilding;

	private readonly List<TerritoryUnit> _playerUnits;

	private readonly List<TerritoryUnit> _enemyUnits;

	private readonly List<(int buildingRootId, GameObject go)> _buildingPanels;

	private AudioObject _ambientAudio;

	private DateTime _lastTouchedAt;

	public static TerritoryType currentTerritoryType;

	public ConditionalGroup conditionalUIByTerritoryType;

	private bool _lastBuyPass;

	private static ulong _fireworkHash;

	public int popupHierachyIndex => 0;

	public int popupHierachyIndex_Top => 0;

	public TerritoryTopPanel topPanel => null;

	public GameObjectPool fireworkObjectPool => null;

	public TerritoryBuildingInfoPanel territoryBuildingInfoPanel => null;

	public TerritoryPassPanel territoryPassPanel => null;

	public TerritoryBonusUnitTooltip territoryBonusUnitTooltip => null;

	public TerritoryTycoonMissionPanel territoryTycoonMissionPanel => null;

	public SpecialSeasonalEventShopPanel specialSeasonalEventShopPanel => null;

	public SkinInfoPanel skinPreviewPanel => null;

	public GachaNewUnitPanel gachaNewUnitPanel => null;

	public TreasureGachaResultPanel treasureGachaResultPanel => null;

	public TerritoryBuilding selectedBuilding => null;

	protected override void Awake()
	{
	}

	private void OnDisable()
	{
	}

	private void OnDestroy()
	{
	}

	private void Start()
	{
	}

	protected override void OnResolutionChanged(float resolution)
	{
	}

	private void Init()
	{
	}

	private void LoadMap(string prefab)
	{
	}

	private void SetResolution()
	{
	}

	public void Reload()
	{
	}

	public void ReloadBuildings()
	{
	}

	public void ReloadAllPlayerUnits()
	{
	}

	protected new void Update()
	{
	}

	private void CheckPassEnd()
	{
	}

	[AsyncStateMachine(typeof(_003CFetchPlayerInfo_003Ed__86))]
	private void FetchPlayerInfo()
	{
	}

	[AsyncStateMachine(typeof(_003CFetchShop_003Ed__87))]
	private void FetchShop()
	{
	}

	[AsyncStateMachine(typeof(_003CFetchInventory_003Ed__88))]
	private void FetchInventory()
	{
	}

	[AsyncStateMachine(typeof(_003CFetchTerritory_003Ed__89))]
	public void FetchTerritory()
	{
	}

	[AsyncStateMachine(typeof(_003CFetchTerritoryTycoon_003Ed__90))]
	public void FetchTerritoryTycoon()
	{
	}

	[AsyncStateMachine(typeof(_003CTycoonCheckAttendance_003Ed__91))]
	private void TycoonCheckAttendance()
	{
	}

	public bool ModeIs(Mode mode)
	{
		return false;
	}

	public void SetNormalMode()
	{
	}

	public void SetMode(Mode mode)
	{
	}

	private void OnBeginEndNormalMode(bool set)
	{
	}

	private void OnBeginEndSelectBuildableAreaMode(bool set)
	{
	}

	private void OnBeginEndReplaceBuildingMode(bool set)
	{
	}

	public bool CheckMaxConstructionAtSameTimeLimit(Action onCanBuild)
	{
		return false;
	}

	public void BuildFromBuildData(BuildData buildData, BuildableArea buildableArea)
	{
	}

	[AsyncStateMachine(typeof(_003CBuildBuilding_003Ed__100))]
	private void BuildBuilding(int buildingId, int posIndex)
	{
	}

	public void HandleBuildOrUpgradeBuilding(int nextBuildingId)
	{
	}

	[AsyncStateMachine(typeof(_003CUnStoreBuilding_003Ed__102))]
	private void UnStoreBuilding(int buildingId, int posIndex)
	{
	}

	private TerritoryBuilding MakeBuilding(TerritoryBuildingData data)
	{
		return null;
	}

	public void RemoveBuilding(TerritoryBuilding building)
	{
	}

	[AsyncStateMachine(typeof(_003CRefreshBuildingData_003Ed__105))]
	public UniTask<bool> RefreshBuildingData(TerritoryBuildingData data, Action<TerritoryBuildingData> completeCallback = null)
	{
		return default(UniTask<bool>);
	}

	[AsyncStateMachine(typeof(_003CRefreshBuildingDataImpl_003Ed__106))]
	public void RefreshBuildingDataImpl(TerritoryBuildingData data, TerritoryRefreshBuildingResponseModel model, bool handleLevelSync = true)
	{
	}

	public void SelectBuilding(TerritoryBuilding building, bool showMenu = true)
	{
	}

	public TerritoryBuilding GetBuilding(int posIndex)
	{
		return null;
	}

	public TerritoryBuilding GetBuildingByRootId(int rootId)
	{
		return null;
	}

	public TerritoryBuilding FindBuilding(int rootBuildingId)
	{
		return null;
	}

	public void SetBuilding(TerritoryBuilding building, int posIndex)
	{
	}

	public BuildableArea GetBuildableArea(int posIndex)
	{
		return null;
	}

	public void TryInvokeOnClickBuilding(BuildableArea buildableArea, TerritoryBuilding building)
	{
	}

	public void ReloadCollectLaborMarkers()
	{
	}

	public void ReloadCollectSkinTokenMarkers()
	{
	}

	private void ReloadBuildingAllMarkers(TerritoryBuilding building)
	{
	}

	public TerritoryUnit MakeUnit(ResourceUnit resUnit, ResourceSkin resSkin, int team)
	{
		return null;
	}

	public TerritoryUnit GetUnit(int unitId, int team, bool checkParent = true)
	{
		return null;
	}

	public List<TerritoryUnit> GetAllUnits(int team)
	{
		return null;
	}

	public void RemoveUnit(TerritoryUnit unit)
	{
	}

	[AsyncStateMachine(typeof(_003CCollectLabor_003Ed__121))]
	public UniTask CollectLabor(int amount)
	{
		return default(UniTask);
	}

	[AsyncStateMachine(typeof(_003CCollectSkinToken_003Ed__122))]
	public UniTask CollectSkinToken(int amount)
	{
		return default(UniTask);
	}

	public int GetLaborCollectableUnitCount()
	{
		return 0;
	}

	public int GetSkinTokenCollectableUnitCount()
	{
		return 0;
	}

	public T GetBuildingPanel<T>(int buildingId) where T : TerritoryBuildingMenuBase
	{
		return null;
	}

	public T GetBuildingPanel<T>(ResourceTerritoryBuilding resBuilding) where T : TerritoryBuildingMenuBase
	{
		return null;
	}

	public bool TryGetBuildingPanel<T>(ResourceTerritoryBuilding resBuilding, out T panel) where T : TerritoryBuildingMenuBase
	{
		panel = null;
		return false;
	}

	public void OnClickTerritoryPass()
	{
	}

	public static float GetZ(float y, float x = 0f)
	{
		return 0f;
	}

	public override void OnAdditiveSceneChanged(bool isActiveScene)
	{
	}

	private void PlayTerritoryMusic()
	{
	}

	public void StopTerritoryMusic()
	{
	}

	private string GetTerritoryAudioID()
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CHandleBuyTerritoryPass_003Ed__134))]
	public void HandleBuyTerritoryPass()
	{
	}

	private string GetAmbientSoundByTownHallLevel(int townHallLevel)
	{
		return null;
	}

	private void SetUIVisible(bool visible)
	{
	}

	public static bool FilterEventBuildingType(ResourceTerritoryBuilding resBuilding)
	{
		return false;
	}

	public void TestSetLastLaborAt()
	{
	}

	public void ShowFireworkEffect()
	{
	}

	public void DestroyFireworkEffects()
	{
	}
}
