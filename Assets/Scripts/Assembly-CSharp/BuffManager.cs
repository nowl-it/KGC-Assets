using System;
using System.Collections.Generic;
using JetBrains.Annotations;
using UniRx;

public class BuffManager
{
	public enum StatType
	{
		None = 0,
		Hp = 1,
		BaseMana = 2,
		MaxMana = 3,
		ManaAdaptability = 4,
		AttackMana = 5,
		DamagedMana = 6,
		HybridDef = 7,
		Def = 8,
		MDef = 9,
		SuperShieldAdaptability = 10,
		MoveSpeed = 11,
		AttackSpeed = 12,
		Atk = 13,
		MAtk = 14,
		AtkCount = 15,
		Range = 16,
		HybridDrain = 17,
		Drain = 18,
		MagicDrain = 19,
		HealAdaptability = 20,
		HealEfficiency = 21,
		ShieldAdaptability = 22,
		Damage = 23,
		TakeDamage = 24,
		ItemAdaptability = 25,
		AdvanceItemAdaptability = 26,
		DamageReflect = 27,
		Execution = 28,
		MissRatio = 29,
		Accuracy = 30,
		CCRatio = 31,
		HybridCriticalProb = 32,
		CriticalProb = 33,
		MCriticalProb = 34,
		HybridCriticalDamageMul = 35,
		CriticalDamageMul = 36,
		MCriticalDamageMul = 37,
		SpecialDamageMul = 38,
		DefDen = 39,
		DefPen = 40,
		DefDenTime = 41,
		DefPenTime = 42,
		SkillDamageMul = 43,
		AttackDamageMul = 44,
		AdditionalAtk = 45,
		AdditionalMAtk = 46,
		AdditionalHp = 47,
		AdditionalAttackSpeed = 48,
		AdditionalMoveSpeed = 49,
		SkillTierIdx = 50,
		CurrentHp = 51,
		Mana = 52,
		TreasureLevel = 53,
		Shield = 54,
		UsedMana = 55,
		MaxTechnique = 56,
		BaseTechnique = 57
	}

	public enum StatValueType
	{
		Value = 0,
		BaseValue = 1,
		PerValue = 2,
		TotalPerValue = 3
	}

	public struct StatInfo : IEquatable<StatInfo>, IComparable<StatInfo>
	{
		public StatType type;

		public StatValueType valueType;

		public float value;

		private static readonly string[] _typeStringCache;

		private static readonly string[] _debuffStringCache;

		public string ToTypeString()
		{
			return null;
		}

		public static int ToTypeInt(StatType statType, StatValueType statValueType)
		{
			return 0;
		}

		public static int ToTypeInt(StatInfo statInfo)
		{
			return 0;
		}

		public static StatInfo FromTypeInt(int x)
		{
			return default(StatInfo);
		}

		public static string ToDebuffString(StatType statType)
		{
			return null;
		}

		public static bool IsBuffWhenInc(StatType statType)
		{
			return false;
		}

		public bool Equals(StatInfo other)
		{
			return false;
		}

		public int CompareTo(StatInfo other)
		{
			return 0;
		}

		public static bool IsReadOnlyStatType(StatType statType)
		{
			return false;
		}
	}

	public delegate void OnAdded(Buff buff);

	public delegate void OnRemoved(Buff buff);

	public enum GimmickStacks
	{
		None = 0,
		Chapter17Stack = 1
	}

	private enum GetValueFuncTypeNumeric
	{
		FloatMaxGroupBy = 0,
		FloatSumGroupBy = 1,
		FloatMultGroupBy = 2,
		FloatSum = 3,
		FloatMax = 4,
		FloatMin = 5
	}

	private enum GetValueFuncTypeBool
	{
		BoolOr = 0,
		BoolAnd = 1
	}

	private enum GetValueFuncTypeText
	{
		Text = 0
	}

	private enum GetValueFuncTypeRange
	{
		Range = 0
	}

	public static int statTypeNum;

	public static int statValueTypeNum;

	protected List<Buff> units;

	private Buff _gaugedBuff;

	private OnAdded _addedCallback;

	private OnRemoved _removedCallback;

	public GameUnit target;

	public int skillIntCounterMin;

	public float stayAtkPer;

	public int splashRange;

	public int attackSkill;

