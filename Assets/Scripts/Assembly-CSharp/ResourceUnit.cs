using System;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

public class ResourceUnit : ResourceBase<ResourceUnit>
{
	public enum Type
	{
		None = 0,
		Player = 1,
		Enemy = 2,
		Interactable = 3
	}

	public enum TileSizeType
	{
		Rect = 0,
		Custom = 1
	}

	public enum SkillEnergyType
	{
		Mana = 0,
		Technique = 1
	}

	public enum Role
	{
		None = 0,
		Brave = 1,
		Mystic = 2,
		Shadow = 3,
		Element = 4,
		Toughness = 5,
		Swift = 6
	}

	public enum Region
	{
		East = 0,
		West = 1,
		South = 2,
		North = 3,
		Central = 4,
		Unknown = 5
	}

	public struct Value
	{
		public string key;

		public string value;
	}

	public class Potential : IEquatable<Potential>
	{
		public int reqLevel;

		public int[] reqGimmick;

		public int tier;

		public int targetSkill;

		public string name;

		public string desc;

		public string iconName;

		public int index;

		public int slot;

		public int minVersion;

		public Dictionary<string, string> stringValues;

		public Dictionary<string, ResourceSkill.ValueWithCoefficient> valuesWithCoefficient;

		public List<(string target, Dictionary<string, (float, float?)> coefficients)> temporaryCoefficientNode;

		public XmlNode node;

		private OptimizedReadOnlyStringDict<ResourceSkill.ValueWithCoefficient> _optimizedValuesWithCoefficientDict;

		private OptimizedReadOnlyStringDict<string> _optimizedStringValuesDict;

		public Action<Buff> buffInitializeAction;

		public Action<Buff> buffDisposeAction;

		public Sprite icon => null;

		public Potential(XmlNode node, int parentId, int potentialIdx)
		{
		}

		public int GetValueInt(string key, GameUnit me = null, int @default = -1)
		{
			return 0;
		}

		public ResourceSkill.ValueWithCoefficient GetValueWithCoefficient(string key)
		{
			return null;
		}

		public float GetValueFloat(string key, GameUnit me = null, float @default = -1f)
		{
			return 0f;
		}

		public float? GetValueFloatIfCan(string key)
		{
			return null;
		}

		public string GetValueText(string key, string @default = null)
		{
			return null;
		}

		public bool GetValueBool(string key, bool @default = false)
		{
			return false;
		}

		private bool HasStringValue(string key)
		{
			return false;
		}

		private bool HasCoefficientValue(string key)
		{
			return false;
		}

		public bool HasValue(string key)
		{
			return false;
		}

		public Color GetColor()
		{
			return default(Color);
		}

		public bool Equals(Potential other)
		{
			return false;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public void ParseCoefficientValue()
		{
		}
	}

	public struct TransformCondition
	{
		public string type;

		public string parameter;

		public int value;

		public int transformTarget;
	}

	public class OnClickEvent
	{
		public string key;

		public string value;

		public string args;
	}

	public string subNameKey;

	public Type type;

	private string _prefab;

	public string spriteName;

	public string uiSpriteName;

	public string portraitName;

	public string illustName;

	public ResourceSkill.AtkType atkType;

	public int hp;

	public int atk;

	public int matk;

	public SkillEnergyType skillEnergyType;

	public int mana;

	public int battleStartMana;

	public int technique;

	public int battleStartTechnique;

	public float def;

	public float mdef;

	public float criticalProb;

	public float mcriticalProb;

	public float criticalDamageMul;

	public float mcriticalDamageMul;

	public float specialDamageMul;

	public float defDen;

	public float defPen;

	public float defDenTime;

	public float defPenTime;

	public int exp;

	public float speed;

	public int attackCount;

	public RangeInfo range;

	public int reward;

	public int cost;

	public float attackInterval;

	public int restoreUnit;

	public string atkSound;

	public string shotSound;

	public string atkStartSound;

	public string arrowPrefab;

	public float arrowSpeed;

	public Arrow.Type arrowType;

	public float arrowOffsetX;

	public float arrowOffsetY;

	public Vector2 arrowOffsetFront;

	public Vector2 arrowOffsetBack;

	public Vector2 arrowOffsetSide;

	private int _skill;

	public int attackSkill;

	public int deathSkill;

	public float height;

	public float floatingY;

	public int heightOffset;

	public int heightWhenBuff;

	public int bossHpBarIndex;

	public Dictionary<string, Value> stringValues;

	public List<Potential> potentials;

	public List<TransformCondition> transformConditions;

	public Dictionary<string, ResourceSkill.ValueWithCoefficient> valuesWithCoefficient;

	private List<(string target, Dictionary<string, (float, float?)> coefficients)> _temporaryCoefficientNode;

	public Dictionary<int, float> levelRatio;

