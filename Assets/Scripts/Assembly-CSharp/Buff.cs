using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Awesomepiece.Model;
using UnityEngine;

public class Buff
{
	public enum BuffType
	{
		BuffOption = 0,
		Bind = 1,
		Item = 2,
		TileBuff = 3,
		Skill = 4,
		Synergy = 5,
		Potential = 6,
		EventTrigger = 7,
		CustomBuff = 8,
		Treasure = 9,
		Accessory = 10,
		Rune = 11,
		Mark = 12
	}

	public struct CustomBuff
	{
		public Dictionary<string, string> textKeyValue;

		public Dictionary<string, float> numericKeyValue;

		public Dictionary<string, bool> booleanKeyValue;

		public object buffSource;

		public float time;

		public Sprite icon;

		public int maxOverlapCount;

		public bool resetOverlapBuffTime;

		public bool rented;

		public Action<Buff> initializeAction;

		public Action<Buff> disposeAction;
	}

	public enum BuffResourceType
	{
		Potential = 0,
		BuffData = 1,
		Skill = 2
	}

	public struct BuildActionParameter
	{
		public BuffResourceType resourceType;

		public ResourceUnit.Potential potential;

		public ResourceBuffData buffData;
	}

	private static int UniqueIdCounter;

	private int _uid;

	private List<BuffManager.StatType> _updatedStats;

	private List<int> _updatedStatAndStatValuesTmp;

	private Dictionary<int, float> _updatedStatAndStatValues;

	private List<BuffManager.StatType> _updatedDebuffPerStats;

	public GameUnit unit;

	public GameUnit from;

	public BuffType type;

	public float value;

	public float value2;

	public float totalTime;

	public float time;

	public Sprite icon;

	public bool infinite;

	public bool showIcon;

	public int maxOverlapCount;

	public bool resetOverlapBuffTime;

	public int damageDealtByBuffToTargetAttack;

	public CustomBuff customBuff;

	public Item item;

	public ResourceSkill resSkill;

	public ResourceSynergy resSynergy;

	public ResourceUnit.Potential potential;

	public ResourceBuffData buffData;

	public TreasureModel treasure;

	public List<AccessoryModel> accessories;

	private float _tick;

	private float _tickInterval;

	private int _tickDamageCount;

	public float valueRatio;

	private float _healTickInterval;

	private float _healTick;

	private int _healTickValue;

	private float _soundTickInterval;

	private float _soundTick;

	private string _soundTickValue;

	private float _stayTickInterval;

	private float _stayTick;

	private int _moveTickValue;

	private float _grabTickInterval;

	private float _grabTick;

	public int attackCountAfterBuff;

	public int hitCountAfterBuff;

	public int skillCountAfterBuff;

	public int addedRemoveBuffAfterAttackCount;

	private float _buffDataValue;

	private Dictionary<string, object> _values;

	public List<BuffOption> buffOptionList;

	public Action disposeQueue;

	public Action initQueue;

	public Vector2Int? unitBeforePos;

	public HashSet<GameUnit> manaflowTargetsSet;

	public RangeInfo buffRange;

	private static readonly int _loopend;

	private bool _simplyInitialized;

	private bool _disposed;

	private bool _initialized;

	private bool _defDenHandled;

	public bool isRootToxicBuff;

	private static Action<Buff>[] _statBuffActionCache;

	private static Action<Buff>[] _statDebuffActionCache;

	private static Action<Buff>[] _extraStatBuffActionCache;

	public int id => 0;

	public int intValue => 0;

	public Buff()
	{
	}

	public Buff(GameUnit unit)
	{
	}

	public Buff(GameUnit unit, CustomBuff data, BuffType type = BuffType.CustomBuff, GameUnit from = null)
	{
	}

	public Buff(GameUnit unit, Item item, float valueRatio = 1f, BuffType type = BuffType.Item)
	{
	}

	public Buff(GameUnit unit, Rune rune, BuffType type = BuffType.Rune)
	{
	}

