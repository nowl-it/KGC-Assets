using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AwesomeData.Encrypted;
using Crystal;
using Cysharp.Threading.Tasks;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class MainUI : MonoBehaviour, TouchListener
{
	public enum StartButtonState
	{
		StartBattle = 0,
		RogueLikeStartBattle = 1,
		RogueLikeShowLevelGenerator = 2,
		ColosseumReady = 3,
		ColosseumWaiting = 4
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003COnClickStart_003Ed__211 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public MainUI _003C_003E4__this;

		private UniTask<bool>.Awaiter _003C_003Eu__1;

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
	private struct _003COnClickUpgradeSlot_003Ed__253 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public MainUI _003C_003E4__this;

		private UniTask<bool>.Awaiter _003C_003Eu__1;

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

	public static MainUI Instance;

	[Header("Dev 관련")]
	[Space(10f)]
	public GameObject testArea;

	[ComponentConnect]
	public GameObject devMenu;

	[ComponentConnect]
	public GameObject devRogueLikeMenu;

	[ComponentConnect]
	public GameObject devRogueLikeUIToggle;

	[ComponentConnect]
	public GameObject devColosseumMenu;

	[ComponentConnect]
	public GameObject devColosseumUIToggle;

	[ComponentConnect]
	public GameObject devStatPanelUIToggle;

	[ComponentConnect]
	public GameObject devEnemyItemReserveUIToggle;

	[ComponentConnect]
	public GameObject devThemeObserverMenu;

	[ComponentConnect]
	public DevColosseumItemPanel devColosseumItemPanel;

	[ComponentConnect]
	public DevThemeObserverPanel devThemeObserverPanel;

	[ComponentConnect]
	public Button devMenuToggle;

	[ComponentConnect]
	public DevOptionPanel devOptionPanel;

	[ComponentConnect]
	public DevDeckPanel devDeckPanel;

	[ComponentConnect]
	public DevItemPanel devItemPanel;

	[ComponentConnect]
	public DevItemPanel_2 devItemPanel_2;

	[ComponentConnect]
	public DevBuildingPanel devBuildingPanel;

	[ComponentConnect]
	public DevClanRaidPanel devClanRaidPanel;

	[ComponentConnect]
	public DevSummonPanel devSummonPanel;

	[ComponentConnect]
	public DevItemSummonPanel devItemSummonPanel;

	[ComponentConnect]
	public LocalePanel localePanel;

	[ComponentConnect]
	public Text devOvertimeText;

	[ComponentConnect]
	public Text devTestTimeLimitText;

	[Space(20f)]
	public Canvas canvasOverlay;

	[GetComponent]
	public RectTransform rectTransform;

	[GetComponent]
	public CanvasScaler canvasScaler;

	[ComponentConnect]
	public IconGauge hpGauge;

	[ComponentConnect]
	public Text goldText;

	[ComponentConnect]
	public Text unitCountText;

	public UnitInfoPanel unitInfoPanel;

	public AdvancedUnitInfoPanel advancedUnitInfoPanel;

	[ComponentConnect]
	public ItemInfoPanel itemInfoPanel;

	public RogueLikeItemInfoPanel rogueLikeItemInfoPanel;

	[ComponentConnect]
	public CenterText seasonalEventCenterText;

	[ComponentConnect]
	public CenterText centerText;

	public Animator[] trumpets;

	[ComponentConnect]
	public CenterText goldRewardText;

	public CenterText[] itemRewardText;

	[ComponentConnect]
	public GameOverPanel gameOverPanel;

	[ComponentConnect]
	public PvPDeckSetGameOverPanel pvpDeckSetGameoverPanel;

	[ComponentConnect]
	public PvPGameOverPanel pvpGameOverPanel;

	[ComponentConnect]
	public InputPopup inputPopup;

	[ComponentConnect]
	public GameObject blurMask;

	[ComponentConnect]
	public GameObject bossTitle;

	[ComponentConnect]
	public Text bossTitleMainName;

	[ComponentConnect]
	public Text bossTitleSubname;

	[ComponentConnect]
	public Image bossTitleEffect;

	[ComponentConnect]
	public RogueLikeMissionPopupPanel rogueLikeMissionPopupPanel;

	private BabelGameOverPanel _babelGameOverPanel;

	private ClanRaidGameOverPanel _clanRaidGameOverPanel;

	public GameObject sellArea;

	public Image sellPoint;

	public GameObject sellPointHighlight;

	public Text sellAreaText;

	public Image sellManyPoint;

	public GameObject sellManyPointHighlight;

	public Text sellManyAreaText;

	public GameObject sellAreaSmall;

	public Image sellPointSmall;

	public GameObject sellPointSmallHighlight;

	public Text sellAreaTextSmall;

	public Image sellManyPointSmall;

	public GameObject sellManyPointSmallHighlight;

	public Text sellManyAreaTextSmall;

	public GameObject sellAreaBig;

	public Image sellPointBig;

	public GameObject sellPointBigHighlight;

	public Text sellAreaTextBig;

	public Image sellManyPointBig;

	public GameObject sellManyPointBigHighlight;

	public Text sellManyAreaTextBig;

	public List<GameObject> sellManyAreaActiveObjects;

	public List<GameObject> sellManyAreaInActiveObjects;

	[ComponentConnect]
	public DealMeterPanel dealMeterPanel;

	[ComponentConnect]
	public SafeArea safeArea;

	[ComponentConnect]
	public SafeArea canvasOverlaySafeArea;

	[ComponentConnect]
	public Button startButton;

	[ComponentConnect]
	public ConditionalGroup startButtonStateConditionals;

	[ComponentConnect]
	public Text startButtonText;

	private StartButtonState _startButtonState;

	[ComponentConnect]
	public Button randomHeroButton;

	[ComponentConnect]
	public Text randomHeroCost;

	[ComponentConnect]
	public Button randomItemButton;

	[ComponentConnect]
	public Text randomItemCost;

	[ComponentConnect]
	public Button upgradeSlotButton;

	[ComponentConnect]
	public Text upgradeSlotCost;

	public Image upgradeSlotWarningImage;

	[ComponentConnect]
	public Button randomHeroLevelUpButton;

	[ComponentConnect]
	public Text randomHeroLevelUpCost;

	[ComponentConnect]
	public RectTransform bossHpBarsRoot;

	public BossHpBar bossHpBarGameObject;

	[ComponentConnect]
	public List<BossHpBar> bossHpBar;

	[ComponentConnect]
	public CanvasGroup loadingPanel;

	[ComponentConnect]
	public Image black;

	[ComponentConnect]
	public SelectItemPanel selectItemPanel;

	[ComponentConnect]
	public RevivePanel revivePanel;

	[ComponentConnect]
	public DevilPanel devilPanel;

	[ComponentConnect]
	public MerchantPanel merchantPanel;

	[ComponentConnect]
	public RandomItemPanel randomItemPanel;

	public EventRandomItemsPanel eventRandomItemsPanel;

	public Queue<Action> popupEventQueue;

	[ComponentConnect("BasePanel", false)]
	public RectTransform basePanelTransform;

	[ComponentConnect("BasePanel", false)]
	public Image basePanelBG;

	[ComponentConnect]
	public BasePanel basePanel;

	public RogueLikeBasePanel rogueLikeBasePanel;

	[ComponentConnect]
	public IngameTutorialPanel tutorialPanel;

	[ComponentConnect]
	public Button pauseButton;

	[ComponentConnect]
	public Button tutorialPauseButton;

	[ComponentConnect]
	public PausePanel pausePanel;

	[ComponentConnect]
	public PausePanel skipTutorialPanel;

	[ComponentConnect]
	public Animator battleAnim;

	[ComponentConnect]
	public GameObject restRetryPanel;

	[ComponentConnect]
	public Text gameCompleteError;

	[ComponentConnect]
	public Popup popup;

	[ComponentConnect]
	public GameObject rankingTimer;

	public Button rankingSkipButton;

	public Text rankingTimerTextLeft;

	public Text rankingTimerTextRight;

	public Text rankingTimerTextCenter;

	[ComponentConnect]
	public GameObject rankingMeter;

	[ComponentConnect]
	public Text rankingMeterText;

	public GameObject timeScorePanel;

	public Text timeScorePanelScoreText;

	public Text timeScorePanelScoreEffectText;

	public Image timeScorePanelTimeBarGauge;

	[ComponentConnect]
	public GameObject startTimer;

	public Text startTimerText;

	[ComponentConnect]
	public Text divinePowerText;

	[ComponentConnect]
	public Image divinePowerGauge;

	[ComponentConnect]
	public Gauge divinePowerMeter;

	[ComponentConnect]
	public Text divineDamageSumText;

	[ComponentConnect]
	public CanvasGroup loadingPopup;

	[ComponentConnect]
	public Text loadingPopupText;

	[ComponentConnect]
	public RectTransform overtimePanel;

	public Text overtimeHealPer;

	[ComponentConnect]
	public RectTransform stageSurrenderPanel;

	[ComponentConnect]
	public Text stageSurrenderText;

	[ComponentConnect]
	public PvPEnemyInfoPanel pvpEnemyInfoPanel;

	[ComponentConnect]
	public PlayerProfile pvpEnemyProfile;

	[ComponentConnect]
	public RankedPvPEnemyInfoPanel rankedPvpEnemyInfoPanel;

	[ComponentConnect]
	public Text pvpEncryptedEnemyUIDText;

	[ComponentConnect]
	public DevRegisterPvPDeckPanel devRegisterPvPDeckPanel;

	[ComponentConnect]
	public DevLoadDeckPanel devLoadDeckPanel;

	[ComponentConnect]
	public DevSaveLoadFieldPanel devSaveLoadFieldPanel;

	[ComponentConnect]
	public InputField devRogueLikeRoomInputField;

	[ComponentConnect]
	public ConditionalRoot stageCompletePanel;

	[ComponentConnect]
	public Text deckValueText;

	[ComponentConnect]
	public BossSkillGauge bossSkillGauge;

	[ComponentConnect]
	public DivinePowerPanel divinePowerPanel;

	[ComponentConnect]
	public SeasonalEventAnswerPanel seasonalEventAnswerPanel;

	[ComponentConnect]
	public Text serverName;

	public DevStatPanel devStatPanel;

	public Text devStageTimeScaleText;

	public int battleManagerIdx;

	public readonly int sellCost;

	public readonly int[] SELL_GOLD;

	public readonly int[] randomHeroCosts;

	public readonly int[] randomItemCosts;

	public readonly int[] randomHeroLevelUp;

	public readonly int[] upgradeSlotCosts;

	public EncryptedInt addUpgradeSlotCost;

	private int _camPosition;

	private int _lastMyCamPosition;

	private DragUnit _dragUnit;

	private bool _isPvPLocked;

	public bool _isContinuableEventLocked;

	private bool _lockOnCamMove;

	private ulong? _lockCamKey;

	private ColosseumReportPopup _colosseumReportPopup;

	private AccessoryInfoPanel _accessoryInfoPanel;

	[SerializeField]
	private RectTransform _clanRaidBossPowerGaugeRoot;

	[NonSerialized]
	public Slider clanRaidBossPowerGauge;

	[SerializeField]
	private RectTransform _maxLevelEffectObjsRoot;

	private UnitMaxLevelEffectPanel _currentActiveMaxLevelEffectObj;

	private Dictionary<int, UnitMaxLevelEffectPanel> _cachedUnitMaxLevelEffectObjs;

	public readonly int[] basePanelPos;

	public readonly int[] camSize;

	public Tweener cameraMove;

	public Tweener baseMove;

	private bool _baseActive;

	[NonSerialized]
	public bool lockCamMove;

	private bool _randomHeroDown;

	private float _randomHeroDownTime;

	private readonly float RANDOM_HERO_FIRST_DELAY;

	private readonly float RANDOM_HERO_SUMMON_TERM;

	private float _lastOverTimeHealPer;

	private bool _checkItemExist;

	private int timeScoreEffectCount;

	private float _lastCallTime;

	public BabelGameOverPanel babelGameOverPanel => null;

	public ClanRaidGameOverPanel clanRaidGameOverPanel => null;

	private bool _useSellManyArea => false;

	public StartButtonState startButtonState => default(StartButtonState);

	public bool popupEventOpened => false;

	public BattleManager battleManager => null;

	public int getRandomHeroCost => 0;

	public int getRandomItemCost => 0;

	public int getRandomeHeroLevelUpCost => 0;

	public int totalUpgradeSlotCost => 0;

	public int getUpgradeSlotCost => 0;

	public int camPosition => 0;

	public DragUnit dragUnit => null;

	public ColosseumReportPopup colosseumReportPopup => null;

	public AccessoryInfoPanel accessoryInfoPanel => null;

	private void Start()
	{
	}

	private void SetResolution()
	{
	}

	public void Init()
	{
	}

	public void ReloadButtons(bool enableButtons = true)
	{
	}

	[AsyncStateMachine(typeof(_003COnClickStart_003Ed__211))]
	public void OnClickStart()
	{
	}

	public bool CheckFieldUnitCount()
	{
		return false;
	}

	public void SetGold(int value)
	{
	}

	public void ReloadUnitCount()
	{
	}

	public void SetHp(int value)
	{
	}

	public void OnClickDevMenu(int idx)
	{
	}

	private void ReloadDevButtons()
	{
	}

	public void SetTestMode(int mode)
	{
	}

	private void UpdateDeckValueText()
	{
	}

	public void OnClickDevMenu(int idx, bool force)
	{
	}

	public void ShowSellArea()
	{
	}

	public void HideSellArea()
	{
	}

	public void ShowInvadeItemSellArea()
	{
	}

	public void HideInvadeItemSellArea()
	{
	}

	public void SetSellArea()
	{
	}

	public void SetCurrentDragUnit(DragUnit dragUnit)
	{
	}

	public void HandleStageStarted()
	{
	}

	private void OnApplicationFocus(bool focusStatus)
	{
	}

	private void OnApplicationPause(bool pauseStatus)
	{
	}

	public void CancelDrag()
	{
	}

	public void HandleStageEnd(bool win, float delay)
	{
	}

	public void UpperView()
	{
	}

	public void LowerView()
	{
	}

	public Tweener SetCamPosition(int camPos, bool force = false)
	{
		return null;
	}

	public Vector3 GetCameraPosition(int camPos)
	{
		return default(Vector3);
	}

	private void Update()
	{
	}

	public void OnTouch(TouchPhase phase, Vector2 pt, int touchId = 0)
	{
	}

	public bool OnClickRandomHero()
	{
		return false;
	}

	public void OnRandomHeroPointerDown()
	{
	}

	public void OnRandomHeroPointerUp()
	{
	}

	public void OnClickRandomHeroLevelUp()
	{
	}

	public void OnClickRandomEquip()
	{
	}

	[AsyncStateMachine(typeof(_003COnClickUpgradeSlot_003Ed__253))]
	public void OnClickUpgradeSlot()
	{
	}

	public void ShowLoading(bool v)
	{
	}

	public void ReloadStageText(bool win)
	{
	}

	public void SetBasePanelInteract(bool v)
	{
	}

	public bool GetBasePanelInteractable()
	{
		return false;
	}

	public void HighlightSlot()
	{
	}

	public void ShowItemReward(ResourceItem resItem)
	{
	}

	public void ShowItemReward(List<ResourceItem> items, bool setDelay = true)
	{
	}

	public void ShowBattleAnim(string trigger)
	{
	}

	public void OnClickRestRetry()
	{
	}

	public void ShowRestRetry()
	{
	}

	public void ShowLoadingPopup(bool v)
	{
	}

	public void ShowOvertime(bool v, float healPer, float overTimeLength, int phase)
	{
	}

	public void ShowStageSurrender(bool v, string surrenderTextKey = "SurrenderSuggestion")
	{
	}

	public void OnClickStageSurrender()
	{
	}

	public void OnClickPvPNameBox()
	{
	}

	public void ShowColosseumDeck()
	{
	}

	public void PvPLock(bool set)
	{
	}

	public void ContinuableEventLock(bool set)
	{
	}

	public void LockSeasonalEventButtons(bool set)
	{
	}

	public void ShowStageComplete(bool v)
	{
	}

	public void OnClickStageComplete()
	{
	}

	public void EnqueuePopupEvent(Action action)
	{
	}

	public void DequeuePopupEvent()
	{
	}

	public void SetDivinePowerGauge(long damageSum, float divinePower, float gaugeFill = -1f)
	{
	}

	private void AddBossHpBar()
	{
	}

	public BossHpBar GetBossHpBar(int index)
	{
		return null;
	}

	public Gauge GetBossManaBar(int index)
	{
		return null;
	}

	public Gauge GetBossBuffGaugeBar(int index)
	{
		return null;
	}

	public Gauge GetBossChannelingBar(int index)
	{
		return null;
	}

	public Gauge GetBossGroggyBar(int index)
	{
		return null;
	}

	public Image GetBossLevelIcon(int index)
	{
		return null;
	}

	public Image GetBossIcon(int index)
	{
		return null;
	}

	public List<Gauge> GetAllBossBarGauges(int index)
	{
		return null;
	}

	public int GetBossHpBarCount()
	{
		return 0;
	}

	public bool ShowBossTitle()
	{
		return false;
	}

	public void ShowFloorInfo()
	{
	}

	public void ShowAddStageClearScore(int score)
	{
	}

	private void ShowAddStageClearScoreInner(int score, Text scoreEffectText = null)
	{
	}

	public void SetStartButtonState(StartButtonState state)
	{
	}

	public bool IsPopupOpenedOrQueued()
	{
		return false;
	}

	public void IncreaseBattleIdx(int amount)
	{
	}

	public void SetBattleIdx(int idx, int camPos, bool withUI = true)
	{
	}

	public void OnClickColosseumBackToMyBattleButton()
	{
	}

	public void OnClickColosseumTarotAnnouncePanel(bool auto = false)
	{
	}

	public void CloseColosseumTarotAnnouncePanel()
	{
	}

	public void InitClanRaidBossPowerGauge(int bossId, ref Slider slider)
	{
	}

	public void HandleUnitLevelUp(GameUnit unit)
	{
	}
}
