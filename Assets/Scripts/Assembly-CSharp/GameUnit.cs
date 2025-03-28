using System;
using System.Collections.Generic;
using AwesomeData.Encrypted;
using Awesomepiece.Model;
using CodeStage.AntiCheat.ObscuredTypes;
using DG.Tweening;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class GameUnit : MonoBehaviour
{
	private struct GameUnitEffectKey : IEquatable<GameUnitEffectKey>
	{
		public ResourceUnit resUnit;

		public ResourceSkin resSkin;

		public string type;

		public int animatorInt;

		public bool Equals(GameUnitEffectKey other)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}

	private struct SkillEffectKey : IEquatable<SkillEffectKey>
	{
		public ResourceSkill resSkill;

		public ResourceUnit.Potential potential;

		public ResourceSkin resSkin;

		public string type;

		public int animatorInt;

		public bool Equals(SkillEffectKey other)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}

	public struct AttackCallbackInfo
	{
		public int attackIdx;

		public int attackCount;

		public bool ignoreAddMana;
	}

	private struct SplashInfo
	{
		public bool isSplash;

		public bool splashRoot;

		public Vector2Int splashRootPos;

		public Vector2Int spalshDir;

		public ChainInfo chainInfo;

		public BoltInfo boltInfo;
	}

	private struct ChainInfo
	{
		public int chainIdx;

		public int maxChainCount;
	}

	public enum ReviveCategory
	{
		Unit = 0,
		Item = 1,
		Treasure = 2
	}

	public struct ReviveInfo
	{
		public float reviveHpPer;

		public float reviveManaPer;

		public float reviveTime;

		public Action onRevive;
	}

	public struct StageStartData
	{
		public int id;

		public ResourceUnit resUnit;

		public int level;
	}

	public struct KnockBackData
	{
		public GameUnit from;

		public int value;

		public Vector2Int dir;

		public ResourceSkill resKnockBackSkill;
	}

	public static int UniqueIdCounter;

	public static readonly Vector3 DRAG_ANGLE;

	public static List<Vector2Int> ZeroTileSize;

	public string currentPrefabName;

	public GameObject unitPrefab;

	public Rigidbody2D rigidbody;

	public UnitController controller;

	public Gauge hpGauge;

	public Gauge manaGauge;

	public Gauge overManaGauge;

	public Gauge techniqueGauge;

	[CanBeNull]
	public Gauge buffGauge;

	public GaugeMarker buffGaugeMarker;

	public Gauge groggyGauge;

	public Image[] itemCountObj;

	public CanvasGroup itemCountGroup;

	public SayBalloon sayBalloon;

	public RectTransform equipPanelRoot;

	public BuffPanel buffPanel;

	public BuffPanel runePanel;

	public Animator hpDestroyAnim1;

	public Animator hpDestroyAnim2;

	public Animator hpDestroyAnim;

	[GetComponent]
	public DragUnit dragUnit;

	public GridObject gridObj;

	public Image levelIcon;

	public Image levelIconBattle;

	public Image levelIconEffect;

	public RogueLikeUnitLevel rogueLikeUnitLevel;

	public Text levelText;

	public GameObject stunObject;

	public GameObject dragHandler;

	public BoxCollider2D buttonCollider;

	public SpriteFlash spriteFlash;

	public Image cloneUnitIcon;

	public Text nameText;

	protected int _uid;

	[HideInInspector]
	public AwesomeInt hp;

	[HideInInspector]
	public AwesomeInt maxHp;

	[HideInInspector]
	public AwesomeInt shield;

	[HideInInspector]
	public AwesomeInt mana;

	[HideInInspector]
	public AwesomeInt maxMana;

	[HideInInspector]
	public AwesomeInt overMana;

	[HideInInspector]
	public AwesomeInt lastOverMana;

	[HideInInspector]
	public AwesomeInt technique;

	[HideInInspector]
	public AwesomeInt maxTechnique;

	private int _usedMana;

	private bool _useOverMana;

	[HideInInspector]
	public AwesomeInt atk;

	[HideInInspector]
	public AwesomeInt matk;

	[NonSerialized]
	public EncryptedFloat def;

	[NonSerialized]
	public EncryptedFloat mdef;

	[HideInInspector]
	public GameUnit target;

	[HideInInspector]
	public GameUnit fixedTarget;

	[HideInInspector]
	public GameUnit firstFixedTarget;

	[HideInInspector]
	public bool firstFixedTargetSet;

	[HideInInspector]
	public bool live;

	[HideInInspector]
	public bool initializedForBattle;

	private bool _died;

	public BuffManager buffManager;

	public List<(string, Buff)> buildingBindBuffs;

	[HideInInspector]
	public bool hide;

	[HideInInspector]
	public float speed;

	protected float speedRatio;

	protected float additionalSpeedRatio;

	private bool _isAttacking;

	private bool _isSkillAttacking;

	private bool _isMoving;

	private bool _paused;

	public bool isField;

	public bool equipable;

	public bool isClone;

	public bool isMimic;

	public bool fromInvade;

	public bool positionConfirmed;

	private bool _dieWhenParentDead;

	public bool lockSkillExceptAttackSkill;

	public bool canUseSkillOnlyOnce;

	public bool usedSkillOnce;

	public bool dontShowLevelupEffect;

	public bool dontUpdateMaxHp;

	public bool cantAttackUntilUseSkill;

	private float _stunTime;

	private float _fearTime;

	private float _charmTime;

	private float _iceTime;

	private float _silenceTime;

	private float _channelingTime;

	private float _tauntTime;

	public int icedBySkillId;

	private float _totalChannelingTime;

	public float forceNextChannelingTime;

	private float _moveStopTime;

	private AwesomeInt _level;

	private int _boss;

	private AwesomeInt _team;

	private AwesomeInt _originalTeam;

	public Vector2Int dir;

	private float _moveStunTime;

	private float _originSpeed;

	public BaseAI ai;

	private List<Vector2Int> _path;

	public ResourceUnit resUnit;

	public ResourceSkill resSkill;

	public int currentDisposableSkillID;

	public int mimicTargetSkillID;

	public ResourceSkill resComboAttackSkill;

	public bool canUseComboAttackSkill;

	public ResourceSkill curChannelingSkill;

	private bool _reUsingSkill;

	private float _reUsingSkillRatio;

	public int enableWhiteDamageDrain;

	private List<(int id, int weight)> _randomSkills;

	private (GameUnit gameUnit, int skillID) _strongestSkillHaveBeenDamaged;

	private int _strongestSkillDamage;

	private bool _forceAttackSkillID;

	private int _forcedAttackSkillID;

	private bool _isSkillArrowShooted;

	private int _prevRandomSkillID;

	private bool _hasMainBuffSkill;

	[NonSerialized]
	public Arrow lastHitArrow;

	private static Dictionary<GameUnitEffectKey, IReadOnlyList<ResourceSkill.Effect>> _gameUnitEffectsCache;

	private static Dictionary<SkillEffectKey, IReadOnlyList<ResourceSkill.Effect>> _skillEffectsCache;

	private List<GameObject> _attachedUnitEffects;

	private List<SpriteRenderer> _attachedUnitEffectRenderers;

	private List<(int, List<ResourceUnit.Potential>)> _potentialsTargetSkillCache;

	private Color _manaColor;

	private Color _maxManaColor;

	private Color _techniqueColor;

	private Color _maxTechniqueColor;

	private Color _channelingColor;

	private Color _channelingEndColor;

	private float _moveRatio;

	private Vector2Int _moveDir;

	private Action _attackCallback;

	private Action _onUseManaOrCasting;

	public Action afterSkillCallback;

	public Action<GameUnit, Vector2Int, Vector2Int> moveCallback;

	private Action _lastAttackCallback;

	private int _lastAttackCallbackCount;

	private int _lastAttackSkillAttackCount;

	private Queue<int> _combinationSkillQueue;

	private ObscuredInt _attackCount;

	private int _attackIdx;

	public int normalDamageCounter;

	public int skillDamageCounter;

	private Dictionary<int, AttackCallbackInfo> _attackCallbackIdxDict;

	private int _skillIdx;

	private int _currentSkillIdx;

	private Dictionary<int, int> _skillCallbackIdxDict;

	private ObscuredInt _randomChangeSkillIdx;

	private Dictionary<int, List<GameUnit>> _prevAttackTargetDict;

	private float _attackDelay;

	private float _skillAttackDelay;

	private bool _skillObservableCompleted;

	private int _lastSkillAttackCount;

	private IDisposable _skillObservable;

	private Queue<ulong> _channelingSkillWorkTimers;

	public Queue<ulong> itemWorkTimers;

	private List<(int, ulong)> _tickSkillWorkTimers;

	private Queue<Vector2Int> _tileAttackPosQueue;

	private AudioObject _skillSound;

	private string _skillSoundID;

	private Tween _rushTween;

	private bool _removeHeal;

	private bool _reviving;

	public Action onReviveComplete;

	private float _addDamageMultCooltimeTimer;

	private Dictionary<int, float> _baseAtkSkillCooltime;

	private List<(float per, bool withAttackInterval)> _statPerList;

	private bool _transformed;

	private float _transformTime;

	private float _transformTimer;

	public List<GameUnit> summonedUnits;

	public List<GameUnit> summonedUnitsRestored;

	public GameUnit parentUnit;

	public GameUnit originParentUnit;

	public bool isSummoned;

	public List<GameUnit> totemSummonedUnit;

	protected Vector3 _originScale;

	protected int _roguelikeScaleMode;

	public Vector2Int tilePos;

	public List<Item> items;

	public List<Rune> runes;

	public bool blockDefDenTrigger;

	public bool blockHealTrigger;

	private ObscuredInt _cardLevel;

	public RangeInfo changedSkillRange;

	private List<UnitEffect> _effects;

	private List<UnitEffect> _worldEffects;

	private List<GameUnit> _inAreaEffectTargets;

	public Dictionary<int, Dictionary<int, int>> knockbackLimitDict;

	public Dictionary<int, Dictionary<int, int>> hitCountDict;

	private int _sameTargetHitCount;

	private GameUnit _lastHitTarget;

	private readonly Dictionary<string, int> _effectCountDict;

	private readonly List<(DamageInfo.BlockedBy type, GameObject prefab)> _superShieldEffects;

	private List<(string, GameObject)> _loopEffectsToBeTriggered;

	private List<ulong> _timersToCompleteWhenDie;

	private Damage _lastDamageObj;

	private int _lastDamageId;

	[HideInInspector]
	public ObscuredLong physicalDamageSum;

	[HideInInspector]
	public ObscuredLong magicDamageSum;

	[HideInInspector]
	public ObscuredLong specialDamageSum;

	[HideInInspector]
	public ObscuredLong physicalDamagedSum;

	[HideInInspector]
	public ObscuredLong magicDamagedSum;

	[HideInInspector]
	public ObscuredLong specialDamagedSum;

	[HideInInspector]
	public AwesomeInt damagedSumBeforeCastSkill;

	[HideInInspector]
	public AwesomeInt damagedSumDuringChanneling;

	public AwesomeInt consumeHpSum;

	public float buffDamageReducedSum;

	public Dictionary<ReviveCategory, Queue<ReviveInfo>> reviveData;

	private static float _debugColorIdx;

	private Color _debugColor;

	private Vector2 _basePos;

	private int _superShield;

	private int _superMAtkShield;

	public List<BoltInfo> itemBolts;

	public GameUnit killedBy;

	private int _tileMoveWaitFrame;

	private List<ResourceUnit.Potential> _potentials;

	private Vector3 _originActorPos;

	private Vector3 _originShadowPos;

	private Vector3 _customOffset;

	public bool isSummoning;

	public bool isGrabbed;

	public bool isKnockbacking;

	public bool canKnockBack;

	public Vector2Int currentKnockBackDir;

	public bool isFearing;

	public bool isCharming;

	public bool isIcing;

	public bool isSilencing;

	public bool isTaunting;

	public GameUnit tauntedFrom;

	public GameUnit healTauntedFrom;

	private bool _forceSilenced;

	public List<GameUnit> defDenListCurrentFrame;

	private bool _attackFlag;

	private int _skillKillFlag;

	private int _lastSkillKillDamage;

	private int _lastSkillKillFlag;

	private float _beforeTransformHpPer;

	private float _invincibleTime;

	private float _untargetableTime;

	private float _stopTime;

	private bool _canDeathSkill;

	private bool _canInvincibleBlockCC;

	private IDisposable _unitDeadDisposable;

	private IDisposable _unitHardCCDisposable;

	public bool alreadyAppeared;

	private List<GameUnit> _preGrabTargets;

	private List<GameUnit> _preFearTargets;

	private List<GameUnit> _preCharmTargets;

	private List<GameUnit> _preIceTargets;

	private GameObject _fearObject;

	private GameObject _charmObject;

	private GameObject _iceObject;

	private GameObject _silenceObject;

	private List<GameUnit> _tauntTargets;

	private GameObject _tauntObject;

	private GameObject _tempEffectObject;

	private TotemUnit _totemUnit;

	private List<TotemUnit> _connectedTotemUnits;

	private List<TotemUnit> _myTotemUnits;

	private int[] _buildingLevels;

	private ResourceBuilding[] _usingResBuilding;

	private Queue<KnockBackData> _knockBackQueue;

	private bool _isChainSkillEnd;

	private int _chainObjectCount;

	private List<GameUnit> _firstAtked;

	private List<GameUnit> _firstTargeted;

	private Vector3 _diePosition;

	public ResourceSkin resSkin;

	private Dictionary<string, int> _artifactOptionSumCache;

	private Dictionary<string, float> _artifactValueSumCache;

	private Dictionary<string, float> _artifactValueProductCache;

	private int _poolIdx;

	public bool overKillSplashFlag;

	private int _attackInt;

	private int _maxAttackInt;

	private bool _useAttackInt;

	private bool _useAttackIntWhenBuff;

	private bool _useAttackIntWhenSkill;

	private bool _shootEffectByAttackInt;

	private bool _shootEffectByAttackIntWhenBuff;

	private bool _targetEffectByAttackInt;

	private bool _targetEffectByAttackIntWhenBuff;

	private bool _selfEffectByAttackInt;

	private int _prevMaxAttackInt;

	private int[] _maxAttackIntsPerTierWhenBuff;

	private int _skillInt;

	private int _maxSkillInt;

	private bool _useSkillInt;

	private bool _useSkillIntWhenBuff;

	private int _useSkillIntWhenBuffId;

	private bool _targetEffectBySkillInt;

	private bool _targetEffectBySkillIntWhenBuff;

	private bool _isFullStack;

	private int _killInt;

	private int _maxKillInt;

	private bool _useKillInt;

	private float _addedAtkPerByEmptyItemSlot;

	private float _addedMAtkPerByEmptyItemSlot;

	private float _addedAtkSpeedPerByEmptyItemSlot;

	private float _addedTotalAtkPerByItemSlot;

	private int _comboCount;

	private int _extraComboCount;

	private bool _healable;

	private AwesomeInt _initBuildingHp;

	private float _addedSkillTimeAtKill;

	private int _potentialSlot;

	private int _potentialTier;

	public bool canBeRented;

	private int _cloneKillGoldBonus;

	public bool ignoreBuildingStatBuff;

	public AwesomeInt nextAttackAddSkillDamageLeftCount;

	public EventTriggerManager.UnitAlarmData unitAlarmData;

	public int skillAttackCounter;

	public int skillAttackCountEventCountSubtracter;

	public int checkSkillAttackCountByItem;

	public int skillAttackCountByItem;

	private EncryptedFloat[] _territoryStatBuffs;

	public int addRestHealPer;

	private int _stageKilledUnitValueSum;

	public bool forceNoHpGauge;

	public float splashDamageByMaxHpPerAtAttackCoolTime;

	public int reflectPerToAllEnemy;

	private int _removedBuffSkillId;

	public EventTriggerManager.UnitAlarmTriggeredData unitAlarmTriggeredData;

	public int battleManagerIdx;

	private List<Item> _waitingForSelectItems;

	public TreasureModel treasure;

	public List<AccessoryModel> accessories;

	public Dictionary<int, float> buffOptionTargetCooltime;

	private static Color32 UnitBarColor;

	private static Color32 UnitBarTrailColor;

	private static Color32 EnemyBarColor;

	private static Color32 EnemyBarTrailColor;

	private static ulong _skillEndTimerHash;

	private static ulong _showAfterImageHash;

	private static ulong _tickHash;

	private static ulong _inAreaEffectHash;

	private int _dirChangeWaitFrame;

	private Vector2Int _lastTargetPos;

	private static List<Vector2Int> _rangePosList;

	private ResourceSkill _curControllerSkill;

	private List<ulong> _reviveTimers;

	private static List<(GameUnit, RangeInfo)> _staticDamageReductionBuffUnits;

	private List<Tween> _tileEffects;

	private List<Animator> _tileEffectAnims;

	private List<GameUnit> _nearestTargetList;

	private List<int> _nearestTargetVisitedList;

	private Tweener _levelEffect;

	public Tweener knockBackTweener;

	public Tweener grabTweener;

	private List<(ulong WorkerID, string name)> _delayedEffects;

	public List<(ulong WorkerID, string name)> timedBuffOptionEffects;

	private static List<GameUnit> _checkCancelSkillTriggersList;

	private const int MaxTier = 4;

	public Gauge buffGaugeOrBossBuffGauge => null;

	public int maxOverMana => 0;

	public bool useOverMana => false;

	public bool dieWhenParentDead
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public float channelingTime => 0f;

	public bool isChanneling => false;

	public float fearTime => 0f;

	public int originalTeam => 0;

	public List<Vector2Int> path => null;

	public int id => 0;

	public float hpPer => 0f;

	public bool isAttacking => false;

	public bool isSkillAttacking => false;

	public bool isMoving => false;

	public int level => 0;

	public int boss => 0;

	public bool finalBoss => false;

	public bool useGroggyBar => false;

	public int team => 0;

	public bool isPlayerUnit => false;

	public float sizeRatio => 0f;

	public float height => 0f;

	public float heightOffset => 0f;

	public bool playDefaultHit => false;

	public bool isStunning => false;

	public float ccRatio => 0f;

	public int attackIdx => 0;

	public Dictionary<int, AttackCallbackInfo> attackCallbackIdxDict => null;

	public bool isRushing => false;

	public bool reviving => false;

	public List<(float per, bool withAttackInterval)> statPerList => null;

	public bool transformed => false;

	public int cardLevel => 0;

	public RangeInfo atkRange => null;

	public RangeInfo skillRange => null;

	public RangeInfo buffRange => null;

	public bool hasSummonedUnit => false;

	public List<UnitEffect> effects => null;

	public long allDamageSum => 0L;

	public long allDamagedSum => 0L;

	public Color debugColor => default(Color);

	public int superShield => 0;

	public int superMAtkShield => 0;

	private float _buffChannelingTime
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public bool isInvincible => false;

	public bool isStop => false;

	public bool isTotemConnected => false;

	public int[] buildingLevels => null;

	public List<ArtifactModel> artifacts { get; set; }

	public int poolIdx => 0;

	public int potentialSlot => 0;

	public int potentialTier => 0;

	public bool hpRatioTriggered { get; private set; }

	public virtual Vector3 pos => default(Vector3);

	public int stageKilledUnitValueSum => 0;

	public BattleManager battle => null;

	public static void ClearEffectListCache()
	{
	}

	public void Init(int id, int team, int level = -1, int cardLevel = 1, int[] buildingLevels = null, int skin = 0, List<ArtifactModel> artifacts = null, int poolIdx = -1, int potentialSlot = -1, int potentialTier = 0, int battleManagerIdx = 0, TreasureModel treasureModel = null, List<AccessoryModel> accessoryModels = null)
	{
	}

	public void InitLevelIcon()
	{
	}

	public void RefreshLevelIcon()
	{
	}

	public void ShowLevelIcon(bool show)
	{
	}

	public void ReloadLevelIcon()
	{
	}

	public void ReloadCardLevel()
	{
	}

	public void SetCardLevel(int cardLevel)
	{
	}

	private void UpdatePotential()
	{
	}

	public void ReloadPotential()
	{
	}

	public void ReloadPotentialTier()
	{
	}

	private bool CanReloadCardStat()
	{
		return false;
	}

	protected bool SetResourceUnit(ResourceUnit resUnit, int level, int skin = 0, bool reloadSuperShield = true)
	{
		return false;
	}

	public void SetArtifactUnitTeam(int team)
	{
	}

	public void SetTeam(int team, bool isOriginalTeam = false)
	{
	}

	public void ShowHpGauge(bool show, bool updateHeight = true)
	{
	}

	private void UpdateSize()
	{
	}

	private void UpdateHeight(float height = -1f)
	{
	}

	public void ResetUnitPrefabPos()
	{
	}

	private void ShowFearObject(bool v, string fearEffect = null)
	{
	}

	private void ShowCharmObject(bool v, string charmEffect = null)
	{
	}

	private void ShowIceObject(bool v, string iceEffect = null)
	{
	}

	private void ShowSilenceObject(bool v, string silenceEffect = null)
	{
	}

	private void ShowTauntObject(bool v, string tauntEffect = null)
	{
	}

	protected void SetUnitPrefab(string prefabName)
	{
	}

	public void Update()
	{
	}

	public void FixedUpdate()
	{
	}

	public virtual void UpdateImpl()
	{
	}

	private void UpdateChannelingBar()
	{
	}

	private void ResetChannelingBar()
	{
	}

	private void UpdateInvincibleTimers()
	{
	}

	private void UpdateCCTimers()
	{
	}

	private void UpdateAITimers()
	{
	}

	public void CancelChannelingSkill()
	{
	}

	public void CancelMotion()
	{
	}

	public void ForceCancelSkill()
	{
	}

	public bool CancelConnectBuff(ResourceSkill skill)
	{
		return false;
	}

	private void ReleaseTauntUnits()
	{
	}

	private void HandleTauntingUnitDead(GameUnit tauntTarget)
	{
	}

	private void HandleCursedUnitDead(GameUnit from)
	{
	}

	private void HandleHasBeadUnitDead()
	{
	}

	private void StopSkillTimers(bool stopPrevDelayTimerOnly = false, bool stopTileTick = true)
	{
	}

	private void StopTileTick(bool clearTileEffect = false)
	{
	}

	public void SetTarget(GameUnit target, bool fixedTarget = false, bool ignoreTaunt = false)
	{
	}

	public void SetTilePosition(Vector2Int pos)
	{
	}

	public void CheckTransformCondition(bool showEffect = true)
	{
	}

	private int GetTransformConditionResult()
	{
		return 0;
	}

	public void SetPosition(Vector2 pos, bool force = false)
	{
	}

	public void SnapToGrid()
	{
	}

	public virtual void Move(Vector2 dir, bool runAnim = true)
	{
	}

	private void TileMoveUpdate()
	{
	}

	public bool TileMove(Vector2Int dir, Action callback = null)
	{
		return false;
	}

	public void SetDirection(Vector2Int dir)
	{
	}

	public void SetFront()
	{
	}

	public void SetBack()
	{
	}

	public void MoveTo(Vector2 pos)
	{
	}

	public void SetPathNode(List<Vector2Int> tilePath)
	{
	}

	public void MoveToTilePos(Vector2Int pos)
	{
	}

	public bool MoveToTargetRange(GameUnit target, RangeInfo range)
	{
		return false;
	}

	protected Vector2 GetMoveVector(Vector2 dir, float dt = -1f)
	{
		return default(Vector2);
	}

	public Vector2 GetMovedPosition(Vector2 dir)
	{
		return default(Vector2);
	}

	public virtual void MoveSetPosition(Vector2 dir)
	{
	}

	public virtual void Stop()
	{
	}

	public void StopTileMove()
	{
	}

	private bool CheckNextPath()
	{
		return false;
	}

	public void PathUpdate()
	{
	}

	public virtual void StopAndIdle()
	{
	}

	public virtual void SetFlip(bool right)
	{
	}

	public void SetRogueLikeScaleMode(int roguelikeScaleMode)
	{
	}

	public bool Attack(GameUnit targetUnit)
	{
		return false;
	}

	private void MakeTargetDamaged(DamageInfo damageInfo, GameUnit targetUnit, int attackCountIdx, List<Buff> buffList = null)
	{
	}

	public bool CanUseSkill()
	{
		return false;
	}

	public bool CanUseSkillImpl(ResourceSkill resSkill)
	{
		return false;
	}

	public List<GameUnit> GetCandidatesFromTargetType(ResourceSkill.TargetType targetType, int myTeam = -1)
	{
		return null;
	}

	public void UpdateRange()
	{
	}

	public void HandleAttackRangeChanged()
	{
	}

	public List<GameUnit> FindSkillTargets(ResourceSkill resSkill, bool containsGrabbed = true, bool containsFeared = true, List<GameUnit> except = null, int myTeam = -1)
	{
		return null;
	}

	public List<GameUnit> FindTargetsInRange(List<GameUnit> candidates, RangeInfo rangeInfo, int maxTargetCount, bool containsGrabbed = true, bool containsFeared = true, bool containsCharmed = true, bool containsIced = true, bool containsTaunted = true, bool ignoreHide = false, bool ignoreTargetable = false, ResourceSkill.AtkType atkType = ResourceSkill.AtkType.Melee, ResourceSkill.TargetType targetType = ResourceSkill.TargetType.None, List<GameUnit> except = null, Vector2Int dir = default(Vector2Int), List<GameUnit> returnList = null, bool ignoreUntargetable = false, bool ignoreFixedTarget = false)
	{
		return null;
	}

	private float GetSplashDamageDelay(ResourceSkill resSkill, Vector2Int centerPos, Vector2 targetPos)
	{
		return 0f;
	}

	private void GetSplashDirRangeBasePos(ResourceSkill resSkill, GameUnit target, Vector2Int? skillUsingPos, Vector2Int startTilePos, out Vector2Int splashDir, out RangeInfo splashRange, out Vector2Int basePos)
	{
		splashDir = default(Vector2Int);
		splashRange = null;
		basePos = default(Vector2Int);
	}

	private (List<GameUnit>, Vector2Int) FindSkillSplashTargets(ResourceSkill resSkill, List<GameUnit> candidate, Vector2Int startTilePos, GameUnit mainTarget = null, Vector2Int? skillUsingPos = null, bool includeMainTarget = false)
	{
		return default((List<GameUnit>, Vector2Int));
	}

	public bool CheckValidTarget(ResourceSkill resSkill, GameUnit mainTarget, GameUnit searchedTarget, bool includeMainTarget)
	{
		return false;
	}

	private List<Vector2Int> FindSkillEmptySplashTargetPos(ResourceSkill resSkill, List<GameUnit> searchedTargets, Vector2Int startTilePos, GameUnit mainTarget = null, Vector2Int? skillUsingPos = null)
	{
		return null;
	}

	private List<Vector2Int> FindSkillSplashPos(ResourceSkill resSkill, Vector2Int startTilePos, GameUnit mainTarget = null, Vector2Int? skillUsingPos = null)
	{
		return null;
	}

	public GameUnit FindLowestHpPer(ResourceSkill.TargetType targetType)
	{
		return null;
	}

	public GameUnit FindFrontest(ResourceSkill.TargetType targetType)
	{
		return null;
	}

	public List<GameUnit> FindChainTargets(List<GameUnit> targets, ResourceSkill resSkill, List<GameUnit> except, GameUnit currentTarget, bool forceSearchSameTeam = false)
	{
		return null;
	}

	public List<GameUnit> FindSkillTargetsIgnoreRange(ResourceSkill resSkill, List<GameUnit> searchTargets, int maxTargetCount, List<GameUnit> except = null)
	{
		return null;
	}

	private void Trigger(ResourceSkill skill)
	{
	}

	private List<GameUnit> GetSkillTargetsIncludeState(ResourceSkill resSkill)
	{
		return null;
	}

	public bool UseSkill(int id = -1, bool forceSelfTrigger = false, List<GameUnit> skillTargets = null, bool isCombinationSkill = false, bool isAddedSkill = false, float addSkillEnergy = 0f, bool useManaOrCasting = false, int forceDmgId = -1)
	{
		return false;
	}

	private void ChainArrowTo(GameUnit firstTarget, ResourceSkill chainSkill, Arrow.Type type = Arrow.Type.Homing, string arrowPrefab = null, DamageInfo damageInfo = default(DamageInfo), float arrowSpeed = 400f, float angleOffset = 0f, GameUnit originUnit = null, Action<Arrow, GameUnit, int, int> completeCallback = null)
	{
	}

	private ResourceSkill.TargetType GetChainTargetType(ResourceSkill.TargetType targetType, GameUnit currentTarget)
	{
		return default(ResourceSkill.TargetType);
	}

	private void RemoveBuffAtSkillStart(ResourceSkill resSkill = null)
	{
	}

	private void RemoveBuffAtSkill(ResourceSkill resSkill = null)
	{
	}

	private (List<GameUnit>, List<Vector2Int>) GetPathTargets(ResourceSkill resourceSkill, GameUnit mainTarget, Vector2Int tilePos)
	{
		return default((List<GameUnit>, List<Vector2Int>));
	}

	private bool MoveSkill(ResourceSkill moveSkill, List<GameUnit> targets)
	{
		return false;
	}

	private bool IsTargetsAttackable(List<GameUnit> targets)
	{
		return false;
	}

	private void UseCloneSkill(ResourceSkill cloneSkill, GameUnit target)
	{
	}

	public void UseCombinationSkill(int skillID)
	{
	}

	private void ApplyCCAndDebuff(GameUnit target, ref DamageInfo damageInfo)
	{
	}

	public void HandleGiveHardCC(GameUnit target, ref DamageInfo damageInfo)
	{
	}

	private void HandleObserveTakeHardCC((GameUnit from, GameUnit to, DamageInfo) param)
	{
	}

	public void HandleTakeHardCC(GameUnit from, ref DamageInfo damageInfo)
	{
	}

	private int ApplyKnockback(ResourceSkill resSkill, GameUnit target)
	{
		return 0;
	}

	private void ReleasePreTargetCategories(GameUnit target, ref DamageInfo damageInfo)
	{
	}

	private void ApplyCurse(GameUnit target, ResourceSkill buffSkill)
	{
	}

	public static List<Vector2Int> GetRangePos(Vector2Int basePos, RangeInfo range, Vector2Int dir = default(Vector2Int))
	{
		return null;
	}

	public static bool CheckRange(Vector2Int basePos, Vector2Int targetPos, RangeInfo range, Vector2Int dir = default(Vector2Int))
	{
		return false;
	}

	public bool CheckRangeTo(Vector2Int basePos, GameUnit target, RangeInfo range, Vector2Int dir = default(Vector2Int))
	{
		return false;
	}

	public bool CheckRangeTo(GameUnit target, RangeInfo range, Vector2Int dir = default(Vector2Int))
	{
		return false;
	}

	public bool CheckMaxAtkRange(GameUnit target, bool skill)
	{
		return false;
	}

	public virtual void HandleEvent(string eventName)
	{
	}

	private void HandleSkillEnd()
	{
	}

	private bool HandleShootSkill(ResourceSkill resSkill = null, Action attackCallback = null, Action onUseManaOrCasting = null, bool isAddedSkill = false)
	{
		return false;
	}

	private void HandleStartChannelingSkill(ResourceSkill channelingSkill)
	{
	}

	private void HandleChannelingEnd(int skillID)
	{
	}

	private void ForceCastChannelingSkill()
	{
	}

	private void HandleShootSkillInner(Action skillCallback = null, int attackCount = -1, bool invokeAfterSkillCallback = true)
	{
	}

	private void HandleAddAttackSkill(List<GameUnit> splashTargets = null, DamageInfo damageInfo = default(DamageInfo), List<Buff> buffs = null, bool checkIsAttacking = true)
	{
	}

	public float GetExtraDamagePerBuff()
	{
		return 0f;
	}

	public float GetExtraTotalDamagePerBuff()
	{
		return 0f;
	}

	public float GetExtraTakeDamagePerBuff()
	{
		return 0f;
	}

	public float GetExtraHybridBaseDef()
	{
		return 0f;
	}

	public float GetExtraTotalTakeDamagePerBuff()
	{
		return 0f;
	}

	public void AdjustBeforeDamaged(ref DamageInfo damageInfo, GameUnit from)
	{
	}

	private Vector3? SetBlocked(ref DamageInfo damageInfo, DamageInfo.BlockedBy type)
	{
		return null;
	}

	private Vector3? CheckBlockDamage(ref DamageInfo damageInfo, GameUnit from)
	{
		return null;
	}

	private void OverwriteDamage(ref DamageInfo damageInfo, GameUnit from)
	{
	}

	private void ApplyHpRatioTriggers(ref DamageInfo damageInfo, [CanBeNull] GameUnit from)
	{
	}

	private (bool, bool) PrepareReviveIfCan()
	{
		return default((bool, bool));
	}

	public bool CheckRevive()
	{
		return false;
	}

	private (bool, bool) ApplyDamage(ref DamageInfo damageInfo, GameUnit from)
	{
		return default((bool, bool));
	}

	private void UnlockPreCCFlags()
	{
	}

	public float GetExtraMissRatio()
	{
		return 0f;
	}

	public float GetMissRatio()
	{
		return 0f;
	}

	public void Damaged(DamageInfo damageInfo, GameUnit from, bool forceShowHitEffectOnDeadUnit = false)
	{
	}

	private void ReviveImpl()
	{
	}

	public float GetBaseExecutionPer()
	{
		return 0f;
	}

	public float GetExecutionPer()
	{
		return 0f;
	}

	private void HandleFirstAttack(GameUnit from, bool blockCC)
	{
	}

	public bool CheckAdjacent(GameUnit from)
	{
		return false;
	}

	private GameUnit FindDamageReductionBuffUnit()
	{
		return null;
	}

	private void ResetBuffs()
	{
	}

	public void EndAllCC()
	{
	}

	public void Stun(GameUnit from, float time, bool sound = true, bool ignoreCCRatio = false, bool showStunObj = true)
	{
	}

	public void EndStun()
	{
	}

	public void Fear(float time, int slow, string fearEffect = "Fx_20630d")
	{
	}

	public void EndFear(bool checkStageEnd = true)
	{
	}

	public void Charm(float time, string charmEffect = "Fx_20730e", bool ignoreCCRatio = false)
	{
	}

	public void EndCharm(bool checkStageEnd = true)
	{
	}

	public void Ice(float time, ResourceSkill iceSkill, GameUnit from, string iceEffect = "Fx_20830c")
	{
	}

	public void EndIce(bool checkStageEnd = true)
	{
	}

	public void Silence(float time, bool force, string silenceEffect = "Fx_20830c")
	{
	}

	public void EndSilence(bool checkStageEnd = true)
	{
	}

	public void Taunt(GameUnit tauntTo, float time = 1f, string tauntEffect = "Fx_Taunt", ResourceSkill resSkill = null)
	{
	}

	public void EndTaunt()
	{
	}

	public void SetInvincible(bool set, float sec = 0f, bool canBlockCC = false, bool removeHeal = true, GameUnit from = null)
	{
	}

	public void SetUntargetable(bool set, float sec = 0f, GameUnit from = null)
	{
	}

	public void InstantDie()
	{
	}

	public void Die(bool reward = true, bool deathSkill = true, bool suicide = false, GameUnit from = null, bool doNotTreatAsDead = false, bool disableEffect = false)
	{
	}

	public void HandleUnitDead((GameUnit unit, GameUnit from) param)
	{
	}

	private void DieAnim(bool disableEffect = false)
	{
	}

	public void DestroySummonedUnits(bool isDead = false)
	{
	}

	public void RemoveAllEffects(bool includeLoopEffect = false)
	{
	}

	private void CheckBuildingEffectsWhenDie(GameUnit from)
	{
	}

	private void ShootMySkillEffect()
	{
	}

	private void RemoveMySkillEffect()
	{
	}

	public virtual void Revive()
	{
	}

	public void StopEffectAtSkillEnd()
	{
	}

	public void ShootLoopEffectTrigger(string type)
	{
	}

	public void ShootLoopEffectByeTrigger()
	{
	}

	public GameObject ShowEffect(string prefab, Vector3 offset = default(Vector3), Vector3 scale = default(Vector3), float rotation = 0f, bool world = false, bool loop = false, ResourceSkill resSkill = null, ResourceSkill.Effect resEffect = default(ResourceSkill.Effect))
	{
		return null;
	}

	public void AddTimerToCompleteWhenDie(ulong key)
	{
	}

	public UnitEffect? GetEffect(string prefab)
	{
		return null;
	}

	public void ShootByeTriggerToEffect(string prefab)
	{
	}

	public void RemoveEffect(string prefab, bool destroy = true)
	{
	}

	public void RemoveDelayedEffect(string prefab = null, bool destroy = true)
	{
	}

	public void RemoveTimedBuffOptionEffect(string prefab = null, bool destroy = true)
	{
	}

	public void RemoveSkillEffect(ResourceSkill skill, bool destroy = true)
	{
	}

	public void RemoveSkillEffectIfNotHasSkill(ResourceSkill skill, bool destroy = true)
	{
	}

	public void AttachEffect(GameObject go, string prefabName, bool loop = false)
	{
	}

	public void ShowTileEffect(ResourceSkill skill, GameUnit target, Vector2Int prevPos, Vector2Int? skillUsingPos = null)
	{
	}

	public void ShowGiveBuffTileEffect(Buff parent, string prefab, bool disposeOnly = false)
	{
	}

	public void ShowEffects(IReadOnlyList<ResourceSkill.Effect> effects, ResourceSkill resSkill = null, Vector2 dir = default(Vector2), Vector2 pos = default(Vector2), bool useOtherPos = false, List<GameObject> returnList = null)
	{
	}

	public GameObject ShowEffect(ResourceSkill.Effect effect, ResourceSkill resSkill = null, Vector2 dir = default(Vector2), Vector2 pos = default(Vector2), GameUnit from = null)
	{
		return null;
	}

	public GameObject ShowEffect(ResourceSkill.Effect effect, float sizeRatio, Vector2 dir, int addDirBlend = 0, ResourceSkill resSkill = null, int attackCount = 0, Vector2 pos = default(Vector2), GameUnit from = null)
	{
		return null;
	}

	public GameObject ShowEffect(ResourceSkill.Effect effect, float sizeRatio, Vector2 dir, bool useOtherPos, Vector2 pos, int addDirBlend = 0, ResourceSkill resSkill = null, int attackCount = 0, GameUnit from = null, float customScale = 1f)
	{
		return null;
	}

	public void ShootProjectileEffectsTo(GameUnit target, ResourceSkill.Effect effect, DamageInfo damageInfo)
	{
	}

	public void UpdateMaxMana()
	{
	}

	public void SetMaxMana(int value)
	{
	}

	public void UpdateMaxTechnique()
	{
	}

	public void SetMaxTechnique(int value)
	{
	}

	public float GetExtraHpPerBuff()
	{
		return 0f;
	}

	public void UpdateHp(bool heal = false, bool forceHealHpDiff = false)
	{
	}

	public virtual void SetMaxHp(int value, bool heal, bool forceHealHpDiff = false)
	{
	}

	public void UpdateShield()
	{
	}

	public void UpdateDef()
	{
	}

	public void ReloadBossHpBarDefIndicator()
	{
	}

	public virtual void HealPer(float per)
	{
	}

	public virtual void Heal(int v, GameUnit from = null, bool fromDrain = false, bool force = false, bool forceBlockTrigger = false)
	{
	}

	private float CalculateHealValue(int v, GameUnit from)
	{
		return 0f;
	}

	public virtual void Drain(int v)
	{
	}

	public virtual void SetHp(int value, bool gaugeForce = true)
	{
	}

	public void AddShield(float value, GameUnit from, bool showEffect = false, bool ignoreMasterValueRatio = false, int? shieldLimit = null)
	{
	}

	public float RemoveShieldPer(float perValue, GameUnit from)
	{
		return 0f;
	}

	public float RemoveShield(int value, GameUnit from)
	{
		return 0f;
	}

	private void SetShield(int value, bool reset = false, bool handleShieldBroken = true)
	{
	}

	private void HandleShieldBroken()
	{
	}

	public void InitializeSkillEnergy()
	{
	}

	public void UpdateAndResetSkillEnergy()
	{
	}

	public void ResetSkillEnergy(bool withBase = false, bool withBuilding = true, bool checkOverSkillEnergy = true, bool withArtifact = true)
	{
	}

	public void AddSkillEnergy(int v, bool force = false, bool lockValue = false, bool ignoreAddMana = false, GameUnit from = null)
	{
	}

	public int GetMaxSkillEnergy()
	{
		return 0;
	}

	public void SetMaxSkillEnergy()
	{
	}

	public void SetSkillEnergy(int v)
	{
	}

	public int GetSkillEnergy()
	{
		return 0;
	}

	public Gauge GetSkillEnergyGauge()
	{
		return null;
	}

	public void ResetMana(bool withBase = false, bool withBuilding = true, bool checkOverMana = true, bool withArtifact = true)
	{
	}

	public void AddManaPer(float per, bool force = false)
	{
	}

	public void AddMana(int v, bool force = false, bool lockValue = false, bool ignoreAddMana = false, GameUnit from = null, bool ignoreGauge = false)
	{
	}

	public void ManaHeal(int v, bool force = false, bool shootDamage = true, bool lockValue = false, GameUnit from = null, bool ignoreAddMana = false)
	{
	}

	private void SetManaGauge(int v)
	{
	}

	public void SetMana(int v, bool checkOverMana = true)
	{
	}

	public void ResetTechnique(bool withBase = false)
	{
	}

	public void AddTechnique(int v)
	{
	}

	private void SetTechniqueGauge(int v)
	{
	}

	public void SetTechnique(int v)
	{
	}

	public void SwapManaAndBuffBar()
	{
	}

	public virtual float Distance(GameUnit target)
	{
		return 0f;
	}

	public virtual float TileDistance(GameUnit target, Vector2Int? pos = null)
	{
		return 0f;
	}

	private void SetSpeedRatio(float ratio)
	{
	}

	public void UpdateManaLock()
	{
	}

	public virtual void UpdateMoveSpeed()
	{
	}

	public void UpdateAttackSpeed()
	{
	}

	public float GetExtraAttackSpeedPerBuff()
	{
		return 0f;
	}

	public float GetAttackActionCooltime()
	{
		return 0f;
	}

	public float GetChannelingTime(ResourceSkill channelingSkill = null)
	{
		return 0f;
	}

	public float GetAttackInterval()
	{
		return 0f;
	}

	public float GetBoundedAttackInterval()
	{
		return 0f;
	}

	public void Pause()
	{
	}

	public void Resume()
	{
	}

	public List<GameUnit> GetNearestRandomTargets(int count, List<GameUnit> except = null, int maxDist = -1, bool enemy = true, Func<GameUnit, bool> checkFunc = null)
	{
		return null;
	}

	public List<GameUnit> GetNearestTargetsFromAll(int count, List<GameUnit> except = null, int maxDist = -1, Func<GameUnit, bool> checkFunc = null, Vector2Int? pos = null)
	{
		return null;
	}

	public List<GameUnit> GetNearestTargets(int count, List<GameUnit> except = null, int maxDist = -1, bool enemy = true, Func<GameUnit, bool> checkFunc = null, Vector2Int? pos = null)
	{
		return null;
	}

	public List<GameUnit> GetNearestTargets(int count, List<GameUnit> except, int maxDist, Func<GameUnit, bool> checkFunc, List<GameUnit> targets, Vector2Int? pos)
	{
		return null;
	}

	public List<GameUnit> GetFarthestTargets(int count, List<GameUnit> except = null, bool enemy = true, Func<GameUnit, bool> checkFunc = null)
	{
		return null;
	}

	public List<GameUnit> GetHighestLevelTargets(int count, List<GameUnit> except = null, bool enemy = true, Func<GameUnit, bool> checkFunc = null)
	{
		return null;
	}

	private void HandleTakeDamage(ref DamageInfo damageInfo, GameUnit from, bool reviveOrRestored)
	{
	}

	private void HandleHitUnit(GameUnit target, ref DamageInfo damageInfo)
	{
	}

	private float GetLostHpDrain()
	{
		return 0f;
	}

	private void HandleBoltItem(GameUnit firstTarget, ref DamageInfo damageInfo)
	{
	}

	private void UseBolt(GameUnit firstTarget, Action<GameUnit> callback, in BoltInfo boltInfo, ResourceSkill resBoltSkill = null)
	{
	}

	public void HandleShadowAttack(ref DamageInfo damageInfo, GameUnit targetUnit)
	{
	}

	private void HandleMultiAttack(DamageInfo damageInfo, GameUnit targetUnit, int attackCountIdx)
	{
	}

	private void SetBuffAtSkillEndMaxOverlapSkill(int skillID)
	{
	}

	public void SetComboSkill(int comboSkillID)
	{
	}

	public void SetComboAttackSkill(int skillID = -1)
	{
	}

	public void SetDisposableSkill(int skillID)
	{
	}

	public void ResetDisposableSkill(int skillID, bool force = false)
	{
	}

	private void HandleBeforeKillUnit(GameUnit target, ref DamageInfo damageInfo)
	{
	}

	public virtual void HandleKillUnit(GameUnit target, ref DamageInfo damageInfo)
	{
	}

	public float GetExtraAtkPerBuff()
	{
		return 0f;
	}

	public float GetExtraTotalAtkPerBuff()
	{
		return 0f;
	}

	public virtual int GetAtk()
	{
		return 0;
	}

	public int GetMaxHP()
	{
		return 0;
	}

	public int GetDefaultHp()
	{
		return 0;
	}

	public int GetExtraAtkCountBuff()
	{
		return 0;
	}

	public virtual int GetAtkCount()
	{
		return 0;
	}

	public virtual int GetDescAtkCount()
	{
		return 0;
	}

	public virtual int GetSkillAtkCount(ResourceSkill skill, DamageInfo.Type type, GameUnit target = null, bool isAddedSkill = false)
	{
		return 0;
	}

	private float GetAdditionalAtkSpeedPer()
	{
		return 0f;
	}

	private float GetAdditionalMoveSpeedPer()
	{
		return 0f;
	}

	public void CheckSkillAttackCountBuff()
	{
	}

	private void PrepareReuseSkill()
	{
	}

	public float GetExtraMAtkPerBuff()
	{
		return 0f;
	}

	public virtual int GetMAtk()
	{
		return 0;
	}

	public virtual float GetDefRatio()
	{
		return 0f;
	}

	public float GetDef()
	{
		return 0f;
	}

	public virtual float GetMDefRatio()
	{
		return 0f;
	}

	public float GetMDef()
	{
		return 0f;
	}

	public float GetCriticalProbWithBound(ResourceSkill resSkill = null)
	{
		return 0f;
	}

	public virtual float GetCriticalProb(ResourceSkill resSkill = null)
	{
		return 0f;
	}

	public float GetCriticalDamageMulWithBound()
	{
		return 0f;
	}

	public virtual float GetCriticalDamageMul()
	{
		return 0f;
	}

	public float GetMCriticalProbWithBound(ResourceSkill resSkill = null)
	{
		return 0f;
	}

	public virtual float GetMCriticalProb(ResourceSkill resSkill = null)
	{
		return 0f;
	}

	public float GetMCriticalDamageMulWithBound()
	{
		return 0f;
	}

	public virtual float GetMCriticalDamageMul()
	{
		return 0f;
	}

	public virtual float GetSpecialDamageMul()
	{
		return 0f;
	}

	public virtual float GetDefPen(bool adjustLevel)
	{
		return 0f;
	}

	public virtual float GetDefDen(bool adjustLevel)
	{
		return 0f;
	}

	public virtual float GetDefDenTime()
	{
		return 0f;
	}

	public virtual float GetDefPenTime()
	{
		return 0f;
	}

	public virtual float GetAttackDamageMul()
	{
		return 0f;
	}

	public virtual float GetSkillDamageMul()
	{
		return 0f;
	}

	public void Hide(float time = 0.2f, Action callback = null, float delay = 0f)
	{
	}

	public void Appear(float time = 0.2f, Action callback = null)
	{
	}

	protected float GetTorsoAngle()
	{
		return 0f;
	}

	protected void UpdateTorsoAngle(bool adjust = true)
	{
	}

	public void Say(string text)
	{
	}

	public void SetAI(BaseAI ai)
	{
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
	}

	public void SetStunable(bool v)
	{
	}

	private void MoveStun(float time)
	{
	}

	private void MoveStunEnd()
	{
	}

	public void SetMoveStunable(bool v)
	{
	}

	public virtual void OnClick()
	{
	}

	public void LevelUp(int up = 1, float delay = -1f)
	{
	}

	private int GetLevelValue(float origin)
	{
		return 0;
	}

	public static int GetLevelValueStatic(float origin, int level, int team, ResourceUnit resUnit)
	{
		return 0;
	}

	public void ReloadSkill()
	{
	}

	public ResourceSkill GetLevelSkill(ResourceSkill originalSkill)
	{
		return null;
	}

	public ResourceSkill GetResUnitSkill()
	{
		return null;
	}

	public int GetResUnitDeathSkillID()
	{
		return 0;
	}

	public int GetSkillBonusLevel()
	{
		return 0;
	}

	public void SetLevel(int level, float delay = -1f)
	{
	}

	private Vector3 GetCustomOffset(int maxCustomOffset, RangeInfo splashRange, Vector2Int targetTilePos)
	{
		return default(Vector3);
	}

	public Arrow ShootArrowTo(GameUnit arrowTarget, Arrow.Type type = Arrow.Type.Homing, string arrowPrefab = null, DamageInfo damageInfo = default(DamageInfo), float arrowSpeed = 400f, float angleOffset = 0f, Vector3 positionOffset = default(Vector3), float _sizeRatio = 0f, Action<GameUnit, Vector3, Arrow> completeCallback = null, GameUnit originUnit = null, bool ignoreShootPoint = false, float arcHeightOverwrite = -1f, bool allowCustomOffset = true)
	{
		return null;
	}

	public void SetSuperShield(int count, bool hit = false)
	{
	}

	public void AddSuperShield(int count, GameUnit from)
	{
	}

	public void SetSuperMAtkShield(int count, bool hit = false)
	{
	}

	public void AddSuperMAtkShield(int count, GameUnit from)
	{
	}

	private void AddSuperShieldEffect(DamageInfo.BlockedBy type)
	{
	}

	private void ShowSuperShieldHitEffect(DamageInfo.BlockedBy type)
	{
	}

	private void ShowSuperShieldSaveEffect(DamageInfo.BlockedBy type)
	{
	}

	private void RemoveSuperShieldEffect(DamageInfo.BlockedBy type)
	{
	}

	private void HandleSuperShieldBroken(GameUnit from, ResourceSkill fromSkill, DamageInfo.BlockedBy type)
	{
	}

	public void BindBuildingBuffs()
	{
	}

	public void StartBattle(bool startAtFirst = true)
	{
	}

	public void Restore(bool init = false, bool setFront = true)
	{
	}

	public void Clear(bool checkStageEnd = true)
	{
	}

	private void StopItemTimers()
	{
	}

	private void ClearBuffs()
	{
	}

	private void ClearTriggeredDatas()
	{
	}

	public void RefreshArtifacts(List<ArtifactModel> artifactModels)
	{
	}

	public void ResetStat(bool init = false, bool resetHp = true, bool updateAllItems = false, bool calledFromGameUnitInit = false)
	{
	}

	public void UpdateAllItems()
	{
	}

	public void ResetComboAttackSkill()
	{
	}

	private void ReloadReviveWithMaxHpPer()
	{
	}

	private void ReloadSuperShield()
	{
	}

	public void ReloadSuperShieldAfterGameStart()
	{
	}

	private void ReloadSuperMAtkShield()
	{
	}

	private void ResetItemEffect()
	{
	}

	private void HandleEquipItem(Item item, bool effectOnly = false)
	{
	}

	public bool Equip(Item item)
	{
		return false;
	}

	public void UnEquip(int id)
	{
	}

	public void UnEquip(Item item)
	{
	}

	public int GetMaxItemSlotCount()
	{
		return 0;
	}

	private void ReloadAddedStatByItemSlot(bool updateStat = true)
	{
	}

	public virtual bool CanMerge(GameUnit other)
	{
		return false;
	}

	public virtual bool CanMergeWithSomeone(bool onlyWaitingFields = false)
	{
		return false;
	}

	public void MergeWith(GameUnit other)
	{
	}

	public void SetBoss(int boss)
	{
	}

	public virtual void BeginDrag()
	{
	}

	public virtual void OnDrag()
	{
	}

	private void EndDragImpl()
	{
	}

	public virtual void EndDrag()
	{
	}

	public void Transform(ResourceSkill resSkill)
	{
	}

	public void ReleaseTransform()
	{
	}

	public void ReleaseFromTarget(bool cancelMotion = false)
	{
	}

	private bool CanCancelMotionByReleaseFromTarget(GameUnit unit)
	{
		return false;
	}

	public void HandleSummonedUnitDead(GameUnit unit)
	{
	}

	public void Log(string text)
	{
	}

	public virtual List<Vector2Int> GetTileSize()
	{
		return null;
	}

	public Vector3 GetHitPoint()
	{
		return default(Vector3);
	}

	public Vector3 GetHitOffset()
	{
		return default(Vector3);
	}

	public void SetDirectionTo(GameUnit target)
	{
	}

	private void HandleTick()
	{
	}

	private void HandleInAreaEffect()
	{
	}

	private void OnBuffAdded(Buff buff)
	{
	}

	private void OnBuffRemoved(Buff buff)
	{
	}

	public void SetDraggable(bool v)
	{
	}

	public void ReadyPoolRent()
	{
	}

	public void ReadyPoolReturn()
	{
	}

	public void SetItemCount(int count)
	{
	}

	public bool CanTarget()
	{
		return false;
	}

	public void UpdateZ()
	{
	}

	public void Knockback(GameUnit from, int value, Vector2Int dir, ResourceSkill resKnockBackSkill)
	{
	}

	public void Grabbed(GameUnit from, ResourceSkill resGrabSkill, float baseGrabTime)
	{
	}

	private void FailGrab(GameUnit from, ResourceSkill resGrabSkill)
	{
	}

	public void InstallTotem(TotemUnit totemUnit)
	{
	}

	public void RemoveTotem(TotemUnit totemUnit)
	{
	}

	public void HandleTotemDie(TotemUnit totemUnit)
	{
	}

	private bool IsTotemConnectedFrom(GameUnit unit)
	{
		return false;
	}

	private List<GameUnit> GetTotemTargets(GameUnit currentTarget, ResourceSkill totemSkill)
	{
		return null;
	}

	public void SetBuildingLevels(int[] buildingData)
	{
	}

	private int GetBuildingLevel(int id)
	{
		return 0;
	}

	public ResourceBuilding.EffectValue GetBuildingEffectValue(string key)
	{
		return null;
	}

	public int GetBuildingEffect(string key, int @default = 0)
	{
		return 0;
	}

	public float GetBuildingEffectFloat(string key, float @default = 0f)
	{
		return 0f;
	}

	public IReadOnlyList<ResourceSkill.Effect> GetUnitEffects(string type, ResourceUnit targetUnit = null, int animatorInt = -1)
	{
		return null;
	}

	private ResourceSkill.Effect GetUIOnlyTransformEffect(string prefabName)
	{
		return default(ResourceSkill.Effect);
	}

	private ResourceSkill.Effect GetTransformEffect(int transformTarget)
	{
		return default(ResourceSkill.Effect);
	}

	private int GetSkillIntCounterMin()
	{
		return 0;
	}

	public IReadOnlyList<ResourceSkill.Effect> GetSkillEffects(ResourceSkill resSkill, string type, int animatorInt = -1)
	{
		return null;
	}

	public ResourceSkill.Effect GetSkillEffect(ResourceSkill resSkill, string type)
	{
		return default(ResourceSkill.Effect);
	}

	private void ShowShootEffect(ResourceSkill resSkill, List<GameUnit> attackTargets, int skillIntToUse, int skillCountIdx)
	{
	}

	public string GetUnitArrowPrefab()
	{
		return null;
	}

	public string GetSkillArrowPrefab(ResourceSkill skill)
	{
		return null;
	}

	public Arrow.Type GetSkillArrowType(ResourceSkill skill)
	{
		return default(Arrow.Type);
	}

	public int GetArtifactValueSum(string type)
	{
		return 0;
	}

	public float GetArtifactValueFloatSum(string type)
	{
		return 0f;
	}

	public float GetArtifactValueFloatProduct(string type)
	{
		return 0f;
	}

	public int GetArtifactOptionSum(string type)
	{
		return 0;
	}

	private float GetDamageDelay(ResourceSkill resSkill, Vector2Int dir, Vector2 dist)
	{
		return 0f;
	}

	private float GetDelayTime(float delay, string type, Vector2Int dir, Vector2 dist, RangeInfo rangeInfo)
	{
		return 0f;
	}

	public void SetStopTime(float v)
	{
	}

	public void HandleOverKillSplashDamage(GameUnit from, int overkillDamage, int range)
	{
	}

	public void SetStatPer(List<(float per, bool withAttackInterval)> statPers)
	{
	}

	public void SetStatPer(int value, bool withAttackInterval)
	{
	}

	public float GetStatPer(bool attackInterval = false)
	{
		return 0f;
	}

	public void SetHealable(bool v)
	{
	}

	public int GetAttackSkillID(bool excludeResUnit = false)
	{
		return 0;
	}

	public int GetAttackSkillBonusLevel(int skillID)
	{
		return 0;
	}

	private void SetSkillInt(int value)
	{
	}

	private void IncSkillInt()
	{
	}

	private void ResetSkillInt()
	{
	}

	private void SetIsFullStack(bool v)
	{
	}

	public void TauntForTarget(GameUnit targetUnit, float time = 1f, ResourceSkill resSkill = null)
	{
	}

	public void TauntForTargetWithoutCheckFixedTarget(GameUnit targetUnit)
	{
	}

	public bool CanChangeManaGaugeColor()
	{
		return false;
	}

	private bool HasChannelingAttackSkill()
	{
		return false;
	}

	public bool IsMeleeUnit()
	{
		return false;
	}

	public bool CheckSkillTrigger(ResourceSkill.SkillTriggerCondition condition, List<GameUnit> targets)
	{
		return false;
	}

	private bool CheckCancelSkillTriggers(ResourceSkill resSkill)
	{
		return false;
	}

	public bool HasHardCC()
	{
		return false;
	}

	public void RemoveDebuffs()
	{
	}

	private bool CheckDebuffFunc(Buff x)
	{
		return false;
	}

	private void GetNextAttackEffects(List<ResourceSkill.Effect> targetEffects)
	{
	}

	public void EnableAIAfterDelay()
	{
	}

	private void ShowWaitEffect(Item item)
	{
	}

	public void UpdateWaitEffectHeights()
	{
	}

	public float GetStat(BuffManager.StatType type, bool fromStatPanel = false)
	{
		return 0f;
	}

	public bool CanShowBossHpBar()
	{
		return false;
	}

	public void SetAttackFlag(bool v)
	{
	}

	public void IncAndCheckSkillAttackCountEventTrigger(GameUnit target)
	{
	}

	public float GetBaseReflectPer()
	{
		return 0f;
	}

	public float GetReflectPer()
	{
		return 0f;
	}

	public void SetMoveStopTime(float time)
	{
	}

	public void AddMoveStopTime(float time)
	{
	}

	public bool MimicSkill(GameUnit gameUnit, int skillID)
	{
		return false;
	}

	public void ForceAttackSkill(int attackSkillId)
	{
	}

	public bool IsGaugeBuffSkill(Buff buff)
	{
		return false;
	}

	public void ReloadTerritoryStatBuffs()
	{
	}

	public void SetTerritoryStatBuffPer(Constants.TerritoryStatBuffType type, float per)
	{
	}

	public int GetTier()
	{
		return 0;
	}

	public void ShowBuffGaugeMarker(bool show)
	{
	}

	public bool IsUniqueUnit()
	{
		return false;
	}

	public void ResetHpRatioTrigger()
	{
	}

	[CanBeNull]
	public List<GameUnit> GetConnectedBuffers(GameUnit except = null)
	{
		return null;
	}

	public void AdjustDamage(ref DamageInfo damageInfo)
	{
	}

	public void ApplyMergeItemSelected(List<int> selected)
	{
	}

	public void SetLoopEffectDirBlend(int key, float value)
	{
	}

	public void ConsumeHp(int value, bool showEffect = true, bool force = false)
	{
	}

	private void ConsumeHpImplLegacy(int value, bool showEffect)
	{
	}

	private void ConsumeHpImpl(int value, bool showEffect, bool force = false)
	{
	}

	private void ConsumeHealHpImpl(int value, bool showEffect)
	{
	}

	public List<GameUnit> GetExtraSplashTarget(ResourceSkill resSkill, GameUnit mainTarget, Vector2Int? skillUsingPos)
	{
		return null;
	}

	public (List<GameUnit>, List<Vector2Int>, List<Vector2Int>, Vector2Int) GetSplashTargetAndInfos(ResourceSkill resSkill, GameUnit mainTarget, Vector2Int prevPos, Vector2Int? skillUsingPos)
	{
		return default((List<GameUnit>, List<Vector2Int>, List<Vector2Int>, Vector2Int));
	}

	private void ShowSplashPosEffects(ResourceSkill resSkill, Vector2Int centerPos, List<Vector2Int> posList, IReadOnlyList<ResourceSkill.Effect> effects, float damageDelay, Vector2Int splashDir)
	{
	}

	public DamageInfo.Type PredictDamageTypeFromSkill(ResourceSkill resSkill, bool isSkillType, string damageTag = "Damage")
	{
		return default(DamageInfo.Type);
	}

	public bool CheckTargetType(GameUnit unit, ResourceSkill.TargetType targetType)
	{
		return false;
	}

	public bool HasSkillValue(ResourceSkill resourceSkill, string key)
	{
		return false;
	}

	public bool GetSkillValueBool(ResourceSkill resourceSkill, string key, bool @default = false)
	{
		return false;
	}

	public string GetSkillValueText(ResourceSkill resourceSkill, string key, string @default = null)
	{
		return null;
	}

	public int GetSkillValueIntSum(ResourceSkill resourceSkill, string key, int seed = 0)
	{
		return 0;
	}

	public int GetSkillValueIntMax(ResourceSkill resourceSkill, string key, int @default = -1)
	{
		return 0;
	}

	public int GetSkillValueIntLast(ResourceSkill resourceSkill, string key, int @default = -1)
	{
		return 0;
	}

	[CanBeNull]
	public List<int> GetSkillValueIntList(ResourceSkill resourceSkill, string key)
	{
		return null;
	}

	public float GetSkillValueFloatSum(ResourceSkill resourceSkill, string key, float seed = 0f)
	{
		return 0f;
	}

	public float GetSkillValueFloatMax(ResourceSkill resourceSkill, string key, float @default = -1f)
	{
		return 0f;
	}

	public float GetSkillValueFloatLast(ResourceSkill resourceSkill, string key, float @default = -1f)
	{
		return 0f;
	}

	public List<float> GetSkillValueFloatList(ResourceSkill resourceSkill, string key)
	{
		return null;
	}

	public IReadOnlyList<ResourceUnit.Potential> GetPotentialsTargetSkill(ResourceSkill resourceSkill)
	{
		return null;
	}

	public void AddDefPenBuff(GameUnit from)
	{
	}

	public void AddDefDenBuff(GameUnit from)
	{
	}

	public float GetDefaultPhysicalDrainPer()
	{
		return 0f;
	}

	public float GetPhysicalDrainPer(DamageInfo damageInfo = default(DamageInfo))
	{
		return 0f;
	}

	public float GetDefaultMagicDrainPer()
	{
		return 0f;
	}

	public float GetMagicDrainPer(DamageInfo damageInfo = default(DamageInfo))
	{
		return 0f;
	}

	public int GetBaseMana(bool withBuilding, bool withArtifact)
	{
		return 0;
	}

	public int GetUnitDefaultMaxMana()
	{
		return 0;
	}

	public int GetMaxMana()
	{
		return 0;
	}

	public int GetMaxTechnique()
	{
		return 0;
	}

	public float GetAttackMana()
	{
		return 0f;
	}

	public float GetMoveSpeedRatio()
	{
		return 0f;
	}

	public void AddReviveCount(ReviveCategory category, float maxHpPer, float maxManaPer = 100f, float reviveTime = 2f, Action onRevive = null)
	{
	}

	public void BindGlobalCallbacks()
	{
	}

	public void DisposeGlobalCallbacks()
	{
	}

	public void GiveGuard(GameUnit target)
	{
	}

	public float GetGuardValue(float guard)
	{
		return 0f;
	}

	public void AddGimmickStack(GameUnit skillTarget, ResourceSkill resSkill)
	{
	}

	public void OnGimmickStackAdded(BuffManager.GimmickStacks stackName, int count)
	{
	}

	private void HandleChapter17Stack(int count)
	{
	}
}