	public int skill;

	public int maxCurseStack;

	public List<(int buffId, int transferCount)> curseStackListWithTransferCount;

	public int bead;

	public GameUnit beadFrom;

	public int lastSkill;

	public int overrideSkillChange;

	public int lastAttackSkill;

	public int overrideSkillChangeAttack;

	public float attackMinusPer;

	public bool isManaLocked;

	public RangeInfo maxAtkRange;

	public AwesomeStringDict<int> customStacks;

	public IntReactiveProperty[] gimmickStacks;

	public Action<StatType> additionalStatExpression;

	private readonly BuffOption.BuffOptionConditionParams _buffOptionContext;

	public readonly float[,] statBuffValueCache;

	public readonly float?[] statBuffTotalPerValueCache;

	public readonly float?[] statBuffDebuffPerValueCache;

	private Dictionary<GetValueFuncTypeNumeric, AwesomeStringDict<float>> _buffValueCacheDictNumeric;

	private Dictionary<GetValueFuncTypeBool, AwesomeStringDict<bool>> _buffValueCacheDictBool;

	private Dictionary<GetValueFuncTypeText, AwesomeStringDict<string>> _buffValueCacheDictText;

	private Dictionary<GetValueFuncTypeRange, AwesomeStringDict<RangeInfo>> _buffValueCacheDictRange;

	private List<Buff> _removableUnits;

	private List<Buff> _cachedList;

	private (float, float) _connectedBuffValue;

	public Buff gaugedBuff => null;

	public BuffManager(GameUnit target)
	{
	}

	public virtual void Add(Buff unit, bool simply = false)
	{
	}

	public void Clear()
	{
	}

	public virtual void Remove(Buff unit, bool updateStat = true)
	{
	}

	public void RemoveAll(Func<Buff, bool> filter)
	{
	}

	public void RemoveType(Buff.BuffType key)
	{
	}

	public void Remove(string key)
	{
	}

	public void RemoveSkill(int id)
	{
	}

	public void RemoveSkill(int id, int count)
	{
	}

	public void RemoveSkillFromThisUnit(int id, GameUnit from)
	{
	}

	public void RemoveItem(int id, bool once = true)
	{
	}

	public void RemoveItem(Item item)
	{
	}

	public void RemoveRune(Rune rune)
	{
	}

	public void RemoveRune(int id, bool once = true)
	{
	}

	public void Update()
	{
	}

	public void SetRootToxicBuff()
	{
	}

	public Buff BindStat(StatInfo statInfo, Func<float> calcFunc)
	{
		return null;
	}

	public Buff AddStatBySubBuff(Buff parent, StatInfo changeStatInfo, bool update = true, int maxOverlapCount = 1, Dictionary<string, bool> defaultBooleanKeyValue = null)
	{
		return null;
	}

	public void RemoveStatFromSubBuff(Buff buff, bool update = true)
	{
	}

	public void HandleDefDenBuff(Buff buff, bool init)
	{
	}

	public void HandleUpdateStat(StatType changeStatInfoType, bool forceHealHpDiffWhenUpdateHp = false)
	{
	}

	public float GetStatBuffWithValueType(StatInfo getStatInfo)
	{
		return 0f;
	}

	public float GetMaxNonOverlappingDebuff(StatType statType)
	{
		return 0f;
	}

	public float GetStatByParticularBuff(StatInfo getStatInfo)
	{
		return 0f;
	}

	public static bool CanCacheStat(StatType statType)
	{
		return false;
	}

	public float GetDisplayedDamageStat(StatType statType, float originValue)
	{
		return 0f;
	}

	public float GetBuffedStat(StatType statType, float originValue)
	{
		return 0f;
	}

	public void SetOnAdded(OnAdded callback)
	{
	}

	public void SetOnRemoved(OnRemoved callback)
	{
	}

	public bool Has(string key)
	{
		return false;
	}

	public bool HasSkill(int id)
	{
		return false;
	}

	public bool HasSkillRoot(int id)
	{
		return false;
	}

	public int GetSkillCount(int id)
	{
		return 0;
	}

	public int GetSkillRootCount(int id)
	{
		return 0;
	}

	public void AddSkillTime(float time)
	{
	}

	public Buff Get(Buff.BuffType type)
	{
		return null;
	}

