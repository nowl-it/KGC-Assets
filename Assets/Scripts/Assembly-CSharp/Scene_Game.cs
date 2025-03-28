using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.WebSockets;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using AwesomeData.Encrypted;
using Awesomepiece.Model;
using CodeStage.AntiCheat.ObscuredTypes;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DG.Tweening;
using LeTai.Asset.TranslucentImage;
using Protocol;
using UniRx;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Scene_Game : Scene_Base
{
	public class IngameBabelState
	{
		public class BabelRoundData
		{
			public List<GameCompleteRequestModel.EndFieldUnit> fieldUnits;

			public BaseAI.SaveDatas fieldUnitAIs;

			public List<GameCompleteRequestModel.EndFieldUnit> waitingUnits;

			public List<GameCompleteRequestModel.EndItemUnit> waitingItems;

			public void Save(BattleManager battle)
			{
			}

			public void Load(BattleManager battle)
			{
			}
		}

		public BoolReactiveProperty isAuto;

		public BabelRoundData babelRoundData;
	}

	public enum ColosseumGamePhase
	{
		PlayerWaitingPhase = 0,
		ReadyPhase = 1,
		BattlePhase = 2,
		ChoiceTarotPhase = 3,
		RandomTarotPhase = 4,
		End = 5
	}

	private class UnitData
	{
		private GameCompleteRequestModel.EndFieldUnit _endFieldUnit;

		public int unitId;

		public int level;

		public List<ResourceItem> items;

		public UnitData(GameCompleteRequestModel.EndFieldUnit endFieldUnit)
		{
		}
	}

	[Serializable]
	public class GodItemData
	{
		[NonSerialized]
		public Item item;

		[NonSerialized]
		public ItemUnit itemUnit;

		public int itemId;

		public Item.GodItemFromType fromType;

		public bool isHide;
	}

	public struct GodReward
	{
		public int gold;

		public List<int> items;

		public List<(int tier, int rewardType)> tierAndRewardTypes;
	}

	[Serializable]
	public class RogueLikeSaveData
	{
		public string gameId;

		public int gameIndex;

		public int saveDataVersion;

		public string version;

		public int worldId;

		public int totalFloor;

		public int floorInWorld;

		public bool isInUseItemPhase;

		public int remainReviveCount;

		public int life;

		public int reservedRoomClearEvent;

		public List<SaveRogueLikeUnitData> fieldUnits;

		public BaseAI.SaveDatas fieldUnitAIs;

		public List<SaveUnitData> enemies;

		public BaseAI.SaveDatas enemyAIs;

		public List<SaveUnitData> obstacles;

		public List<SaveRogueLikeItemData> items;

		public List<SaveRogueLikeItemData> itemQueue;

		public int stage;

		public List<int> resStages;

		public int gold;

		public int maxOwnedGold;

		public List<RogueLikeArtifactModel.SaveData> artifactModels;

		public List<RogueLikeCardData.SaveData> cards;

		public RogueLikeLevelGenerator.SaveData levelSaveData;

		public SerializedDictionary<ResourceRogueLikeRoom.Type, SerializedList<int>> roomRandomSpawnHistories;

		public List<RogueLikeMerchantPanel.MerchantData> merchantDatas;

		public List<int> leftMiniBosses;

		public List<int> selectableBuildingArtifacts;

		public List<int> usedBuildingArtifacts;

		public EventTriggerManager.SaveData eventTriggerManagerSaveData;

		public ResourceRogueLikeEvent.Executor.SaveData eventExecutor;

		public RogueLikeExchangePanel.SaveData exchangePanelSaveData;

		public RogueLikeDefaultRewardPanel.SaveData defaultRewardPanelSaveData;

		public RogueLikeSelectNewHeroPanel.SaveData selectNewHeroPanelSaveData;

		public RogueLikeTrialPanel.SaveData trialPanelSaveData;

		public RogueLikeRewardFactory.SaveData rewardFactorySaveData;

		public List<int> selectableGodItems;

		public List<GodItemData> godItems;

		public int philosopherItemMinusGold;

		public List<int> eliteBossIDs;

		public int challengeLevel;

		public int finalBossId;

		public bool calledRogueLikeAfterGoToNextFloor;

		public int firstSelectedHeroId;

		public int totalReviveCount;

		public string rogueLikeInGameStatus;

		public int adRevivedFloor;

		public List<int> rogueLikeAvailableBuildingIdx;

		public TreasureModel[] treasureModels;

		public List<AccessoryModel>[] accessoryModels;
	}

	[Serializable]
	public class RogueLikeSaveLogData
	{
		[Serializable]
		public class RogueLikeUnitLogData
		{
			public int id;

			public int level;

			public int x;

			public int y;

			public List<int> items;

			public List<int> runes;

			public int potential;
		}

		public int floor;

		public List<RogueLikeUnitLogData> unitDatas;

		public List<int> artifactIds;

		public List<int> equippedRunes;

		public int[] buildingLevels;

		public int challengeLevel;

		public int finalBossId;

		public int firstSelectedHeroId;

		public int totalReviveCount;
	}

	[Serializable]
	public class SaveGameData
	{
		public int saveDataVersion;

		public string version;

		public GameCompleteRequestModel gameCompleteRequestModel;

		public List<SaveUnitData> fieldUnits;

		public BaseAI.SaveDatas fieldUnitAIs;

		public List<SaveUnitData> waitingUnits;

		public List<SaveUnitData> enemies;

		public BaseAI.SaveDatas enemyAIs;

		public List<SaveUnitData> obstacles;

		public int curObstaclePattern;

		public List<SaveItemData> items;

		public List<SaveItemData> itemQueue;

		public int gold;

		public int slot;

		public int slotBonus;

		public int life;

		public int theme;

		public int stage;

		public int[] eliteLevels;

		public int difficulty;

		public int devilEffectCount;

		public DevilPanel.Condition devilCond;

		public int[] currentDeck;

		public int remainReviveCount;

		public int spawnLevelUpCount;

		public int winningStreak;

		public int stageLoseCount;

		public int[] buildingLevels;

		public SaveMerchantPopup merchantPopupData;

		public SaveDevilPopup devilPopupData;

		public SaveCraftPopup craftPopupData;

		public bool lastReviveAdEnabled;

		public bool isRankingStage;

		public List<BatchData> rankingStageUnits;

		public int foodBoosterLevel;

		public List<ArtifactModel> equippedArtifacts;

		public int deckValue;

		public int currentDeckPreset;

		public int currentEventDifficulty;

		public bool devilAllAccepted;

		public bool devilAllDeclined;

		public int merchantBuyCount;

		public string battleObserverState;

		public int lateComersLeftCount;
	}

	[Serializable]
	public class SaveUnitData
	{
		public int id;

		public int level;

		public int boss;

		public Vector2 pos;

		public List<SaveItemData> items;

		public int skin;
	}

	[Serializable]
	public class SaveRogueLikeUnitData
	{
		public int id;

		public int level;

		public int boss;

		public Vector2 pos;

		public List<SaveRogueLikeItemData> items;

		public List<SaveRogueLikeItemData> runes;

		public int skin;

		public int potential;

		public int hp;
	}

	[Serializable]
	public class SaveItemData
	{
		public int id;

		public Vector2 pos;

		public List<Item.Option> options;

		public bool artifactAdjusted;

		public bool isTemporal;

		public bool matkSwapped;
	}

	[Serializable]
	public class SaveRogueLikeItemData
	{
		public int id;

		public Vector2 pos;

		public List<Item.Option> options;

		public SerializedDictionary<string, int> customStacks;

		public int[] buildingAddedValues;

		public int[] artifactAddedValues;

		public int minusGold;

		public bool isTemporal;

		public List<string> subDescs;
	}

	[Serializable]
	public class SaveMerchantPopup
	{
		public bool saved;

		public GameCompleteRequestModel.MerchantResult data;
	}

	[Serializable]
	public class SaveDevilPopup
	{
		public bool saved;

		public DevilPanel.Condition cond;

		public SaveItemData reward;
	}

	[Serializable]
	public class SaveCraftPopup
	{
		public bool saved;

		public List<SaveItemData> items;

		public int maxRerollCount;

		public int remainRerollCount;

		public int tier;
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass522_0
	{
		public Scene_Game _003C_003E4__this;

		public bool cleared;

		public bool adBonus;

		internal void _003CHandleGameEndImpl_003Eb__3(bool o)
		{
		}

		internal void _003CHandleGameEndImpl_003Eb__4()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass522_1
	{
		public ulong loadingTimer;

		public GameResponseModel ret;

		public _003C_003Ec__DisplayClass522_0 CS_0024_003C_003E8__locals1;

		internal void _003CHandleGameEndImpl_003Eb__18()
		{
		}

		internal void _003CHandleGameEndImpl_003Eb__17()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass645_0
	{
		public bool processed;

		internal void _003CShowRogueLikeFloorEndGameOverPanel_003Eb__0()
		{
		}
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CCheckShowMerchant_003Ed__504 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public Scene_Game _003C_003E4__this;

		private int _003CmerchantValue_003E5__2;

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
	private struct _003CForceGameEnd_003Ed__203 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

		public Scene_Game _003C_003E4__this;

		private ColosseumEndGameReenterResponseModel _003CgameEndRet_003E5__2;

		private UniTask<ColosseumEndGameReenterResponseModel>.Awaiter _003C_003Eu__1;

		private int _003Ci_003E5__3;

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
	private struct _003CHandleGameEnd_003Ed__521 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public Scene_Game _003C_003E4__this;

		public bool cleared;

		private UniTask<ClanRaidResponseModel>.Awaiter _003C_003Eu__1;

		private TaskAwaiter _003C_003Eu__2;

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
	private struct _003CHandleGameEndImpl_003Ed__522 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public Scene_Game _003C_003E4__this;

		public bool cleared;

		public bool adBonus;

		private _003C_003Ec__DisplayClass522_1 _003C_003E8__1;

		private _003C_003Ec__DisplayClass522_0 _003C_003E8__2;

		private int _003CbeforeLevel_003E5__2;

		private int _003CbeforeExp_003E5__3;

		private int _003CaddClanToken_003E5__4;

		private int _003CcolosseumScore_003E5__5;

		private int _003CcolosseumScoreDelta_003E5__6;

		private int _003CcolosseumTier_003E5__7;

		private UniTask<GameResponseModel>.Awaiter _003C_003Eu__1;

		private UniTask<KeyValuesResponseModel>.Awaiter _003C_003Eu__2;

		private UniTask.Awaiter _003C_003Eu__3;

		private GameManager _003C_003E7__wrap7;

		private UniTask<FlagInventoryResponseModel>.Awaiter _003C_003Eu__4;

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
	private sealed class _003CHandleReadyPhase_003Ed__143 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Scene_Game _003C_003E4__this;

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
		public _003CHandleReadyPhase_003Ed__143(int _003C_003E1__state)
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
	private struct _003CReconnect_003Ed__205 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

		public Scene_Game _003C_003E4__this;

		private int _003CtryCount_003E5__2;

		private UniTask.Awaiter _003C_003Eu__1;

		private int _003Ci_003E5__3;

		private UniTask<bool>.Awaiter _003C_003Eu__2;

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
	private struct _003CRestartBabelWithServer_003Ed__10 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder<bool> _003C_003Et__builder;

		public Scene_Game _003C_003E4__this;

		private UniTask<GameStartResponseModel>.Awaiter _003C_003Eu__1;

		private UniTask<bool>.Awaiter _003C_003Eu__2;

		private Exception _003Ce_003E5__2;

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
	private sealed class _003CSaveGameImpl_003Ed__717 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Scene_Game _003C_003E4__this;

		public bool restoreFromLastSave;

		public bool restoreWaiting;

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
		public _003CSaveGameImpl_003Ed__717(int _003C_003E1__state)
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
	private struct _003CShowRogueLikeFloorEndGameOverPanel_003Ed__645 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public Scene_Game _003C_003E4__this;

		public bool sendEndRogueLikeFloorToServer;

		public bool win;

		private _003C_003Ec__DisplayClass645_0 _003C_003E8__1;

		public int rewardAmount;

		public int seasonalTokenAmount;

		public int passPointAmount;

		public int hotTimeBonusValue;

		public int addClanPoint;

		public int score;

		private int _003CbeforeLevel_003E5__2;

		private int _003CbeforeExp_003E5__3;

		private int _003Cfloor_003E5__4;

		private UniTask<EndRogueLikeFloorResponseModel>.Awaiter _003C_003Eu__1;

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

	public IngameBabelState ingameBabelState;

	private bool _babelLocked;

	private bool _loadBabel;

	public int clanRaidBoss;

	public int savedClanRaidScore;

	public long clanRaidTotalDamage;

	public int clanRaidBossKillCount;

	public long originDivinePowerDamageAmount;

	[NonSerialized]
	public bool exceptionReported;

	[NonSerialized]
	public string lastPacketName;

	public ColosseumGamePhase currentPhase;

	public readonly Dictionary<string, BattleManager> battleManagerDict;

	public bool colosseumIsReady;

	public readonly List<ColosseumData> colosseumDatas;

	public List<InvadeItemUnit> myInvadeItems;

	public List<int> invadeItemQueue;

	public List<int>[] otherPlayerInvadeItems;

	public int currentMinRank;

	public List<int> obtainedAbilitiesOnCurStage;

	public List<int> obtainedTarotsOnCurStage;

	public List<int> usedInvadeItemIDs;

	private int _invadeShopRerollCount;

	private int _lastAbilityGetRoundAt;

	public int invadeSuccessCount;

	private bool _useDevInfReadyPhase;

	private int _devCurrentBattleTime;

	private int _currentBattlePhase;

	public IntReactiveProperty enemyBerserkBaseValue;

	[NonSerialized]
	public List<ResourceColosseumAbility> colosseumPickedAbilities;

	public List<ResourceColosseumAbility> abandonedAbilities;

	public SaveColosseumRoundDataRequestModel.ColosseumRoundData currentColosseumRoundData;

	public Dictionary<int, List<int>> abilityExpDict;

	public int berserkBaseValueStreak;

	public bool interactLocked;

	public bool fieldInteractLocked;

	private bool _enableEmoticon;

	public bool logNextSendPacket;

	public List<(int id, string msg)> unhandledMessages;

	private int _recentlyReceivedMessageId;

	private TimeSpan _pauseExploitElapsedTime;

	private DateTime _lastPauseExploitTime;

	private bool _pongReceived;

	private ulong? _pingPongTimer;

	private ObscuredBool _devFixBotLife;

	private bool _isReenteredGame;

	[NonSerialized]
	public ObscuredBool doubleInvadeUnitCount;

	[NonSerialized]
	public List<int> choiceTarotList;

	[NonSerialized]
	public List<int> randomTarotList;

	public static Scene_Game Instance;

	[HideInInspector]
	public bool popupDisplayed;

	public BattleManager battleManager;

	public readonly List<BattleManager> battleManagers;

	public Camera worldCam;

	public Camera mainCam;

	public TouchCamera2 touchCamera;

	public CameraShaker cameraShaker;

	public new TranslucentImageSource translucentImageSource;

	public MainUI mainUI;

	public GameObject defaultFlagPrefab;

	public InvadeItemPool invadeItemPool;

	public EffectPool effectPool;

	public MapPool mapPool;

	public GameObject unitPrefab;

	public GameObject itemPrefab;

	public GameObject invadeItemPrefab;

	public GameObject obstaclePrefab;

	public GameObject tileBuffPrefab;

	public GameObject totemPrefab;

	[NonSerialized]
	public Dictionary<string, GameObject> totemPrefabDict;

	public const int DEFAULT_SLOT = 3;

	public readonly int[] DEFAULT_DECK;

	public GameObject sortObject;

	public GameObject mergeObject;

	public GameObject colosseumObjectsRoot;

	public GameObject colosseumInvadeItemSellArea;

	public ClickOutsideClose colosseumSellInvadeItemTooltip;

	private AwesomeInt _stage;

	private AwesomeInt _theme;

	private ObscuredInt _enemyLevelBonus;

	private List<ResourceStage> _resStages;

	private ObscuredFloat _stageStartAt;

	private ObscuredFloat _bossTimeCounter;

	private ObscuredBool _isStageStarted;

	private ObscuredBool _isStageEndPostCalled;

	public bool initialized;

	public bool skipCamChange;

	public bool showDebug;

	[HideInInspector]
	public ObscuredInt testMode;

	[HideInInspector]
	public ObscuredInt semiTestMode;

	[HideInInspector]
	public ObscuredBool captureMode;

	[HideInInspector]
	public int testMyUnit;

	[HideInInspector]
	public int testEnemyUnit;

	[HideInInspector]
	public int testEnemyUnitLevel;

	[HideInInspector]
	public int testEnemyPotential;

	[HideInInspector]
	public int testEnemyPotentialTier;

	[HideInInspector]
	public int[] testEnemyBuiildings;

	[HideInInspector]
	public List<ArtifactModel> testEnemyArtifacts;

	[HideInInspector]
	public Dictionary<string, int>[] devArtifactOptions;

	private Sequence _opening;

	private Sequence _randomItemSequence;

	private ObscuredInt _remainReviveCount;

	private ObscuredInt _stageLoseCount;

	private ObscuredInt _devilEffectCount;

	private DevilPanel.Condition _devilCond;

	private ObscuredFloat _camSize;

	private Action _restRetryCallback;

	private ResourceTheme _resTheme;

	public GameCompleteRequestModel gameCompleteRequestModel;

	private ObscuredBool _isRankingStage;

	private ObscuredFloat _stageTimer;

	private ObscuredFloat _stageMaxTime;

	private ObscuredFloat _stageTimeScore;

	private ObscuredInt _stageClearScore;

	private ObscuredBool _usingStageTimer;

	public Dictionary<float, int> timerAlarms;

	private ObscuredFloat _waitingTimer;

	private ObscuredBool _usingWaitingTimer;

	private ulong? _waitingEnableWorkTimer;

	private ObscuredLong _finalRankingScore;

	private float _gameTimer;

	private Sequence _mergibleAlphaSeq;

	public List<float[]> tileTwinkleAlphaList;

	private List<Sequence[]> _tileTwinkleAlphaSeqList;

	private DateTime _startTime;

	private bool _skipOpening;

	private bool _loadedGame;

	private bool _sendGameComplete;

	private int _eventRewardGoldSum;

	private GameObject redFlag;

	private GameObject blueFlag;

	private ResourcePvpEnemyPreset _currentPvPEnemyPreset;

	private List<(int card, int level, int potentialTier)> _enemyDeck;

	private List<BuildingData> _enemyBuildingDatas;

	private List<ArtifactModel> _enemyArtifacts;

	private ObscuredInt _pvpWinCount;

	[HideInInspector]
	public bool pvpStarted;

	private List<ResourcePvpEnemyPreset> _pvpPresetStages;

	private bool _showPvPInfoAfterRandomItem;

	private List<Item> _pvpEnemyPrevRoundAllItems;

	private List<GameCompleteRequestModel.RoundData> _pvpDeckData;

	private GameCompleteRequestModel.RoundData _currentRoundData;

	private ObscuredInt[] _rankedPvPScore;

	[HideInInspector]
	public ObscuredFloat masterValueRatio;

	[HideInInspector]
	public ObscuredFloat masterAddCCRatio;

	public int pvpRoundLogCount;

	private ObscuredInt _deckValue;

	public float divinePower;

	public float divineRatio;

	public long dealtTotalDamageBeforeSetRatio;

	public long dealtDivineDamageBeforeSetRatio;

	public long dealtDivineDamageLastBoss;

	[NonSerialized]
	public Dictionary<BuffManager.StatInfo, float> clanRaidBossPowerBuffs;

	[NonSerialized]
	public Func<DamageInfo, DamageInfo> clanRaidBossAdjustDamage;

	public ObscuredInt selectedTeamForQuiz;

	public int testTimeLimit;

	private bool _hasRandomItemLimit;

	private bool _hasFreeMerchantRefreshLimit;

	public AwesomeInt randomItemGetCount;

	public AwesomeInt freeMerchantRefreshCount;

	public EncryptedInt artifactRefreshTime;

	public EncryptedInt artifactRefreshCost;

	private readonly Dictionary<string, string> _conditionKeyValueDict;

	private SaveGameData _eventModeRoundData;

	public bool isEventModeContinuing;

	public bool useStageValueSum;

	public bool showEffectSwitch;

	private BuyHeartPanel _buyHeartPanel;

	private RewardListResultPanel _rewardListResultPanel;

	public ItemTooltipPanel itemTooltipPanel;

	public ArtifactInfoPanel artifactInfoPanel;

	private int _currentStageTimeScalePhase;

	public bool useLegacyConsumeHp;

	public bool useIdealClosest;

	public bool useLegacyAfterSkillCallback;

	public bool useRemoveSummonedUnitsAfterHandleUnitDead;

	public bool useHandleSummonedUnitDeadIgnoreTreatAsDead;

	public bool preserveEffectSpriteOnReadyPoolReturn;

	public bool useBidirectionalBFS;

	public bool doNot10690BugFix;

	public bool fixMaxHpBug;

	public bool useAStarAlgorithm;

	public bool showDevUI;

	public int merchantUsedGoldGoalValue;

	private int _curObstacle;

	private readonly float[] _speedUpTimes;

	public float bossTimeBonus;

	public float devOverTime;

	private int _devSummonUnitByIdTeam;

	private string _devSummonUnitByIdText;

	private float lastOvertimeLogTime;

	private const float SERVER_HANDSHAKE_TIME = 300f;

	private float _serverHandshakeTimer;

	private static ulong _testTimeLimitHash;

	private static ulong _stopTestHash;

	private List<(bool allDead, bool allKill)> _checkStageEndInfos;

	private float _lastClickedTime;

	private GameUnit _lastClickedUnit;

	public static readonly int ActiveTrigger;

	private const float DoubleTapTime = 0.3f;

	private List<(int, int)> _assetLoaded;

	private bool _skin1028005ShaderInitialized;

	private ResourceRogueLikeWorld _resRogueLikeWorld;

	private ResourceRogueLikeWorld.Floor _resRogueLikeFloor;

	[HideInInspector]
	public bool rogueLikeIsFinalFloor;

	[HideInInspector]
	public int rogueLikeTotalFloor;

	private int _rogueLikeFloorInWorld;

	public RogueLikeRoom enteredRoom;

	private List<int> _rogueLikeLeftMiniBosses;

	private int _reservedRoomClearEvent;

	private SerializedDictionary<ResourceRogueLikeRoom.Type, SerializedList<int>> _rogueLikeRoomRandomSpawnHistories;

	private readonly SerializedList<SaveUnitData> _rogueLikeLastBattleEnemiesData;

	public List<GodItemData> godItems;

	public int philosopherItemMinusGold;

	public ResourceRogueLikeSetting.ChallengeData rogueLikeChallengeData;

	private float _missionPopupTimer;

	private int _adRevivedFloor;

	public List<int> recentlyKilledBossIds;

	private static int CurrentSaveDataVersion;

	public SaveMerchantPopup currentMerchantPopup;

	public SaveDevilPopup currentDevilPopup;

	public SaveCraftPopup currentCraftPopup;

	public bool lastReviveAdEnabled;

	private bool _canSave;

	public ResourceBabel resBabel => null;

	public bool isClanRaid => false;

	public bool isClanRaidDeckRecord => false;

	public int invadeShopRerollCount
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int invadeShopMaxRerollCount { get; private set; }

	public int abilityRerollCount { get; set; }

	public ResourceColosseumTarotSetting resTarotSetting => null;

	public bool tarotEnabled => false;

	public BattleManager playerBattle => null;

	public AwesomeInt theme => default(AwesomeInt);

	public bool isTutorial => false;

	public ObscuredInt enemyLevelBonus => default(ObscuredInt);

	public List<ResourceStage> resStages => null;

	public ResourceStage curStage => null;

	public bool isFinalStage => false;

	public ObscuredFloat bossTimeCounter => default(ObscuredFloat);

	public bool isStageStarted => false;

	public bool isStageEndPostCalled => false;

	public int stage => 0;

	public bool isTestMode => false;

	public bool isSemiTestMode => false;

	public ObscuredFloat camSize => default(ObscuredFloat);

	public ResourceTheme resTheme => null;

	public bool isRankingStage => false;

	private bool _usingTimeScore => false;

	public float stageTimer => 0f;

	public long finalRankingScore => 0L;

	public float mergibleAlpha { get; private set; }

	public int eventRewardGoldSum
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public bool isEventMode => false;

	public bool isContinuableEventMode => false;

	public bool isPvPMode => false;

	public bool isRankedPvP => false;

	public bool isRogueLike => false;

	public bool isSeasonalMode => false;

	public bool isColosseum => false;

	public bool isBabel => false;

	public bool isSeasonalQuizMode => false;

	public List<ArtifactModel> enemyArtifacts => null;

	public List<GameCompleteRequestModel.RoundData> pvpDeckData => null;

	public GameCompleteRequestModel.RoundData currentRoundData => null;

	public bool isPvPDeckRecord => false;

	public int deckValue
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public bool hasRandomItemLimit => false;

	public bool hasFreeMerchantRefreshLimit => false;

	public int stageValueSum { get; set; }

	public bool gameEndProcessed { get; private set; }

	public BuyHeartPanel buyHeartPanel => null;

	public RewardListResultPanel rewardListResultPanel => null;

	public ResourceRogueLikeWorld resRogueLikeWorld => null;

	public ResourceRogueLikeWorld.Floor resRogueLikeFloor => null;

	public RogueLikeRoom curRogueLikeRoom => null;

	public int reservedRoomClearEvent
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public SerializedList<SaveUnitData> rogueLikeLastBattleEnemiesData => null;

	public RogueLikeEventExecutor rogueLikeEventExecutor { get; private set; }

	public RogueLikeLevelGenerator rogueLikeLevelGenerator { get; private set; }

	private int saveDataVersion => 0;

	private RogueLikeSaveData _rogueLikeSaveData => null;

	public void InitBabelStage()
	{
	}

	public List<ResourceStage> GetBabelStages()
	{
		return null;
	}

	public void HandleStageLoseCallback_Babel()
	{
	}

	public void LockBabelButtons(bool set)
	{
	}

	public void HandleGameEndImpl_Babel()
	{
	}

	[AsyncStateMachine(typeof(_003CRestartBabelWithServer_003Ed__10))]
	public UniTask<bool> RestartBabelWithServer()
	{
		return default(UniTask<bool>);
	}

	public void GiveAutoItem()
	{
	}

	public void OnToggleAuto()
	{
	}

	public void InitializeIngameBabelState()
	{
	}

	public void LoadBabelPlayerUnits()
	{
	}

	public void StartStage_Babel()
	{
	}

	public void RestartBabel(bool skipOpening = true)
	{
	}

	private void RemoveItemFromBabelPlayerUnits()
	{
	}

	private bool IsStartItemChanged()
	{
		return false;
	}

	public void InitClanRaidStage()
	{
	}

	private int GetClanRaidScore()
	{
		return 0;
	}

	public void ReloadDivinePowerGauge(bool onMiddleStage = false)
	{
	}

	public void ReloadDivinePower()
	{
	}

	public void DivinePowerToUnit(GameUnit unit)
	{
	}

	public void ShowDivinePowerPanel()
	{
	}

	public void InitColosseum()
	{
	}

	private void InitColosseumWaitingArea()
	{
	}

	private void SetCurrentColosseumPhase(ColosseumGamePhase phase)
	{
	}

	public void StartColosseumBattle()
	{
	}

	public void InitColosseumData()
	{
	}

	public void HandleEndColosseumBattle(BattleManager battleManager, string userId, bool isWin)
	{
	}

	public void HandleCreateUnit()
	{
	}

	public void CreatePlayerUnit(UserMessage createUnitMessage)
	{
	}

	public void HandleSellUnit(BattleManager battle, CommonData.Grid grid, Vector2Int pos)
	{
	}

	public void SellPlayerUnit(SellUnitMessage sellUnitMessage)
	{
	}

	public void HandleDrag(GameUnit unit, CommonData.GridPosition start, CommonData.GridPosition end)
	{
	}

	public void HandleMergeItemSelected(GameUnit unit, List<int> indexes)
	{
	}

	public void ForceDrag(DragMessage dragMessage)
	{
	}

	public void HandleSortUnits(BattleManager battleManager)
	{
	}

	public void HandleMergeWaitingField(BattleManager battleManager, bool onlyWaitings)
	{
	}

	public void SortUnits(SortUnitsMessage sortUnitsMessage)
	{
	}

	public void SetSelectedItem(SelectItemMessage selectItemMessage)
	{
	}

	public void HandleMergeWaitingField(MergeWaitingFieldMessage mergeWaitingFieldWaitingFieldMessage)
	{
	}

	public void OnGiveItemReward(Item item)
	{
	}

	public void OnGetEventResult(CommonData.ItemType type, int itemId, List<Item.Option> options = null)
	{
	}

	public void ApplyEventResult(EventResultMessage eventResultMessage)
	{
	}

	public void ApplyGiveItemReward(GiveItemRewardMessage giveItemRewardMessage)
	{
	}

	public void OnUseInvade(BattleManager battle, InvadeItemUnit invadeItemUnit)
	{
	}

	public void ApplyInvade(InvadeMessage invadeMessage)
	{
	}

	public void OnDisposeInvade(BattleManager battle, InvadeItemUnit invadeItemUnit)
	{
	}

	public void DisposePlayerInvade(DisposeInvadeMessage disposeInvadeMessage)
	{
	}

	private void Ready(ReadyMessage readyMessage)
	{
	}

	private void SetReadyPhase(SetReadyPhaseMessage message)
	{
	}

	private void HandleEnemyBerserkValue(EnemyBerserkValueMessage message)
	{
	}

	private void SetTarotPhase(SetTarotPhaseMessage message)
	{
	}

	public void OnClickReady(bool isReady)
	{
	}

	public void WaitForNextPhase()
	{
	}

	public void ApplyOtherBattleResult(BattleResultMessage message)
	{
	}

	public void HandleAddGold(BattleManager battleManager, int amount)
	{
	}

	public void ReloadEmoticonEnable()
	{
	}

	public void ShowPlayerEmoticon(EmoticonMessage message)
	{
	}

	public void HandleRerollInvadeShop()
	{
	}

	public void OnRerollInvadeShop(RerollInvadeShopMessage message)
	{
	}

	public void HandleBuyInvadeItem(int invadeId)
	{
	}

	public void OnBuyInvadeItem(BuyInvadeItemMessage message)
	{
	}

	public void HandleAddSlot(BattleManager battleManager, int value)
	{
	}

	public void OnAddSlot(AddSlotMessage message)
	{
	}

	public void CheckLife(CheckLifeMessage message)
	{
	}

	public void PlayersDisconnect(UserDisconnectMessage message)
	{
	}

	public void AfterReconnect()
	{
	}

	public void OnSendMessage(BaseMessage message, string serialized)
	{
	}

	public void ReconnectWebSocketEventDispatcher(BaseMessage message)
	{
	}

	public void DispatchColosseumWebSocketEvent(BaseMessage message)
	{
	}

	private void DispatchColosseumBinaryWebSocketEvent(Packet packet)
	{
	}

	private void OnLobbyLoaded(Scene scene, LoadSceneMode loadSceneMode)
	{
	}

	private void LockFieldUnitInteract(bool isLock)
	{
	}

	private void LockAllInteract(bool isLock)
	{
	}

	[IteratorStateMachine(typeof(_003CHandleReadyPhase_003Ed__143))]
	private IEnumerator HandleReadyPhase()
	{
		return null;
	}

	public void SpawnInvadeUnitsToOpponent(BattleManager battleManager)
	{
	}

	public void AddColosseumAbility(BattleManager battleManager, ResourceColosseumAbility resAbility)
	{
	}

	private void HandleChoiceTarotMessage(ChoiceTarotMessage message)
	{
	}

	private void HandleChoiceTarotResultMessage(ChoiceTarotResultMessage resultMessage)
	{
	}

	public void AddColosseumTarot(BattleManager battle, ResourceColosseumTarot resTarot, bool isRandom)
	{
	}

	public void RemoveInvadeItem(BattleManager battle)
	{
	}

	public void AddInvadeItem(BattleManager battleManager, int id, bool useQueue = false)
	{
	}

	public void AddInvadeItem(BattleManager battleManager, ResourceColosseumInvadeItem resInvadeItem, bool useQueue = false)
	{
	}

	public void CopyInvadeItem(BattleManager battle)
	{
	}

	public void ClearInvadeItems(BattleManager battleManager)
	{
	}

	public BattleManager FindPlayerTargetThisId(string id, bool checkSurvive = true)
	{
		return null;
	}

	public Vector3 LocalToBattlePosition(Vector3 pos, int battleIdx)
	{
		return default(Vector3);
	}

	public Vector3 BattleToLocalPosition(Vector3 pos, int battleIdx)
	{
		return default(Vector3);
	}

	public void OnClickColosseumInvadeShop()
	{
	}

	public void OnClickColosseumSellInvadeItemObject()
	{
	}

	public void InitColosseumBotStage(BattleManager battle)
	{
	}

	public void ApplyBotInvadeItemAndAbilities(BattleManager battle)
	{
	}

	private int HighestUnitSortFunc(GameCompleteRequestModel.EndFieldUnit a, GameCompleteRequestModel.EndFieldUnit b)
	{
		return 0;
	}

	private (bool, List<SaveColosseumRoundDataRequestModel>) BuildRoundDataList()
	{
		return default((bool, List<SaveColosseumRoundDataRequestModel>));
	}

	public void CheckPopInvadeItemQueue(BattleManager battle)
	{
	}

	public void ChangeInvadeItems(BattleManager battle, int from, int to)
	{
	}

	public void RefreshInvadeItems(BattleManager battle)
	{
	}

	public bool CanModifyFieldGrid()
	{
		return false;
	}

	public void HandleInvadePointChanged(int invadePoint, bool showEffect, bool showOverPoint = false, float baseEffectDelay = 2f)
	{
	}

	public void SendColosseumSnapshotsToServer(bool mySnapshotOnly = false)
	{
	}

	private PlayerPrivateSnapshot WriteColosseumPlayerPrivateSnapshot()
	{
		return null;
	}

	public void SendColosseumPlayerPrivateSnapshot()
	{
	}

	public void SendColosseumPlayerSnapshotOnExit()
	{
	}

	private void HandleColosseumPlayerSnapshot(string userId, PlayerSnapshot playerSnapshot, bool force = false)
	{
	}

	private void SendTarotParams()
	{
	}

	public void DevOnClickColosseumUIToggle()
	{
	}

	public void DevColosseumUIToggle(bool set)
	{
	}

	public void DevSetInvadePoint(InputField input)
	{
	}

	public void DevSetAbilityExp(InputField input)
	{
	}

	public void DevSetFixBerserk()
	{
	}

	public void DevSetFixBotLife()
	{
	}

	public void DevSetNextRoundTarot()
	{
	}

	public void OnDevSetAbilityExp(Dev_SetAbilityExpMessage message)
	{
	}

	public void DevSetAbilityLevel(InputField input)
	{
	}

	public void OnDevSetAbilityLevel(Dev_SetAbilityLevelMessage message)
	{
	}

	public void OnDevSetChoiceTarotSelector(Dev_SetChoiceTarotSelectorMessage message)
	{
	}

	public void DevSetAbilityRerollCount(InputField input)
	{
	}

	public void DevSetEnemyBerserkValue(InputField input)
	{
	}

	public void DevSetEnemyBerserkBaseValue(InputField input)
	{
	}

	public void DevSetWinningStreak(InputField input)
	{
	}

	public void DevSetLife(InputField input)
	{
	}

	public void OnDevSetLife(DevMessage message)
	{
	}

	public void DevAddInvadeItem()
	{
	}

	public void DevSetPing(InputField input)
	{
	}

	public void DevAddAbility()
	{
	}

	public void DevClearAbility()
	{
	}

	public void DevSetInfWaitingPhaseTime()
	{
	}

	public void DevSetCurrentBattlePhaseTime(InputField input)
	{
	}

	public void DevSetCurrentBattlePhase(InputField input)
	{
	}

	public void DevAddColosseumTarot()
	{
	}

	public void DevSetNextTarotPool()
	{
	}

	public void DevSetSelectorPool()
	{
	}

	private void OnWebSocketClosed(WebSocketCloseStatus? closeStatus)
	{
	}

	[AsyncStateMachine(typeof(_003CForceGameEnd_003Ed__203))]
	public UniTaskVoid ForceGameEnd()
	{
		return default(UniTaskVoid);
	}

	public void ApplyRoundAndSnapshots(Packet packet)
	{
	}

	[AsyncStateMachine(typeof(_003CReconnect_003Ed__205))]
	public UniTaskVoid Reconnect()
	{
		return default(UniTaskVoid);
	}

	private void SchedulePingMessage()
	{
	}

	private void SavePrefsForReenter()
	{
	}

	protected override void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnApplicationFocus(bool hasFocus)
	{
	}

	private void OnApplicationPause(bool pauseStatus)
	{
	}

	private void OnApplicationQuit()
	{
	}

	protected override void OnResolutionChanged(float resolution)
	{
	}

	private void SetCameraSize(float size)
	{
	}

	private float GetCameraSize()
	{
		return 0f;
	}

	public void Init()
	{
	}

	public GameObject GetDefaultFlagPrefab()
	{
		return null;
	}

	public void InitMap()
	{
	}

	private void OpeningSequence()
	{
	}

	private void CheckGameStartEffects(out int bonusTier)
	{
		bonusTier = default(int);
	}

	public void InitStage()
	{
	}

	public int GetEnemyEquipCount(ResourceStage.Spawn spawn)
	{
		return 0;
	}

	private void InitSeasonalQuizMode()
	{
	}

	private string GetQuizModeDesc(List<GameUnit> units)
	{
		return null;
	}

	private void InitPvPPresetStage()
	{
	}

	public void InitRankedPvPStage()
	{
	}

	public void InitArtifactItems()
	{
	}

	public void Clear(bool checkStageEnd = true)
	{
	}

	public void ClearPools()
	{
	}

	public new void Update()
	{
	}

	public void FixedUpdate()
	{
	}

	private void UpdateImpl()
	{
	}

	public void SaveCurTestField(int slot, bool saveToClipboard = false)
	{
	}

	public string PrintCurTestEnemyToXML()
	{
		return null;
	}

	public string PrintCurWaitingItemsToXML()
	{
		return null;
	}

	public void LoadEnemyXML(string xml)
	{
	}

	public void LoadWaitingItemsXML(string xml)
	{
	}

	public void LoadTestField(int slot, bool fromClipboard = false)
	{
	}

	private void BatchTestField(Utility.TestField field, bool isRaid = false)
	{
	}

	private float GetOverTimeLengthImpl(int phase, float speedUpTime)
	{
		return 0f;
	}

	private GameUnit TestBatchUnit(Vector2 pos, int id)
	{
		return null;
	}

	private GameUnit TestBatchEnemy(Vector2 pos, int id)
	{
		return null;
	}

	private void TestUpdate()
	{
	}

	private void TestColosseumUpdate()
	{
	}

	private void TestRun()
	{
	}

	public int GetUnitLevelByDifficulty(int level)
	{
		return 0;
	}

	public bool HandleInstantItem(ResourceItem item, BattleManager battleManager)
	{
		return false;
	}

	public void LevelUpByItem(GameUnit target, int addLevel)
	{
	}

	public bool CheckAlreadyHasGodItem(Item item)
	{
		return false;
	}

	public bool CheckAlreadyHasGodItem(ResourceItem item)
	{
		return false;
	}

	public ResourceItem[] GetRandomGodItems(int count)
	{
		return null;
	}

	public void AddGodItem(int id, Item.GodItemFromType fromType)
	{
	}

	public static float GetZ(float y, float x = 0f)
	{
		return 0f;
	}

	public void CheckStageEnd()
	{
	}

	public void AutoMoveUnitToField()
	{
	}

	public void StartStage()
	{
	}

	private void HandleStartStage()
	{
	}

	private void SetBossHpBar()
	{
	}

	public void SetStage(int v)
	{
	}

	public void SetTheme(int v)
	{
	}

	public void SetCurrentEventDifficulty(int v)
	{
	}

	public void HandleStageLose()
	{
	}

	public int GetThemeRandomItems(int idx = -1)
	{
		return 0;
	}

	public int GetThemeMerchants(int idx = -1)
	{
		return 0;
	}

	public void HandleStageClear()
	{
	}

	private void NextStage(bool obstacleChanged, float addedDelay)
	{
	}

	[AsyncStateMachine(typeof(_003CCheckShowMerchant_003Ed__504))]
	private void CheckShowMerchant()
	{
	}

	public void AddItemReward(GameUnit unit, Item item, BattleManager battle, int effectXIdx, bool showUIEffect)
	{
	}

	private void GiveReward(float delay)
	{
	}

	private void GiveRewardImpl(BattleManager battleManager, float delay)
	{
	}

	private void CheckBarricadeFromStage(float delay = -3f)
	{
	}

	private void StageEnd()
	{
	}

	public void StageEndPost(bool win)
	{
	}

	public void OnClickUnit(GameUnit unit)
	{
	}

	public void OnClickItem(ItemUnit unit, Item item, Vector2 pos)
	{
	}

	public void SetHighlight(GameUnit from, bool set)
	{
	}

	public void PreRevive()
	{
	}

	public void RollbackRevive()
	{
	}

	public void Revive()
	{
	}

	[AsyncStateMachine(typeof(_003CHandleGameEnd_003Ed__521))]
	public void HandleGameEnd(bool cleared)
	{
	}

	[AsyncStateMachine(typeof(_003CHandleGameEndImpl_003Ed__522))]
	private void HandleGameEndImpl(bool cleared, bool adBonus)
	{
	}

	public bool GetEventDifficultyMissionCleared(bool clear)
	{
		return false;
	}

	public void ShowDevil()
	{
	}

	public void HandleDevilPopupResult(DevilPanel.Condition cond, Item rewardItem, bool accept)
	{
	}

	public void HandleUnitLevelChanged(GameUnit unit, int level)
	{
	}

	public void RestRetry()
	{
	}

	private void StartRankingStage(bool spawnUnit = true)
	{
	}

	public long GetRankingScore()
	{
		return 0L;
	}

	private int GetRankingTimeScore()
	{
		return 0;
	}

	public void ResetMergibleAlpha()
	{
	}

	public void SyncTileTwinkleAlpha(int count)
	{
	}

	public void AddTileTwinkleAlpha()
	{
	}

	public void CollectToken(GameUnit from)
	{
	}

	public void SetSeasonalEventQuizTeam(int team)
	{
	}

	public void SortWaitingField()
	{
	}

	public void OnClickMergeWaitingField()
	{
	}

	private void MergeWaitingField(bool onlyWaitingField)
	{
	}

	public void OnClickAutoMoveToggle()
	{
	}

	public void OnClickSellAreaToggle()
	{
	}

	public void ShowPvPEnemyInfo(bool splash = true)
	{
	}

	public void HandleRandomItemSelected()
	{
	}

	public static GameCompleteRequestModel.EndFieldUnit ToEndFieldUnit(GameUnit fieldUnit)
	{
		return null;
	}

	public static GameCompleteRequestModel.EndItemUnit ToEndItemUnit(ItemUnit item)
	{
		return null;
	}

	public void RankedPvPGiveUp()
	{
	}

	public int HighestUnitSortFunc(GameUnit a, GameUnit b)
	{
		return 0;
	}

	public int HighestUnitWithUnitUidSortFunc(GameUnit a, GameUnit b)
	{
		return 0;
	}

	public int GetUnitValue(GameUnit unit)
	{
		return 0;
	}

	public void AddDeckValue(int value)
	{
	}

	public int GetUnitDeckValue(int level)
	{
		return 0;
	}

	public void HandleCustomEvent(string name)
	{
	}

	public void SetDivineRatio(float ratio)
	{
	}

	public long GetDivineTotalDamage()
	{
		return 0L;
	}

	public void HandleSpawnUnit(GameUnit unit)
	{
	}

	public void RefreshMissionFailWarning()
	{
	}

	public void ReloadInGameMissions()
	{
	}

	private bool CheckMissionFailCondition(ResourceMission resMission)
	{
		return false;
	}

	private void AddMissionPostfix(StringBuilder sb, ResourceMission resMission)
	{
	}

	public int GetTotalMerchantUsedGold()
	{
		return 0;
	}

	public void SetConditionKey(string key, string value)
	{
	}

	public string GetConditionKey(string key, string _default = null)
	{
		return null;
	}

	private void ReloadTimeScorePanel()
	{
	}

	private void AddStageClearScore(int score)
	{
	}

	public void SetIgnoreDeckRecord(bool v)
	{
	}

	public void OnClickSkipRanking()
	{
	}

	private void HandleInteractableUnitClickEvent(ResourceUnit.OnClickEvent onClickEvent)
	{
	}

	public void CacheUnitAssets(ResourceUnit unit, int skin = 0)
	{
	}

	public void InitializeShaders(int unitId, int skinId)
	{
	}

	private void CacheAllUnitAssets()
	{
	}

	public float[] GetTerritoryStatBuffs(int battleManagerIdx, int team)
	{
		return null;
	}

	public float GetCurrentTime()
	{
		return 0f;
	}

	public float GetStageTime()
	{
		return 0f;
	}

	private bool CheckIsColosseumEnd()
	{
		return false;
	}

	public void DevOnClickStatPanelUIToggle()
	{
	}

	public void SetStatPanelUIToggle()
	{
	}

	public void OnClickDevStageTimeScalePhase(int index)
	{
	}

	private void UpdateStageTimeScaleText()
	{
	}

	public void DevOnClickEnemyItemReserve()
	{
	}

	public void DevEnemyItemReserveUIToggle(bool set)
	{
	}

	public void DevSetGimmickComplete()
	{
	}

	public void UpdateDevArtifactOptionValue()
	{
	}

	private void SetRogueLikeWorld(ResourceRogueLikeWorld _resWorld)
	{
	}

	private void SetRogueLikeFloorInWorld(int floor, bool createRooms = true)
	{
	}

	private void InitRogueLikeStage()
	{
	}

	public void PlayRogueLikeNormalMusic()
	{
	}

	public void RogueLikeSpawnRoomSpawns()
	{
	}

	private void HandleRogueLikeStageEnd()
	{
	}

	private void RogueLikeGoToNextFloor()
	{
	}

	public void RogueLikeAfterGoToNextFloor()
	{
	}

	public void StartRoomClearEvent()
	{
	}

	public void SetReservedRogueLikeRoomClearEvent(int id)
	{
	}

	public void StartRogueLikeUseItemPhase()
	{
	}

	public void MakeWaitingFieldDraggable(bool draggable)
	{
	}

	public void ShowRogueLikeLevelGenerator()
	{
	}

	public void HideRogueLikeLevelGenerator()
	{
	}

	public void ShowRogueLikeRevivePanelOrEndGame()
	{
	}

	public void RogueLikeRevive(bool fromAd = false)
	{
	}

	public void RollbackRogueLikeRevive()
	{
	}

	public List<(Item, ItemUnit, GameUnit)> GetAllEquips(bool includeEquipped, bool exceptMaxLevel)
	{
		return null;
	}

	public List<(Rune, ItemUnit, GameUnit)> GetAllRunes(bool includeEquipped, bool exceptMaxLevel)
	{
		return null;
	}

	public List<(Item, ItemUnit)> GetAllInstantItems()
	{
		return null;
	}

	public void AdjustAllItemsOption()
	{
	}

	public void UpdateAllUnitsStat()
	{
	}

	private void GodRewardValue(int tier, ref GodReward godReward)
	{
	}

	public GodReward GetGodReward(int level)
	{
		return default(GodReward);
	}

	public void ShowGodItemsSelectPanel(int level, Item.GodItemFromType fromType)
	{
	}

	[AsyncStateMachine(typeof(_003CShowRogueLikeFloorEndGameOverPanel_003Ed__645))]
	public void ShowRogueLikeFloorEndGameOverPanel(bool win, bool sendEndRogueLikeFloorToServer, int score, int rewardAmount, int seasonalTokenAmount, int passPointAmount, int hotTimeBonusValue, int addClanPoint)
	{
	}

	private void GetRogueLikeClearedAndTotalBattleRoomCount(out int clearedBattleRoomCount, out int totalBattleRoomCount)
	{
		clearedBattleRoomCount = default(int);
		totalBattleRoomCount = default(int);
	}

	public void SaveRogueLikeImpl(bool restoreFromLastSave = false)
	{
	}

	private void LoadRogueLikeImpl()
	{
	}

	public void SaveAndLobby()
	{
	}

	public void DevOnClickUIToggle()
	{
	}

	public void DevUIToggle(bool set)
	{
	}

	public void DevSaveRogueLike()
	{
	}

	public void DevLoadRogueLike()
	{
	}

	public void DevSaveRogueLikeToServer()
	{
	}

	public void DevLoadRogueLikeFromServer()
	{
	}

	public void PrintCurrentRogueLikeSaveDataVersion()
	{
	}

	public void DevSetRogueLikeStage(InputField input)
	{
	}

	public void DevAddRogueLikeArtifact(InputField input)
	{
	}

	public void DevRemoveRogueLikeArtifact(InputField input)
	{
	}

	public void DevSetRogueLikeRoom(InputField input)
	{
	}

	public void DevSetRogueLikePlayCount(InputField input)
	{
	}

	public void DevSetRogueLikeClearCount(InputField input)
	{
	}

	public void DevSetRogueLikeMissionClearCount(InputField input)
	{
	}

	public void DevSetRogueLikeDeathCount(InputField input)
	{
	}

	public void DevSetRogueLikeUsedGold(InputField input)
	{
	}

	public void DevSetRogueLikeKillCount(InputField input)
	{
	}

	public void DevSetRogueLikeBossKillCount(GameObject go)
	{
	}

	public void DevSetRogueLikeEventCount(InputField input)
	{
	}

	public void DevResetRogueLikeMission(InputField input)
	{
	}

	public void DevSetRogueLikeFloor(Dropdown dropdown)
	{
	}

	public void DevSaveRogueLikeSlot(Dropdown dropdown)
	{
	}

	public void DevSaveRogueLikeSlotImpl(int slot)
	{
	}

	public void DevLoadRogueLikeSlot(Dropdown dropdown)
	{
	}

	public void DevLoadRogueLikeSlotImpl(int slot)
	{
	}

	public void DevOnClickSkipReward()
	{
	}

	public void DevSetSkipReward(bool set)
	{
	}

	public void DevOnClickReBattle()
	{
	}

	public void DevSetReBattle(bool set)
	{
	}

	public void DevShowSaveJSON()
	{
	}

	public void DevEnterSaveJSON()
	{
	}

	private void DevRoguelikeReLoadImpl()
	{
	}

	public void SaveGame(bool restoreFromLastSave = false, bool restoreWaiting = true)
	{
	}

	public List<SaveItemData> ToItemDatas(List<Item> items)
	{
		return null;
	}

	private List<SaveRogueLikeItemData> ToRogueLikeItemDatas(List<Item> items)
	{
		return null;
	}

	private List<SaveRogueLikeItemData> ToRogueLikeItemDatas(List<Rune> items)
	{
		return null;
	}

	private List<SaveRogueLikeItemData> ToRogueLikeItemDatas(List<ItemUnit> items)
	{
		return null;
	}

	public List<SaveItemData> ToItemDatas(List<ItemUnit> items)
	{
		return null;
	}

	private List<SaveUnitData> ToSaveDatas(List<GameUnit> units)
	{
		return null;
	}

	private List<SaveRogueLikeUnitData> ToRogueLikeSaveDatas(List<GameUnit> units)
	{
		return null;
	}

	public string ToAISaveDatasString(List<GameUnit> units)
	{
		return null;
	}

	public static BaseAI.SaveDatas ToAISaveDatas(List<GameUnit> units)
	{
		return default(BaseAI.SaveDatas);
	}

	public static void LoadAIs(List<GameUnit> units, string saveDatasStr)
	{
	}

	public static void LoadAIs_New(List<GameUnit> units, BaseAI.SaveDatas saveDatas)
	{
	}

	public static void LoadEndFieldUnits(BattleManager battle, GameCompleteRequestModel.EndFieldUnit unit, List<ArtifactModel> artifacts, int[] buildings, int[] potentials, int poolIdx)
	{
	}

	public static void LoadEndFieldWaitingUnits(BattleManager battle, GameCompleteRequestModel.EndFieldUnit unit, List<ArtifactModel> artifacts, int[] buildings, int[] potentials, int poolIdx)
	{
	}

	[IteratorStateMachine(typeof(_003CSaveGameImpl_003Ed__717))]
	private IEnumerator SaveGameImpl(bool restoreFromLastSave = false, bool restoreWaiting = true)
	{
		return null;
	}

	public void LoadGame()
	{
	}

	public SaveGameData SavePlayerUnits()
	{
		return null;
	}

	public void LoadPlayerUnits(SaveGameData data)
	{
	}

	public void DeleteSavedGame()
	{
	}

	private void BatchUnits(List<SaveUnitData> datas, Func<SaveUnitData, GameUnit> spawnFunc)
	{
	}
}
