using System;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

public class ResourceSkill : ResourceBase<ResourceSkill>
{
	public class ValueWithCoefficient
	{
		public string name;

		public float value;

		public float? bound;

		public List<(BuffManager.StatType stat, ValueWithCoefficient value)> coefficients;

		public ValueWithCoefficient(string name, (float value, float? bound) tuple)
		{
		}

		public float? GetValueWithBoundIfCan()
		{
			return null;
		}

		public float GetValueWithBound(GameUnit target)
		{
			return 0f;
		}

		public float GetValueWithBound(Func<BuffManager.StatType, float> statFunc)
		{
			return 0f;
		}

		private float? GetValueIfCan()
		{
			return null;
		}

		private float GetValue(GameUnit target)
		{
			return 0f;
		}

		private float GetValue(Func<BuffManager.StatType, float> statFunc)
		{
			return 0f;
		}

		public void BuildCoefficient(List<(string target, Dictionary<string, (float, float?)> coefficients)> temporaryCoefficientNode)
		{
		}
	}

	public struct Value
	{
		public string key;

		public string value;
	}

	public struct Effect
	{
		public string type;

		public string prefab;

		public Vector2 offset;

		public Vector2 sizeDelta;

		public float sizeByAttackCount;

		public float addSizeByStack;

		public RotationType rotationType;

		public Vector3 scale;

		public bool isWorld;

		public bool parentToUnitPrefab;

		public bool isLoop;

		public bool loopStopAtRemove;

		public bool loopStopAtSkillEnd;

		public string loopTrigger;

		public bool loopTriggerAtSkillEnd;

		public bool isMoving;

		public float moveSpeed;

		public float lifeTime;

		public Vector2 moveDir;

		public EffectZLevel zLevel;

		public bool offsetRotation;

		public float offsetRotationMin;

		public float offsetRotationMax;

		public bool levelScale;

		public bool centerAlign;

		public bool addHeight;

		public bool minusHeightOffset;

		public bool flip;

		public bool randomFlip;

		public Vector2 randomOffsetX;

		public Vector2 randomOffsetY;

		public Vector2 randomScale;

		public float offsetHeight;

		public bool isLine;

		public bool isLineRenderer;

		public int lineScale;

		public int lineScaleTick;

		public int lineScaleTickMax;

		public bool useArrowLine;

		public bool isTilePos;

		public List<string> sounds;

		public string soundAtBuffBlend;

		public float delay;

		public float repeatedDelay;

		public string delayType;

		public bool delayStopAtSkillEnd;

		public bool useAttackSpeed;

		public float speedRatio;

		public string shootTrigger;

		public string cancelTrigger;

		public string stackTrigger;

		private bool? _usePooling;

		public bool showOnlyOnce;

		public Arrow.Type projectileType;

		public int index;

		public int maxCount;

		public string setYOverHpBar;

		public int transformTarget;

		public string uiTransformNameTarget;

		public bool useTierInt;

		public bool useAttackInt;

		public bool usePooling
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public Effect(Effect effect)
		{
			type = null;
			prefab = null;
			offset = default(Vector2);
			sizeDelta = default(Vector2);
			sizeByAttackCount = 0f;
			addSizeByStack = 0f;
			rotationType = default(RotationType);
			scale = default(Vector3);
			isWorld = false;
			parentToUnitPrefab = false;
			isLoop = false;
			loopStopAtRemove = false;
			loopStopAtSkillEnd = false;
			loopTrigger = null;
			loopTriggerAtSkillEnd = false;
			isMoving = false;
			moveSpeed = 0f;
			lifeTime = 0f;
			moveDir = default(Vector2);
			zLevel = default(EffectZLevel);
			offsetRotation = false;
			offsetRotationMin = 0f;
			offsetRotationMax = 0f;
			levelScale = false;
			centerAlign = false;
			addHeight = false;
			minusHeightOffset = false;
			flip = false;
			randomFlip = false;
			randomOffsetX = default(Vector2);
			randomOffsetY = default(Vector2);
			randomScale = default(Vector2);
			offsetHeight = 0f;
			isLine = false;
			isLineRenderer = false;
			lineScale = 0;
			lineScaleTick = 0;
			lineScaleTickMax = 0;
			useArrowLine = false;
			isTilePos = false;
			sounds = null;
			soundAtBuffBlend = null;
			delay = 0f;
			repeatedDelay = 0f;
			delayType = null;
			delayStopAtSkillEnd = false;
			useAttackSpeed = false;
			speedRatio = 0f;
			shootTrigger = null;
			cancelTrigger = null;
			stackTrigger = null;
			_usePooling = null;
			showOnlyOnce = false;
			projectileType = default(Arrow.Type);
			index = 0;
			maxCount = 0;
			setYOverHpBar = null;
			transformTarget = 0;
			uiTransformNameTarget = null;
			useTierInt = false;
			useAttackInt = false;
		}
	}

	public struct SkillTriggerCondition
	{
		public SkillTrigger skillTrigger;

		public int targetSkill;

		public float[] @params;
	}

