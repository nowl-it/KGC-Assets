using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Awesomepiece.Model;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class WorldPanel : BaseLobbyPanel
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass249_0
	{
		public bool processed;

		public GameStartResponseModel ret;

		public bool isEventMode;

		internal void _003CGameStart_003Eb__0()
		{
		}

		internal void _003CGameStart_003Eb__2(bool yes)
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass250_0
	{
		public bool processed;

		internal void _003CStartRogueLike_003Eb__0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass267_0
	{
		public WorldPanel _003C_003E4__this;

		public string prefsValue;

		internal bool _003CAfterFetchDailyAttendance_003Eb__0()
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass278_0
	{
		public bool processed;

		public WorldPanel _003C_003E4__this;

		internal void _003CSimpleStartGame_003Eb__0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass278_1
	{
		public bool colosseumMatchProcessed;

		public bool matchCanceled;

		public _003C_003Ec__DisplayClass278_0 CS_0024_003C_003E8__locals1;

		internal void _003CSimpleStartGame_003Eb__3()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass278_2
	{
		public float lastFetchTime;

		internal bool _003CSimpleStartGame_003Eb__5()
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass281_0
	{
		public bool processed;

		internal void _003CStartEventMode_003Eb__0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CAfterFetchDailyAttendance_003Ed__267 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public WorldPanel _003C_003E4__this;

		public DailyAttendanceEventsResponseModel model;

		private _003C_003Ec__DisplayClass267_0 _003C_003E8__1;

		private int _003Cindex_003E5__2;

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
		public _003CAfterFetchDailyAttendance_003Ed__267(int _003C_003E1__state)
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

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CFetchGameSkipInformation_003Ed__320 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public bool reload;

		public WorldPanel _003C_003E4__this;

		private UniTask<GameSkipInfoResponseModel>.Awaiter _003C_003Eu__1;

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
	private struct _003CGameStart_003Ed__249 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public WorldPanel _003C_003E4__this;

		private _003C_003Ec__DisplayClass249_0 _003C_003E8__1;

		private int _003CcurrentTheme_003E5__2;

		private bool _003CisSeasonalEventMode_003E5__3;

		private int _003CthemeSeason_003E5__4;

		private bool _003CisHardMode_003E5__5;

		private int[] _003CeliteLevels_003E5__6;

		private int _003Cdifficulty_003E5__7;

		private UniTask<bool>.Awaiter _003C_003Eu__1;

		private UniTask.Awaiter _003C_003Eu__2;

		private UniTask<GameStartResponseModel>.Awaiter _003C_003Eu__3;

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
	private struct _003CRecoverLabor_003Ed__314 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public WorldPanel _003C_003E4__this;

		private UniTask<TerritoryRecoverLaborResponseModel>.Awaiter _003C_003Eu__1;

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
	private struct _003CSimpleStartGame_003Ed__278 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public WorldPanel _003C_003E4__this;

		public int theme;

		public bool isForceFreeRetry;

		private _003C_003Ec__DisplayClass278_0 _003C_003E8__1;

		private _003C_003Ec__DisplayClass278_2 _003C_003E8__2;

		private _003C_003Ec__DisplayClass278_1 _003C_003E8__3;

		private GameStartResponseModel _003Cret_003E5__2;

		private UniTask.Awaiter _003C_003Eu__1;

		private UniTask<GameStartResponseModel>.Awaiter _003C_003Eu__2;

		private int _003CretryCount_003E5__3;

		private ColosseumPlayerDataResponseModel _003CcolosseumRet_003E5__4;

		private UniTask<ColosseumPlayerDataResponseModel>.Awaiter _003C_003Eu__3;

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
	private struct _003CStartClanRaid_003Ed__285 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public bool isPracticeBattle;

		public int deckIdx;

		public int targetBoss;

		public int targetDifficulty;

		public WorldPanel _003C_003E4__this;

		private ClanRaidRetryInfo _003CretryInfo_003E5__2;

		private int _003ClastClanBoss_003E5__3;

		private int _003ClastClanHp_003E5__4;

		private TaskAwaiter _003C_003Eu__1;

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
	private struct _003CStartEventMode_003Ed__281 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public WorldPanel _003C_003E4__this;

		public int theme;

		public GameStartRequestModel model;

		private _003C_003Ec__DisplayClass281_0 _003C_003E8__1;

		private UniTask<GameStartResponseModel>.Awaiter _003C_003Eu__1;

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
	private struct _003CStartRogueLike_003Ed__250 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public WorldPanel _003C_003E4__this;

		private _003C_003Ec__DisplayClass250_0 _003C_003E8__1;

		private bool _003CpaidHeartAtThisFloor_003E5__2;

		private UniTask<StartRogueLikeFloorResponseModel>.Awaiter _003C_003Eu__1;

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

	public static WorldPanel Instance;

	[Space(20f)]
	[SerializeField]
	private PlayerProfile _playerProfile;

	private ProfilePanel _profilePanel;

	private ChangeProfilePanel _changeProfilePanel;

	[ComponentConnect]
	public Image passIcon;

	public Button passButton;

	public Text passLevel;

	public Text passLevel2;

	[ComponentConnect]
	public Gauge missionButtonGauge;

	public GameObject missionBadge;

	public Text missionBadgeText;

	public GetMoneyEffect getKeyEffect;

	public GetMoneyEffect getSpecialSeasonalTokenEffect;

	[ComponentConnect]
	public SeasonPassPanel seasonPassPanel;

	private static int _totalClearedPassMissionCount;

	private static int _totalReceivablePassRewardsCount;

	[Space(20f)]
	[ComponentConnect]
	public ConditionalRoot postButton;

	[ComponentConnect]
	public PostBoxPanel postBoxPanel;

	public Button missionButton;

	public Text missionTotalClearedMissionBadgeText;

	public ConditionalBase[] missionButtonClearedNotifyConditionals;

	public Text clanMissionTotalClearedMissionBadgeText;

	public ConditionalBase[] clanMissionButtonClearedNotifyConditionals;

	private MissionPanel_Base _missionPanelBase;

	private MissionPanel _missionPanel;

	private SettingsPanel _settingsPanel;

	[ComponentConnect]
	[Space(20f)]
	public RectTransform leftButtons;

	public GameObject bankButtonBadge;

	[ComponentConnect]
	public Button bankButton;

	private BankPanel _bankPanel;

	[ComponentConnect]
	public Button hotTimeEventButton;

	private HotTimePanel _hotTimePanel;

	private Dictionary<int, (Button, Text)> _godSkinPackageButtons;

	public Dictionary<int, PopupPanel> godSkinPackagePanels;

	[ComponentConnect]
	public Button firstPurchaseEventButton;

	private FirstPurchaseEventPanel _firstPurchaseEventPanel;

	[ComponentConnect]
	public Button newHeroPackButton;

	[ComponentConnect]
	public Image newHeroPackButtonIcon;

	private NewHeroPackPanel _newHeroPackPanel;

	[ComponentConnect]
	public Button firstStepPackageButton;

	[ComponentConnect]
	public Text firstStepPackageTimeLeft;

	[ComponentConnect]
	public GameObject firstStepPackageAlertButton;

	private FirstStepPackagePanel _firstStepPackagePanel;

	[ComponentConnect]
	public Button heroExpPackageButton;

	[ComponentConnect]
	public Image heroExpPackageButtonIcon;

	[ComponentConnect]
	public Text heroExpPackageButtonTimeLeft;

	[ComponentConnect]
	public Text heroExpPackageButtonBadgeText;

	private ShopItemModel _leastTimeLeftHeroExpPackageItem;

	private HeroExpPackagePanel _heroExpPackagePanel;

	[ComponentConnect]
	public Button[] rogueLikeBuildingPackageButton;

	[ComponentConnect]
	public Text rogueLikeBuildingPackageTimeLeft;

	[SerializeField]
	private RectTransform _godSkinPackageButtonsRoot;

	[SerializeField]
	private GameObject _customEventObject;

	[SerializeField]
	private Text _customEventUntilAt;

	[SerializeField]
	private Text _customEventTitle;

	private Dictionary<string, CustomEventPanel> _customEventPanels;

	[Space(20f)]
	public Button starterMissionButton;

	public Text starterMissionTotalClearedMissionBadgeText;

	public GameObject starterMissionStepMissionClearedMissionBadge;

	public ConditionalBase[] starterMissionButtonClearedNotifyConditionals;

	private StarterMissionPanel _starterMissionPanel;

	public GameObject journeyRewardCleardMissionBadge;

	public Button journeyRewardButton;

	private JourneyRewardPanel _journeyRewardPanel;

	public GameObject fourthYearEventBadge;

	public Button fourthYearEventButton;

	private FourthYearEventPanel _fourthYearEventPanel;

	public Button thirdHalfAnniversaryMissionButton;

	public Text thirdHalfAnniversaryMissionTotalClearedMissionBadgeText;

	private ThirdHalfAnniversaryMissionPanel _thirdHalfAnniversaryMissionPanel;

	public Button welcomeToReturnButton;

	public Text returnEventRemainTimeText;

	private WelcomeToReturnPanel _welcomeToReturnPanel;

	[ComponentConnect]
	public Button eventButton;

	[ComponentConnect]
	public Image tokenIcon;

	private SeasonalEventShopPanel _seasonalEventShopPanel;

	private SpecialSeasonalEventShopPanel _specialSeasonalEventShopPanel;

	private SkinInfoPanel _skinPreviewPanel;

	[Space(20f)]
	public GameObject gachaFreeBadge;

	public GameObject gachaNewBadge;

	private GachaShopPanel _gachaShopPanel;

	[ComponentConnect]
	public GameObject seasonPassBoosterCount;

	[ComponentConnect]
	public Text seasonPassBoosterCountText;

	[ComponentConnect]
	public Text seasonPassBoosterLeftTime;

	public GameObject seasonPassBoosterInfo;

	[SerializeField]
	private Button _territoryTycoonButton;

	public GameObject territoryTycoonBadge;

	[SerializeField]
	private Button _territoryButton;

	public GameObject territoryBadge;

	public GameObject openGameListButton;

	public GameObject openGameListButtonRewardAlertBadge;

	public Text openGameListButtonRewardAlertBadgeText;

	public GameListBox gameListBox;

	public ThemeSelectPanel themeSelectPanel;

	public RogueLikeStartPanel rogueLikeStartPanel;

	[SerializeField]
	private Button _streamingButton;

	private StreamingNoticePanel _streamingNoticePanel;

	[SerializeField]
	private Button _gameOverGuideButton;

	[SerializeField]
	private GameOverGuideObject _gameOverGuideObject;

	[Space(20f)]
	public Transform lobbySprites;

	public GameObject[] lobbyDeckParents;

	private GameObject[] lobbyDeckObjects;

	private string[] lobbyDeckUnitName;

	public GameObject newUnitPrefab;

	public GameObject[] messengers;

	public GameObject mrAlertUnit;

	public TODOListBadge todoListBadge;

	public TODOListPanel todoListPanel;

	private WebViewBasePanel _generalWebViewPanel;

	private WebViewNoticePanel _webViewNoticePanel;

	public Transform flagToDoListBadge;

	private ChangeFlagPanel _changeFlagPanel;

	[Space(20f)]
	private ArenaShopPanel _arenaShopPanel;

	private HardModeShopPanel _hardModeShopPanel;

	private DailyAttendanceEventPanel _dailyAttendanceEventPanel_Renew;

	private DailyAttendanceEventPanel_Multiple _dailyAttendanceEventPanel_Multiple;

	private ReturnDailyAttendanceEventPanel _returnDailyAttendanceEventPanel;

	private SkinInfoPanel _skinInfoPanel;

	private NewChapterPanel _newChapterPanel;

	private EventModePopup _eventModePopup;

	private SeasonalEventModePopup _seasonalEventModePopup;

	private BabelPanel _babelPanel;

	private bool _started;

	private static Vector3 ORIGIN_POS;

	private PvPMatchPanel _pvpMatchPanel;

	private DateTime _lastUpdateTime;

	public static readonly string[] themes;

	public Dictionary<string, GameObject> themePrefabDict;

	private Vector3 _mainPos;

	private Vector3 _subPos;

	private DateTime _recoverLaborCooltime;

	public ProfilePanel profilePanel => null;

	public ChangeProfilePanel changeProfilePanel => null;

	public static int totalClearedPassMissionCount => 0;

	public static int totalReceivablePassRewardsCount => 0;

	public MissionPanel_Base missionPanelBase => null;

	public MissionPanel missionPanel => null;

	public SettingsPanel settingsPanel => null;

	public BankPanel bankPanel => null;

	public HotTimePanel hotTimePanel => null;

	public FirstPurchaseEventPanel firstPurchaseEventPanel => null;

	public NewHeroPackPanel newHeroPackPanel => null;

	public FirstStepPackagePanel firstStepPackagePanel => null;

	public HeroExpPackagePanel heroExpPackagePanel => null;

	public StarterMissionPanel starterMissionPanel => null;

	public JourneyRewardPanel journeyRewardPanel => null;

	public FourthYearEventPanel fourthYearEventPanel => null;

	public ThirdHalfAnniversaryMissionPanel thirdHalfAnniversaryMissionPanel => null;

	public WelcomeToReturnPanel welcomeToReturnPanel => null;

	public SeasonalEventShopPanel seasonalEventShopPanel => null;

	public SpecialSeasonalEventShopPanel specialSeasonalEventShopPanel => null;

	public bool isSkinPreviewPanelInstantiated => false;

	public SkinInfoPanel skinPreviewPanel => null;

	public GachaShopPanel gachaShopPanel => null;

	public StreamingNoticePanel streamingNoticePanel => null;

	public WebViewBasePanel generalWebViewPanel => null;

	public WebViewNoticePanel webViewNoticePanel => null;

	public ChangeFlagPanel changeFlagPanel => null;

	public bool isArenaShopPanelInstantiated => false;

	public ArenaShopPanel arenaShopPanel => null;

	public HardModeShopPanel hardModeShopPanel => null;

	public DailyAttendanceEventPanel dailyAttendanceEventPanel_Renew => null;

	public DailyAttendanceEventPanel_Multiple dailyAttendanceEventPanel_Multiple => null;

	public ReturnDailyAttendanceEventPanel returnDailyDailyAttendanceEventPanel => null;

	public bool dailyAttendancePanelActive => false;

	public SkinInfoPanel skinInfoPanel => null;

	public NewChapterPanel newChapterPanel => null;

	public EventModePopup eventModePopup => null;

	public SeasonalEventModePopup seasonalEventModePopup => null;

	public BabelPanel babelPanel => null;

	public bool isStarting => false;

	public PvPMatchPanel pvpMatchPanel => null;

	public void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	public override void Init()
	{
	}

	private void Update()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public override void OnPanelEnabled()
	{
	}

	public override void OnPanelDisabled()
	{
	}

	public void Reload()
	{
	}

	private bool GetShowBankButtonBadge()
	{
		return false;
	}

	private void ReloadPlayCounts()
	{
	}

	private void ReloadSeasonPassEventBooster()
	{
	}

	public void ReloadGameOverGuide()
	{
	}

	public void OnClickGameOverGuideButton()
	{
	}

	public void ReloadTodoListBadge()
	{
	}

	private void ReloadHotTimeEvent()
	{
	}

	private void ReloadFirstStepPackage()
	{
	}

	private void ReloadHeroExpPackageTimeLimit()
	{
	}

	public void ReloadHeroExpPackageButton()
	{
	}

	public void ReloadMissionPanelClearedMissionCountBadge()
	{
	}

	public void ReloadClanMissionPanelClearedMissionCountBadge()
	{
	}

	public void ReloadStarterMissionPanelClearedMissionCountBadge()
	{
	}

	public void ReloadThirdHalfAnniversaryMissionPanelClearedMissionCountBadge()
	{
	}

	public void ReloadJourneyRewardPanelCanGetRewardBadge()
	{
	}

	private ShopItemModel GetLeastTimeLeftHeroExpPackageItem()
	{
		return null;
	}

	private void ReloadGodSkinPackageTimeLimit()
	{
	}

	private void ReloadRogueLikeBuildingPackageTimeLimit()
	{
	}

	private void ReloadReturnEventTimeLimit()
	{
	}

	public void ReloadGodSkinPackageButton()
	{
	}

	private bool GodSkinPackageButtonActive(int godSkinId)
	{
		return false;
	}

	public void ReloadRogueLikeBuildingPackageButton()
	{
	}

	public void ReloadFirstPurchaseEventButton()
	{
	}

	public void ReloadCustomEventButton()
	{
	}

	public void ShowCustomEventPanel(string eventName)
	{
	}

	public CustomEventPanel GetCustomEventPanel(string eventName)
	{
		return null;
	}

	public void ReloadInvasionRewardBadge()
	{
	}

	public void ReloadLobbyDeck()
	{
	}

	public void ReloadProfileIcon()
	{
	}

	public void OnClickColosseum()
	{
	}

	[AsyncStateMachine(typeof(_003CGameStart_003Ed__249))]
	public void GameStart()
	{
	}

	[AsyncStateMachine(typeof(_003CStartRogueLike_003Ed__250))]
	public void StartRogueLike()
	{
	}

	public void OnClickSettings()
	{
	}

	public void OnClickBank()
	{
	}

	public void OnClickNewHeroPack()
	{
	}

	public void OnClickFirstStepPackage()
	{
	}

	public void OnClickHotTime()
	{
	}

	public void OnClickHeroExpPackage()
	{
	}

	public void OnClickMission()
	{
	}

	public void OnClickStarterMission()
	{
	}

	public void OnClickThirdHalfAnniversaryMission()
	{
	}

	public void OnClickFourthYearEventButton()
	{
	}

	public void OnClickJourneyRewardButton()
	{
	}

	public void OnClickCafe()
	{
	}

	public void OnClickMyInfo()
	{
	}

	public void OnClickGachaShop()
	{
	}

	public void OnClickFlag()
	{
	}

	public void ShowChangeProfilePanel()
	{
	}

	[IteratorStateMachine(typeof(_003CAfterFetchDailyAttendance_003Ed__267))]
	public IEnumerator AfterFetchDailyAttendance(DailyAttendanceEventsResponseModel model)
	{
		return null;
	}

	public void ShowDailyAttendanceEventPanel(int eventId, int attendance)
	{
	}

	public void ReloadMissionBadge()
	{
	}

	public void ReloadPassGauge(bool showEffect = true)
	{
	}

	public void ReloadPostBadge()
	{
	}

	public void ReloadNewContentAlert()
	{
	}

	public void OnClickPostBox()
	{
	}

	public void OnClickEvent()
	{
	}

	public void OnClickPvPDeckSet(bool forceFreeRetry)
	{
	}

	[AsyncStateMachine(typeof(_003CSimpleStartGame_003Ed__278))]
	public void SimpleStartGame(int theme, bool isForceFreeRetry = false)
	{
	}

	public void OnClickPvPMatching(bool training)
	{
	}

	public void StartPvP(int targetDeck)
	{
	}

	[AsyncStateMachine(typeof(_003CStartEventMode_003Ed__281))]
	public void StartEventMode(int theme, GameStartRequestModel model)
	{
	}

	private bool HasOverBuilding()
	{
		return false;
	}

	public void OnClickSeasonPass()
	{
	}

	public void OnClickPassBoosterInfo()
	{
	}

	[AsyncStateMachine(typeof(_003CStartClanRaid_003Ed__285))]
	public void StartClanRaid(int deckIdx, bool isPracticeBattle = false, int targetBoss = -1, int targetDifficulty = -1)
	{
	}

	public void OnClickOpenGameListBox()
	{
	}

	public bool OpenInvasionTheme(int season, int theme, int hardTabIdx, int difficulty = -1)
	{
		return false;
	}

	public void OpenSelectEventMode()
	{
	}

	public void OpenEventMode(int idx)
	{
	}

	public void OpenSelectSeasonalEventMode()
	{
	}

	public void OpenSeasonEventMode(int idx)
	{
	}

	public bool OpenBabelStart()
	{
		return false;
	}

	public bool OpenRogueLikeStart()
	{
		return false;
	}

	public bool IsGameStartPopupOpened()
	{
		return false;
	}

	public void CloseGameStartPopup()
	{
	}

	public void OnClickMessenger()
	{
	}

	public void RefreshMissions()
	{
	}

	public void CheckMissionUseGold()
	{
	}

	public void CheckMissionUseCash()
	{
	}

	public void CheckMissionUseHeart()
	{
	}

	private void ReloadGachaFreeBadge()
	{
	}

	public void ReloadGachaNewBadge()
	{
	}

	public void Hide(bool hide)
	{
	}

	public void OnClickTerritoryButton()
	{
	}

	public void OnClickTerritoryTycoonButton()
	{
	}

	public void LoadTerritoryScene(Scene_Territory.TerritoryType type)
	{
	}

	public void OnClickGodSkinPackage(int godSkinId)
	{
	}

	private PopupPanel GetGodSkinPanel(int godSkinId)
	{
		return null;
	}

	public void OnClickFirstPurchaseEventPanel()
	{
	}

	private void ReloadTerritoryBadge()
	{
	}

	private void ReloadTerritoryTycoonButton()
	{
	}

	private void CheckLabor()
	{
	}

	[AsyncStateMachine(typeof(_003CRecoverLabor_003Ed__314))]
	private void RecoverLabor()
	{
	}

	public void OnClickWelcomeToReturnPanel()
	{
	}

	private void ShowPopupChain(List<ShopItemModel> shopItemModels)
	{
	}

	public GetMoneyEffect GetSpecialSeasonalTokenMoneyEffect(ResourceShopItem.SpecialSeasonalTokenType type)
	{
		return null;
	}

	public static bool HandleDeckBannedErrorCode(ResponseModel ret, out string errorMessage)
	{
		errorMessage = null;
		return false;
	}

	public void ShowStreamingNoticePanel()
	{
	}

	[AsyncStateMachine(typeof(_003CFetchGameSkipInformation_003Ed__320))]
	public UniTask FetchGameSkipInformation(bool reload = false)
	{
		return default(UniTask);
	}

	public void TestDeleteAllPrefs()
	{
	}
}
