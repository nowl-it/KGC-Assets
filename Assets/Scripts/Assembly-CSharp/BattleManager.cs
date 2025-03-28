using System;
using System.Collections.Generic;
using AwesomeData.Encrypted;
using Awesomepiece.Model;
using CodeStage.AntiCheat.ObscuredTypes;
using Protocol;
using UniRx;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class BattleManager : MonoBehaviour
{
	public struct LastStageInfo
	{
		public int unitId;

		public Vector2Int pos;

		public int level;

		public int boss;

		public int skin;

		public List<int> equips;

		public List<Item> preservedItems;
	}

	public float stageManaHealRatio;

	public float stageHealRatio;

	private bool _isSurvived;

	public bool isConnected;

	[NonSerialized]
	public int battleManagerIdx;

	[NonSerialized]
	public List<Animator> flags;

	public Transform flagsRoot;

	[SerializeField]
	private Button _flagWarningTooltipButton;

	public List<SpriteRenderer> flagWarnings;

	public EffectAreaDrawer effectAreaDrawer;

	[NonSerialized]
	public BaseBattleObserver battleObserver;

	public List<GameUnit> allFieldUnits;

	public List<GameUnit> fieldUnits;

	public List<GameUnit> waitingUnits;

	public List<GameUnit> enemies;

	public List<GameUnit> summonedUnits;

	public List<GameUnit> unSummonedUnits;

	public List<GameUnit> obstacles;

	public List<GameUnit> artifactSkillUnits;

	public List<CardInfo> cardInfos;

	public int totalUsedGold;

	private List<WorldTriggerBundle> _worldTriggerBundles;

	private List<WorldTriggerBundle> _enemyWorldTriggerBundles;

	private List<ArtifactModel> _artifacts;

	private int[] _buildings;

	private ResourceBuilding[] _usingResBuilding;

	private int[] _potentialSlots;

	public EncryptedFloat[][] _territoryStatBuffPersByTeam;

	private Subject<GameUnit> _spawnUnitSubject;

	private Subject<(GameUnit, GameUnit)> _unitDeadSubject;

	private Subject<(GameUnit, GameUnit, DamageInfo)> _unitHardCCSubject;

	private Subject<GameUnit> _gridUpdateSubject;

	private Subject<Null> _afterBattleStartSubject;

	private Subject<bool> _beforeNextStageSubject;

	private Subject<Null> _afterStageInitSubject;

	public List<ItemUnit> items;

	public List<GameUnit> clearList;

	[ComponentConnect]
	public UnitGrid fieldGrid;

	[ComponentConnect]
	public UnitGrid waitingGrid;

	[ComponentConnect]
	public UnitGrid invadeWaitingGrid;

	[ComponentConnect]
	public UnitGrid invadeGrid;

	[GetComponent]
	public Canvas gameCanvas;

	[GetComponent]
	public CanvasGroup gameCanvasGroup;

	[ComponentConnect]
	public Canvas frontWorldCanvas;

	private EncryptedInt _life;

	private EncryptedInt _gold;

	private EncryptedInt _maxOwnedGold;

	private EncryptedInt _slot;

	private EncryptedInt _slotBonus;

	private EncryptedInt[] _heroPool;

	public GridMap gridMap;

	[NonSerialized]
	public GameUnit lastLevelChangedUnit;

	private List<LastStageInfo> _lastStage;

	private List<TileBuffInfo> _tileBuffs;

	private List<Item> _itemQueue;

	public readonly List<Item> itemRewards;

	private bool _requestFlagAnim;

	private (int idx, string trigger, int delta) _requestFlagParam;

	public GameObject fieldObject;

	public GameObject castleObject;

	public GameObject gridObject;

	[ComponentConnect]
	public FogManager fogManager;

	private List<GameObject> _mapEffects;

	public EventDispatcher eventDispatcher;

	public List<GameUnit.StageStartData> fieldUnitsOnStageStart;

	public List<GameUnit.StageStartData> enemyUnitsOnStageStart;

	[NonSerialized]
	public GameUnit clonePosUnit;

	[NonSerialized]
	public Vector2 clonePosUnitLastPos;

	[NonSerialized]
	public bool blockClone;

	[NonSerialized]
	public GameUnit enemyClonePosUnit;

	[NonSerialized]
	public Vector2 enemyClonePosUnitLastPos;

	[NonSerialized]
	public int fieldUnitDeadCount;

	[NonSerialized]
	public int enemyUnitDeadCount;

	public List<ulong> spawnTimers;

	private ObscuredInt _unlimitedSpawnLevelUpStageCount;

	private ObscuredInt _preventSellUnitStageCount;

	private EncryptedInt _spawnLevelUpCount;

	public GameUnit eventTriggerUnit;

	public SpawnManager spawnManager;

	private EventTriggerManager _eventTriggerManager;

	private int? _actionSeed;

	private int? _battleSeed;

	public Queue<GameUnit> waitForItemSelectUnits;

	public SerializedDictionary<string, int> customStacks;

	[NonSerialized]
	public int winningStreak;

	[NonSerialized]
	public bool isBattleStarted;

	public bool isClearingSummonedUnit;

	public UnitPool unitPool;

	public readonly List<QueuedRewardPanel> queuedRewardPanels;

	public EncryptedInt addSellPriceOnLevel1Unit;

	[NonSerialized]
	public int lastPreferredTarotId;

	[NonSerialized]
	public int lateComersLeftCount;

	private GameUnit _clicked;

	private int _curObstacle;

	private const int BARRICADE_COUNT = 6;

	private const int TELEPORT_COUNT = 0;

	private readonly List<ObstacleObject> _obstacleMapObjects;

	private ObstacleObject _bossMapObject;

	private List<int> _bannedObstacles;

	private readonly int[] _nullInts;

	private static readonly int _get;

	private static readonly int _burn;

	private (bool _allDead, bool _allKill)? _stageEndResult;

	public bool isSurvived
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool isPlaying => false;

	public bool isPlayerBattleManager => false;

	public bool isFocusedBattleManager => false;

	public List<ArtifactModel> artifacts
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public int[] buildings
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public int[] potentialSlots
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public Subject<GameUnit> spawnUnitSubject => null;

	public IObservable<GameUnit> spawnUnitObservable => null;

	public Subject<(GameUnit, GameUnit)> unitDeadSubject => null;

	public IObservable<(GameUnit, GameUnit)> unitDeadObservable => null;

	public Subject<(GameUnit, GameUnit, DamageInfo)> unitHardCCSubject => null;

	public IObservable<(GameUnit, GameUnit, DamageInfo)> unitHardCCObservable => null;

	public Subject<GameUnit> gridUpdateSubject => null;

	public IObservable<GameUnit> gridUpdateObservable => null;

	public Subject<Null> afterBattleStartSubject => null;

	public IObservable<Null> afterBattleStartObservable => null;

	public Subject<bool> beforeNextStageSubject => null;

	public IObservable<bool> beforeNextStageObservable => null;

	public Subject<Null> afterStageInitSubject => null;

	public IObservable<Null> afterStageInitObservable => null;

	public List<(ItemUnit itemUnit, Item item)> allItemsIncludeQueue => null;

	public EncryptedInt[] heroPool => null;

	public int life
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int gold => 0;

	public int maxOwnedGold => 0;

	public int maxUnitCount => 0;

	public int slot
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int slotBonus
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public List<LastStageInfo> lastStage => null;

	public List<TileBuffInfo> tileBuffs => null;

	public List<Item> itemQueue => null;

	public List<GameObject> mapEffects => null;

	public int spawnLevelUpCount
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public EventTriggerManager eventTriggerManager => null;

	public int? actionSeed
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public int? battleSeed
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public int? specialSeed => null;

	public int curObstacle => 0;

	public int GetSummonedCount(int team)
	{
		return 0;
	}

	public void Init(int idx)
	{
	}

	public void InitHeroPool(IEnumerable<int> selectedUnits, List<CardInfo> cardInfos)
	{
	}

	public void SetHeroPool(int[] data)
	{
	}

	public void InitArtifactAndBuildings(List<ArtifactModel> artifacts, int[] buildings)
	{
	}

	public void InitArtifacts(List<ArtifactModel> artifacts)
	{
	}

	public void InitBuildings(int[] buildings)
	{
	}

	public void InitPotentialInfos(int[] potentialSlots)
	{
	}

	public void InitTerritoryStatBuffs(float[] buffPers, int team)
	{
	}

	public EncryptedFloat[] GetTerritoryStatBuffs(int team)
	{
		return null;
	}

	public void InitWorldTrigger()
	{
	}

	public void InitEventTrigger()
	{
	}

	private void Update()
	{
	}

	public void CheckSpawnTimers()
	{
	}

	public void InitFlags(FlagResponseModel equippedFlag)
	{
	}

	public void HandleInitMap(string map, ResourceTheme theme, bool usePool = true)
	{
	}

	public void HandleCheckGameStartEffects()
	{
	}

	public void BeforeInitStage()
	{
	}

	public void AfterInitStage(int devilEffectCount, DevilPanel.Condition devilCond)
	{
	}

	public void ReloadFog(ResourceTheme theme)
	{
	}

	public void InitObstacles(bool force = false, float delay = 0f, bool byCheat = false, int obstacleId = -1)
	{
	}

	public void EnableObstacleObject(int idx, bool isBoss)
	{
	}

	public ObstacleUnit AddObstacle(Vector2 pos, string prefab = null)
	{
		return null;
	}

	public GameUnit GetUnitFromTilePos(UnitGrid grid, Vector2Int tilePos)
	{
		return null;
	}

	public GameUnit GetUnitOrObstacleFromTilePos(UnitGrid grid, Vector2Int tilePos)
	{
		return null;
	}

	public GameUnit GetUnitFromTilePos(Vector2Int tilePos)
	{
		return null;
	}

	public ObstacleUnit GetObstacleFromTilePos(Vector2Int tilePos)
	{
		return null;
	}

	public void SetStageTileBuff()
	{
	}

	public void AddTileBuff(Vector2Int basePos, ResourceItem resItem, string type = "Artifact")
	{
	}

	public void RemoveTileBuff(TileBuffInfo buff)
	{
	}

	public void ClearTileBuffs()
	{
	}

	public void StartTileBuff()
	{
	}

	public void CheckTileBuffsEnd()
	{
	}

	public void InitArtifactObstacles()
	{
	}

	public void ClearEnemies(bool checkStageEnd = true)
	{
	}

	public void ClearSummonedUnits()
	{
	}

	public void ClearFieldUnits(bool checkStageEnd = true)
	{
	}

	public void ClearWaitingUnits()
	{
	}

	public void ClearItems()
	{
	}

	public void ClearObstacles(float delay = 0f)
	{
	}

	public void ClearArtifactSkillUnits()
	{
	}

	public GameUnit GetFieldUnitByAIType(Type ai)
	{
		return null;
	}

	public List<GameUnit> GetFieldUnitsByAIType(Type ai)
	{
		return null;
	}

	public List<GameUnit> GetAllPlayerUnits()
	{
		return null;
	}

	public List<GameUnit> GetAllFieldUnitsIncludeCharm(int team)
	{
		return null;
	}

	public List<GameUnit> GetAllFieldUnits(Func<GameUnit, bool> cond, bool usePool = false)
	{
		return null;
	}

	public List<GameUnit> GetAllFieldUnits(bool copy = false)
	{
		return null;
	}

	public List<GameUnit> GetAllFieldUnits(int team, bool copy = true)
	{
		return null;
	}

	public List<GameUnit> GetAllUnits(Func<GameUnit, bool> cond = null)
	{
		return null;
	}

	private void AddAllUnitsToList(List<GameUnit> list, bool includeWaiting, Func<GameUnit, bool> cond)
	{
	}

	public void RegisterAllUnitsToMap()
	{
	}

	public void FieldGridUpdated()
	{
	}

	public void SaveConnectedBuffersConnectedTargetAtStartBattle()
	{
	}

	public int[] GetBuildingLevels(bool adjustArtifact = false)
	{
		return null;
	}

	public int GetBuildingLevel(int id)
	{
		return 0;
	}

	public int GetBuildingEffect(string key, int @default = 0)
	{
		return 0;
	}

	public void UpdateBuildingLevel(int[] buildings)
	{
	}

	public void RefreshBuildingLevel()
	{
	}

	public void ApplyBuffsToFieldUnits(BuffOption.Conditions conditions, List<GameUnit> battleTarget = null, ResourceRogueLikeRoom.Type roomType = ResourceRogueLikeRoom.Type.None)
	{
	}

	public void ApplyBuffsToFieldUnits(BuffOption.Conditions conditions, ref DamageInfo damageInfo, List<GameUnit> battleTarget = null, ResourceRogueLikeRoom.Type roomType = ResourceRogueLikeRoom.Type.None)
	{
	}

	public void UnEquipTemporalItems()
	{
	}

	public Vector2Int KillUnitDirectly(ref GameUnit gameUnit)
	{
		return default(Vector2Int);
	}

	public bool CheckOnlyCloneIsInField()
	{
		return false;
	}

	public void ReBatch()
	{
	}

	public void AfterBatchEnemies()
	{
	}

	public void CheckStartStageArtifact()
	{
	}

	public bool IsBestTierUnit(GameUnit unit)
	{
		return false;
	}

	public bool IsBestTierResUnit(GameUnit unit)
	{
		return false;
	}

	public void CheckAndSpawnClonePosUnit()
	{
	}

	public GameUnit GetUnitFromResID(int id)
	{
		return null;
	}

	public GameUnit GetUnitFromID(int id)
	{
		return null;
	}

	public void InitStageStartUnitData()
	{
	}

	public void ChangeTeam(GameUnit unit, int team)
	{
	}

	public Vector2Int MouseToTilePos(bool setLocal = false)
	{
		return default(Vector2Int);
	}

	public Vector2 MouseToSnapPos(bool setLocal = false)
	{
		return default(Vector2);
	}

	public void RefreshFlags(bool init = false)
	{
	}

	public void SetLife(int value, bool anim = true)
	{
	}

	public void CheckLifeAnim()
	{
	}

	public void ForceSetLife(int value, bool callGameEnd = true)
	{
	}

	public void KillAllEnemy()
	{
	}

	public void KillAllPlayerUnits()
	{
	}

	public void HandleUnitDead(GameUnit unit, GameUnit from, bool reward, bool ignoreArtifact)
	{
	}

	private void CheckUnitDeadTriggerArtifacts(GameUnit unit)
	{
	}

	public void StartEnemiesBattle()
	{
	}

	public bool CanStartStage()
	{
		return false;
	}

	public void StartStage()
	{
	}

	public (bool, bool) CanEndStage()
	{
		return default((bool, bool));
	}

	public (bool, bool) CanEndStageLegacy()
	{
		return default((bool, bool));
	}

	public (bool, bool) CheckStageEnd()
	{
		return default((bool, bool));
	}

	public void HandleStageClear()
	{
	}

	public void HandleStageLose()
	{
	}

	public void StageEnd()
	{
	}

	public void StageEndPost()
	{
	}

	public void GiveItemRewards()
	{
	}

	public UnitGrid GetCurrentGrid(Vector2 pos)
	{
		return null;
	}

	public void SortFieldUnitsByUID()
	{
	}

	public int GetPlayerFieldUnitCount(bool onlyLive = false, bool withoutSummon = false, bool ignoreTargetable = true)
	{
		return 0;
	}

	public int GetFieldUnitCount(int team, bool onlyLive = false, bool withoutSummon = false, bool ignoreTargetable = true, Func<GameUnit, bool> filter = null)
	{
		return 0;
	}

	public int GetPlayerFieldUnitCountUnderLevel(int level, int team, bool onlyLive = false)
	{
		return 0;
	}

	public int GetUnitTargetedByBuff(GameUnit unit, string buff)
	{
		return 0;
	}

	public bool IsFieldFull()
	{
		return false;
	}

	public void HandleBeforeUnitGridMove(GameUnit unit)
	{
	}

	public void HandleUnitGridMoved(GameUnit unit, UnitGrid grid)
	{
	}

	public void CheckManaResetAfterFieldChanged()
	{
	}

	public bool CheckLevelTop3(GameUnit unit)
	{
		return false;
	}

	public bool CheckLevelTopN(int n, GameUnit unit)
	{
		return false;
	}

	public List<GameUnit> GetLevelSortedUnits(int team)
	{
		return null;
	}

	public bool CheckMaxIceOnFieldBySkill(int team, int skillId, int maxCount)
	{
		return false;
	}

	public void SetUnitsOrder()
	{
	}

	public void SetMaxOwnedGold(int value)
	{
	}

	public void SetGold(int value)
	{
	}

	public void AddGold(int value, bool addDeckValue = true, bool showEffect = true, bool showMinusEffect = false)
	{
	}

	public bool HasGold(int value)
	{
		return false;
	}

	public bool ConsumeGold(int value, bool checkUnitCount = true)
	{
		return false;
	}

	private bool CheckNeedItemQueue()
	{
		return false;
	}

	private void AddToItemQueue(Item item, bool firstInQueue = false)
	{
	}

	public void ReplaceItemInQueue(Item before, Item after)
	{
	}

	public void CheckPopItemQueue()
	{
	}

	public List<Item> GetItemQueue()
	{
		return null;
	}

	public bool RemoveItemInQueue(Item item)
	{
		return false;
	}

	public void RemoveItem(Item item, ItemUnit itemUnit, GameUnit equippedBy)
	{
	}

	public void FindAndRemoveItem(int id)
	{
	}

	public void FindAndRemoveItems(int id)
	{
	}

	public ItemUnit GetItem(int id, bool save = true, int? seed = null)
	{
		return null;
	}

	public ItemUnit GetItem(int id, Vector2Int pos, bool firstInQueue = false, bool save = true, int? seed = null)
	{
		return null;
	}

	private ItemUnit GetEquip(int id, Vector2Int pos, int? seed = null)
	{
		return null;
	}

	private ItemUnit GetRune(int id, Vector2Int pos)
	{
		return null;
	}

	public ItemUnit AddItem(GameCompleteRequestModel.EndItemUnit endItemUnit)
	{
		return null;
	}

	public ItemUnit AddStageStartItem(GameCompleteRequestModel.EndItemUnit endItemUnit)
	{
		return null;
	}

	public ItemUnit AddItem(Item item, bool handleInstant = true, bool save = true, bool firstInQueue = false, bool handleOnSpawn = true)
	{
		return null;
	}

	private void HandleItemSpawned(ResourceItem resItem, bool save)
	{
	}

	private ItemUnit GetTileBuff(int id, Vector2Int pos)
	{
		return null;
	}

	public void RefreshCanMerge(bool resetAlphaValue = true)
	{
	}

	public void GenRandomHero()
	{
	}

	public GameUnit AddUnitToWaitings(int id, int level = 1)
	{
		return null;
	}

	public GameUnit AddUnitTo(bool isField, int id, Vector2 pos, int level, int skin = 0, int potentialTier = 0)
	{
		return null;
	}

	public bool CanSlotUp()
	{
		return false;
	}

	public bool SlotUp(int count = 1)
	{
		return false;
	}

	public void SetSlot(int count)
	{
	}

	public void SetSpawnLevelUpCount(int count)
	{
	}

	public CardInfo GetCard(int unitId)
	{
		return null;
	}

	public bool SellManyUnit(DragUnit target)
	{
		return false;
	}

	public bool SellUnit(DragUnit target)
	{
		return false;
	}

	public void CheckGiveBuffTileEffect()
	{
	}

	public void HandleItemMerged(Item item)
	{
	}

	public WorldTriggerBundle AddWorldTriggerBundle(List<WorldTrigger> worldTriggers, string type, int resourceId, bool isAddedFirstTime = true)
	{
		return null;
	}

	public WorldTriggerBundle AddEnemyWorldTriggerBundle(List<WorldTrigger> worldTriggers, string type, int resourceId, bool isAddedFirstTime = true)
	{
		return null;
	}

	public WorldTriggerBundle FindAbilityWorldTriggerBundle(int id)
	{
		return null;
	}

	public WorldTriggerBundle FindInvadeItemWorldTriggerBundle(int id)
	{
		return null;
	}

	public WorldTriggerBundle FindTarotItemWorldTriggerBundle(int id)
	{
		return null;
	}

	public WorldTriggerBundle FindArtifactWorldTriggerBundle(int id)
	{
		return null;
	}

	public void ApplyWorldTrigger(WorldTrigger.Conditions condition)
	{
	}

	public void DisposeWorldTrigger(string type)
	{
	}

	public void DisposeWorldTrigger(string type, int resId)
	{
	}

	public IReadOnlyList<WorldTriggerBundle> GetWorldTriggerBundles()
	{
		return null;
	}

	public void SortWaitingField()
	{
	}

	public void MergeWaitingField(bool onlyWaitingField)
	{
	}

	public bool AutoMerge(GameUnit unit, bool onlyWaitingFields = false, bool ignoreIfItemCountExceedsMax = false, bool handleDrag = true)
	{
		return false;
	}

	public CommonData.GridPosition GetUnitGridPosition(GameUnit unit)
	{
		return null;
	}

	public float GetArtifactValueSum(string key)
	{
		return 0f;
	}

	public void PlacePlayerUnitFromRoundData(List<GameCompleteRequestModel.EndFieldUnit> endFieldUnits, string fieldUnitAIs)
	{
	}

	public void HandleFocusChanged()
	{
	}

	public void AddUnlimitedSpawnLevelUpStageCount(int stageCount)
	{
	}

	public void AddPreventSellUnitStageCount(int stageCount)
	{
	}

	public void LoadColosseumSnapshot(PlayerSnapshot snapshot)
	{
	}

	public void LoadColosseumPrivateSnapshot(PlayerPrivateSnapshot snapshot)
	{
	}

	public void AddFieldGridUpdated()
	{
	}

	public void RemoveFieldGridUpdated()
	{
	}

	public void ClearPools()
	{
	}

	public void RemoveObstacle(ObstacleUnit unit)
	{
	}
}