	public enum AtkType
	{
		None = 0,
		Melee = 1,
		Arrow = 2,
		Summon = 3,
		Transform = 4,
		Totem = 5,
		TileTick = 6,
		Random = 7
	}

	public enum PreTargetCategory
	{
		None = 0,
		Grab = 1,
		Fear = 2,
		Charm = 3,
		Ice = 4
	}

	public enum TargetType
	{
		None = 0,
		Default = 1,
		Enemy = 2,
		Team = 3,
		Self = 4,
		All = 5,
		AllIncludeMe = 6,
		SelfAndMySummons = 7,
		MySummons = 8,
		SummonerTarget = 9,
		EliteEnemy = 10,
		BossEnemy = 11,
		Field = 12,
		ItemUnit = 13,
		Building = 14,
		Parent = 15,
		ParentAndMe = 16,
		DefDenListCurrentFrame = 17
	}

	public enum MoveTo
	{
		None = 0,
		Front = 1,
		Back = 2,
		Target = 3,
		TargetBack = 4,
		TargetAcross = 5,
		LowestHpTeamFront = 6,
		LowestHpEnemyUp = 7,
		FrontestTeamUp = 8,
		BackOrFarthestFromEnemy = 9,
		FarthestTarget = 10,
		ReversalPos = 11,
		CanAttackMostTargets = 12,
		Random = 13,
		AICustom = 14,
		NearestBack = 15
	}

	public enum MoveType
	{
		None = 0,
		HideAppear = 1,
		Rush = 2
	}

	public enum RotationType
	{
		None = 0,
		Angle = 1,
		Flip = 2,
		DirBlend = 3,
		AngleDirBlend = 4,
		OnlyOffset = 5,
		AngleToTarget = 6,
		AngleRelativeToFromUnit = 7,
		AngleRelativeToFromUnitFixedHorizontal = 8,
		DirBlendOnly = 9
	}

	public enum EffectZLevel
	{
		Unit = 0,
		Over = 1,
		Ground = 2,
		OverUI = 3,
		UnitOver = 4
	}

	public enum SkillTrigger
	{
		TargetIsNotInBuffRange = 0,
		TriggeredByPotential = 1,
		TargetIsNotHasBuff = 2,
		NotFirstAtkForTarget = 3,
		CantFindSplashTarget = 4,
		TargetIsNotInSkillRange = 5,
		TargetIsFirstTargeted = 6,
		HasSummonUnit = 7,
		HasShield = 8,
		MaxManaOver = 9,
		HpPerOver = 10,
		TargetIsEnemy = 11
	}

	public enum KnockbackDistanceType
	{
		Default = 0,
		PullTowardToFront = 1
	}

	public enum ChangeCardLevelType
	{
		Set = 0
	}

	private delegate void EffectParseDelegate(ref Effect effect, XmlNode node);

	public string descKey;

	public string longDescKey;

	public string shortDescKey;

	public string altLongDescKey;

	public string altShortDescKey;

	public string iconName;

	public AtkType atkType;

	public PreTargetCategory preTargetCategory;

	public TargetType targetType;

	public RangeInfo range;

	public RangeInfo splashRange;

	public bool useUnitDirOnSplash;

	public RangeInfo buffRange;

	public RangeInfo triggerRange;

	public RangeInfo extraSplashRange;

	private bool? _mainBuffSkill;

	public List<string> sounds;

	public List<string> hitSounds;

	public string arrowPrefab;

	public float arrowSpeed;

	public Arrow.Type arrowType;

	public Dictionary<int, string> randomArrowPrefabs;

	public MoveTo moveTo;

	public MoveType moveType;

	public int tier;

	public bool buffOverlap;

	public bool resetOverlapBuffTime;

	public float speedRatio;

	public Dictionary<string, Value> stringValues;

	public List<(string key, Effect effect)> effects;

	public List<(int id, int count, int addLevel, int statPer, Vector2Int pos)> summonUnits;

	public List<(int id, int weight)> randomSkills;

	public List<SkillTriggerCondition> changeSkillTriggers;

	public List<SkillTriggerCondition> cancelSkillTriggers;

	public Vector2Int unitOffset;

	public XmlNode xmlNode;

	public int combinationSkill;

	public int nextComboSkill;

	public int nextComboSkillNeedCount;

	public int disposableSkill;

	public bool usePrevPos;

	public bool forceUseDefaultTarget;

	public int setSkillInt;

	public bool skillIntCounter;

	public int skillIntCounterMin;

	public int skillIntCounterMax;

	public bool fixSkillIntCounterAtMax;

	public DamageInfo.Type forceDamageType;

	public bool useStackInt;

	public KnockbackDistanceType knockbackDistanceType;

	public List<string> animTriggers;

	private Sprite _iconSprite;

	private string _longDesc;

	private string _shortDesc;

	private string _altShortDesc;

	private string _altLongDesc;

	public int inheritFrom;

	public int root;

	public Dictionary<string, ValueWithCoefficient> valuesWithCoefficient;