	public List<Vector2Int> tileSize;

	public int tileWidth;

	public int tileHeight;

	public bool visible;

	public string summonTrigger;

	public bool dontDestroyWithParent;

	public bool ignoreSkillFromParent;

	public int rewardGold;

	public bool fixDirection;

	public bool isClanRaidBoss;

	public int minVersion;

	public List<int> genStageExcept;

	public string aiType;

	public float illustOffsetX;

	public float illustOffsetY;

	public float illustScale;

	public float gachaIllustOffsetX;

	public float gachaIllustOffsetY;

	public float gachaBackIllustOffsetX;

	public float gachaBackIllustOffsetY;

	public Color gachaGradationColor;

	public Color gachaExplosionColor;

	public Color gradationColor;

	public List<OnClickEvent> onClickEvents;

	public Role role;

	public Region region;

	public bool spriteInSheet;

	private Sprite _sprite;

	private Sprite _uiSprite;

	private Sprite _portrait;

	public List<(string key, ResourceSkill.Effect effect)> effects;

	public XmlNode xmlNode;

	public int root;

	public string clanBossAvatarSpriteName;

	private Sprite _clanBossAvatarSprite;

	private Sprite _avatarSprite;

	private Sprite _illustSprite;

	private Sprite _illustSprite_FOOLS;

	public int inheritFrom;

	public float suicideTimer;

	public Dictionary<int, float> themeDamageModulator;

	public Dictionary<int, float> themeDefenseModulator;

	private OptimizedReadOnlyStringDict<ResourceSkill.ValueWithCoefficient> _optimizedValuesWithCoefficientDict;

	private OptimizedReadOnlyStringDict<Value> _optimizedStringValuesDict;

	public static int MaxPlayerUnitId;

	public string fullName => null;

	public new string name => null;

	public string pureName => null;

	public string koreanName => null;

	public string prefab => null;

	public int totalAtk => 0;

	public ResourceSkill skill => null;

	public bool isHardUnit => false;

	public bool isPlayerUnit => false;

	public Sprite sprite => null;

	public Sprite uiSprite => null;

	public Sprite portrait => null;

	public Sprite clanBossAvatarSprite => null;

	public Sprite avatarSprite => null;

	public Sprite illustSprite => null;

	public Sprite illustSprite_FOOLS => null;

	public static int RegionSortFunc(Region a, Region b)
	{
		return 0;
	}

	public string GetSubName(int skinID = -1)
	{
		return null;
	}

	public override void Init(XmlNode n)
	{
	}

	public ResourceSkill.ValueWithCoefficient GetValueWithCoefficient(string key)
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

	private bool HasStringValue(string key)
	{
		return false;
	}

	private bool HasCoefficientValue(string key)
	{
		return false;
	}

	public static int GetCardLevelValue(float value, int level)
	{
		return 0;
	}

	public static float GetCardLevelValueFloat(float value, int level)
	{
		return 0f;
	}

	public ResourceSkill.Effect GetEffect(string type)
	{
		return default(ResourceSkill.Effect);
	}

	public List<ResourceSkill.Effect> GetEffects(string type)
	{
		return null;
	}

	public List<Potential> GetAllPotentials(int level, int tier, int slot = -1)
	{
		return null;
	}

	public List<Potential> GetPotentials(int level, int tier, int slot = -1, bool defaultCheck = true)
	{
		return null;
	}

	public Potential GetRepresentativePotentialForUI(int level, int tier, int slot = -1, bool defaultCheck = true)
	{
		return null;
	}

	public static void Load()
	{
	}

	public new static List<ResourceUnit> GetAll(Func<ResourceUnit, bool> checkFunc = null)
	{
		return null;
	}

	public static List<ResourceUnit> GetAllPlayerUnits(Func<ResourceUnit, bool> checkFunc = null)
	{
		return null;
	}

	public Color GetBossColor(int boss)
	{
		return default(Color);
	}

	public int GetParentIDIfHas()
	{
		return 0;
	}

	public int GetChildIDIfHas()
	{
		return 0;
	}

	public bool IsSubUnit()
	{
		return false;
	}

	public int GetRootUnitId()
	{
		return 0;
	}

	public static int GetUnitTier(int level, int theme, int team)
	{
		return 0;
	}

	public float GetAttackInterval(int level)
	{
		return 0f;
	}

	public Sprite GetRoleIcon()
	{
		return null;
	}

	public string GetRoleName()
	{
		return null;
	}

	public Sprite GetRegionIcon()
	{
		return null;
	}

	public string GetRegionName()
	{
		return null;
	}

	public ResourceSkill GetInfoSkill()
	{
		return null;
	}

	public string GetOriginPrefab()
	{
		return null;
	}

	private void ParseCoefficientValue()
	{
	}
}