	public Buff GetBuffBySkill(ResourceSkill resSkill)
	{
		return null;
	}

	public Buff GetBuffData(int id)
	{
		return null;
	}

	public List<Buff> GetBuffs(Buff buff)
	{
		return null;
	}

	public Buff GetBuff(Func<Buff, bool> condition)
	{
		return null;
	}

	public Buff GetLastBuff(Func<Buff, bool> condition)
	{
		return null;
	}

	public List<Buff> GetBuffs(Func<Buff, bool> condition)
	{
		return null;
	}

	public int GetBuffCount(string key)
	{
		return 0;
	}

	public int GetBuffCountByType(Buff.BuffType type)
	{
		return 0;
	}

	public bool HasValue(string key)
	{
		return false;
	}

	public Buff GetBuffByValue(string key)
	{
		return null;
	}

	public List<Buff> GetBuffsByValue(string key, bool usePool = false)
	{
		return null;
	}

	[CanBeNull]
	public List<Buff> GetBuffsByType(Buff.BuffType type)
	{
		return null;
	}

	public RangeInfo GetValueRange(string key)
	{
		return null;
	}

	public int GetValueIntSum(string key)
	{
		return 0;
	}

	public int GetValueIntMin(string key)
	{
		return 0;
	}

	public int GetValueIntMax(string key)
	{
		return 0;
	}

	public int GetValueIntMaxGroupBySameBuff(string key)
	{
		return 0;
	}

	public int GetValueIntSumGroupBySameBuff(string key)
	{
		return 0;
	}

	public int GetValueIntMultGroupBySameBuff(string key)
	{
		return 0;
	}

	public bool GetValueBoolOr(string key)
	{
		return false;
	}

	public bool GetValueBoolAnd(string key)
	{
		return false;
	}

	public List<int> GetValueIntList(string key, List<int> @default = null)
	{
		return null;
	}

	public float GetValueFloatSum(string key)
	{
		return 0f;
	}

	public List<float> GetValueFloatListGroupBySameBuff(string key)
	{
		return null;
	}

	public float GetValueFloatMaxGroupBySameBuff(string key)
	{
		return 0f;
	}

	public float GetValueFloatMultGroupBySameBuff(string key, bool treatAsPercent = true)
	{
		return 0f;
	}

	public float GetValueFloatMin(string key)
	{
		return 0f;
	}

	public float GetValueFloatMax(string key)
	{
		return 0f;
	}

	public string GetValueText(string key)
	{
		return null;
	}

	public List<string> GetValueTextList(string key, List<string> @default = null)
	{
		return null;
	}

	public ResourceUnit.Potential FindPotential(Func<ResourceUnit.Potential, bool> checkFunc)
	{
		return null;
	}

	public List<ResourceUnit.Potential> FindPotentials(Func<ResourceUnit.Potential, bool> checkFunc)
	{
		return null;
	}

	public bool GetBuffInRange(GameUnit otherUnit)
	{
		return false;
	}

	public RangeInfo GetBuffRangeInfo()
	{
		return null;
	}

	public bool HasBuffFrom(GameUnit unit, Buff.BuffType type)
	{
		return false;
	}

	public void HandleUnitAttack()
	{
	}

	public bool IsLastAttackSkillHit()
	{
		return false;
	}

	public void HandleUnitHit()
	{
	}

	public void HandleUnitCastSkill()
	{
	}

	public void ClearAtRoundEnd()
	{
	}

	public void UpdateConnectedBuffValues()
	{
	}

	private (float, float) GetConnectedBuffValues()
	{
		return default((float, float));
	}

	public void ApplyBuffOption(BuffOption.Conditions conditions, ref DamageInfo damageInfo, List<GameUnit> defaultTargets = null, ResourceRogueLikeRoom.Type roomType = ResourceRogueLikeRoom.Type.None)
	{
	}

	public void ResetBuffOptionCounter()
	{
	}

	public void RefreshBuffs(Func<Buff, bool> condition)
	{
	}

	public void TrySetBuffGaugeByRemoveBuffAfterAttackCountBuff(Buff buff)
	{
	}

	public void ConsumePriorityShield(int value)
	{
	}

	public void ClearValueCache()
	{
	}

	public void ClearAndBindGimmickStackAction()
	{
	}
}