	public Buff(GameUnit unit, ResourceSkill resSkill, BuffType type = BuffType.Skill, GameUnit from = null)
	{
	}

	public Buff(GameUnit unit, ResourceSynergy resSynergy)
	{
	}

	public Buff(GameUnit unit, ResourceUnit.Potential potential)
	{
	}

	public Buff(GameUnit unit, ResourceBuffData buffData, GameUnit from = null, [Optional] float? duration, [Optional] float? valueRatio)
	{
	}

	public Buff(GameUnit unit, List<BuffOption> buffOptionList)
	{
	}

	public Buff(GameUnit unit, TreasureModel treasureModel)
	{
	}

	public Buff(GameUnit unit, List<AccessoryModel> accessoryModels)
	{
	}

	public void InitSimpleStatBuff()
	{
	}

	public virtual void Init()
	{
	}

	private void CheckValuesOnInit()
	{
	}

	private void BuildUpdateStatImpl(string key, ref bool defDenHandled)
	{
	}

	private void BuildUpdatedStat()
	{
	}

	public virtual bool HasValue(string key)
	{
		return false;
	}

	public virtual int GetValueInt(string key)
	{
		return 0;
	}

	public virtual float GetValueFloat(string key)
	{
		return 0f;
	}

	public virtual bool GetValueBool(string key, bool defaultValue = false)
	{
		return false;
	}

	public virtual string GetValueText(string key)
	{
		return null;
	}

	public void AddTime(float time)
	{
	}

	public virtual void Update()
	{
	}

	private void ResetStayTick()
	{
	}

	private void HandleStayTick()
	{
	}

	private void DisposeWhenSimplyInitialized(bool handleStatUpdate, bool releasePool)
	{
	}

	public virtual void Dispose(bool handleStatUpdate = true, bool releasePool = true)
	{
	}

	private void CheckValuesOnDispose()
	{
	}

	private void ReleasePool()
	{
	}

	private void DivinePowerProcess()
	{
	}

	public object GetValue(string key)
	{
		return null;
	}

	public void SetValue(string key, object value)
	{
	}

	public void ClearAtRoundEnd()
	{
	}

	public static bool operator ==(Buff a, Buff b)
	{
		return false;
	}

	public static bool operator !=(Buff a, Buff b)
	{
		return false;
	}

	public (RangeInfo, Vector2Int) GetTileBuffRangeAndDir(Vector2Int tilePos)
	{
		return default((RangeInfo, Vector2Int));
	}

	public static void EmptyAction(Buff buff)
	{
	}

	public static void InitDefDenOrDefPenAction(Buff buff)
	{
	}

	public static Action<Buff> GetStatBuffAction(BuffManager.StatInfo statInfo, float? statValue)
	{
		return null;
	}

	public static Action<Buff> GetStatDebuffAction(BuffManager.StatType debuffStatType)
	{
		return null;
	}

	public static Action<Buff> GetExtraStatBuffAction(BuffManager.StatType statType, string key, float? statValue)
	{
		return null;
	}

	public static void BuildInitializeAction(ResourceUnit.Potential potential)
	{
	}

	public static void BuildInitializeAction(ResourceBuffData buffData)
	{
	}

	private static void BuildInitializeActionImpl(ref Action<Buff> action, BuildActionParameter param)
	{
	}

	public static void BuildDisposeAction(ResourceUnit.Potential potential)
	{
	}

	public static void BuildDisposeAction(ResourceBuffData buffData)
	{
	}

	private static void BuildDisposeActionImpl(ref Action<Buff> action, BuildActionParameter param)
	{
	}

	private static bool HasValueStatic(string key, BuildActionParameter param)
	{
		return false;
	}

	private static bool GetValueBoolStatic(string key, BuildActionParameter param, bool defaultValue = false)
	{
		return false;
	}

	private static float? GetValueFloatStatic(string key, BuildActionParameter param)
	{
		return null;
	}

	private static void BuildUpdatedStatStatic(ref Action<Buff> action, BuildActionParameter param)
	{
	}
}