	private List<(string target, Dictionary<string, (float value, float? bound)> coefficients)> _temporaryCoefficientNode;

	private OptimizedReadOnlyStringDict<Value> _optimizedStringValuesDict;

	private OptimizedReadOnlyStringDict<ValueWithCoefficient> _optimizedValuesWithCoefficientDict;

	public bool splashToPath;

	private static readonly Dictionary<string, EffectParseDelegate> _effectParseDict;

	private const string BASE_COLOR = "#ffcc00";

	private const string VALUE_COLOR = "#00bbff";

	private const string RANGE_COLOR = "#8DFFFF";

	public bool mainBuffSkill => false;

	public Sprite iconSprite => null;

	public string desc => null;

	public string longDesc => null;

	public string shortDesc => null;

	public string altShortDesc => null;

	public string altLongDesc => null;

	public override void Init(XmlNode n)
	{
	}

	private static int ParseInt(string text)
	{
		return 0;
	}

	private static float ParseFloat(string text)
	{
		return 0f;
	}

	private static bool ParseBool(string text)
	{
		return false;
	}

	private static List<string> ParseTextList(string text)
	{
		return null;
	}

	public static Effect ParseEffectNode(string type, XmlNode effectNode)
	{
		return default(Effect);
	}

	public static void ParseAlreadyExistsEffect(ref Effect effect, XmlNode effectNode)
	{
	}

	public ValueWithCoefficient GetValueWithCoefficient(string key)
	{
		return null;
	}

	public int GetValueInt(string key, GameUnit me, int @default = -1)
	{
		return 0;
	}

	public int GetValueInt(string key, Func<BuffManager.StatType, float> statFunc = null, int @default = -1)
	{
		return 0;
	}

	public float GetValueFloat(string key, GameUnit me, float @default = -1f)
	{
		return 0f;
	}

	public float GetValueFloat(string key, Func<BuffManager.StatType, float> statFunc = null, float @default = -1f)
	{
		return 0f;
	}

	public string GetValueText(string key, string @default = null)
	{
		return null;
	}

	public bool GetValueBool(string key, bool @default = false)
	{
		return false;
	}

	public bool HasValue(string key)
	{
		return false;
	}

	public bool HasStringValue(string key)
	{
		return false;
	}

	public bool HasCoefficientValue(string key)
	{
		return false;
	}

	public Effect GetEffect(string type)
	{
		return default(Effect);
	}

	public List<Effect> GetEffects(string type)
	{
		return null;
	}

	public string MakeDescValue(float value, bool isBaseValue)
	{
		return null;
	}

	public string MakeDescValue(string value, bool isBaseValue)
	{
		return null;
	}

	private string MakeRangeDescValue(string value)
	{
		return null;
	}

	public string GetDesc(GameUnit unit, bool longVersion, bool useAltDesc = false)
	{
		return null;
	}

	public string GetDesc(Func<BuffManager.StatType, float> statFunc, ResourceUnit resUnit, CardData cardData, bool longVersion, bool useAltDesc = false, int unitLevel = 1)
	{
		return null;
	}

	public string GetDesc(Func<BuffManager.StatType, float> statFunc, string text, ResourceUnit resUnit, CardData cardData, int unitLevel)
	{
		return null;
	}

	public string GetDesc(GameUnit unit, string text)
	{
		return null;
	}

	private int GetBaseStatIfBaseStatTag(string tag, Func<BuffManager.StatType, float> statFunc)
	{
		return 0;
	}

	private int GetBaseStatIfBaseStatTag(string tag, GameUnit unit)
	{
		return 0;
	}

	public int GetDescAttackCount(Func<BuffManager.StatType, float> statFunc)
	{
		return 0;
	}

	public int GetDescAttackCount(GameUnit unit)
	{
		return 0;
	}

	public static void Load()
	{
	}

	private void ParseCoefficientValue()
	{
	}

	private (float, bool) ParseDescParam(string rawKey, ResourceUnit resUnit, bool fromUnit, Func<BuffManager.StatType, float> statFunc, CardData cardData)
	{
		return default((float, bool));
	}

	private float AdjustInfluentialTag(string keyName, float targetValue, GameUnit unit, ResourceUnit resUnit = null, Func<BuffManager.StatType, float> statFunc = null, CardData cardData = null)
	{
		return 0f;
	}

	private (float, bool) ParseDescParam(string rawKey, ResourceUnit resUnit, bool fromUnit, GameUnit unit)
	{
		return default((float, bool));
	}

	private float AdjustPotentialValue(string keyName, List<string> keyCoefficient, GameUnit unit)
	{
		return 0f;
	}

	private float AdjustPotentialValue(string keyName, List<string> keyCoefficient, Func<BuffManager.StatType, float> statFunc, List<ResourceUnit.Potential> potentials)
	{
		return 0f;
	}

	public int GetMaxTargetCount(GameUnit unit)
	{
		return 0;
	}

	public ResourceSkill GetLevelSkill(ResourceUnit resUnit, int level, int team)
	{
		return null;
	}

	public static void HandleLanguageChanged()
	{
	}
}
