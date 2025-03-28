using System;
using System.Collections.Generic;
using UnityEngine.Rendering;

public class EventTriggerManager
{
	public class TriggerData
	{
		public List<GameUnit> units;

		public GameUnit target;

		public ResourceEventTrigger.TriggerInfo triggerInfo;

		private static readonly List<TriggerData> _triggerDataPool;

		private TriggerData()
		{
		}

		public TriggerData SetUnits(List<GameUnit> units)
		{
			return null;
		}

		public TriggerData SetUnit(GameUnit unit)
		{
			return null;
		}

		public TriggerData SetTarget(GameUnit target)
		{
			return null;
		}

		public TriggerData SetTriggerInfo(ResourceEventTrigger.TriggerInfo triggerInfo)
		{
			return null;
		}

		public static TriggerData NewItem()
		{
			return null;
		}

		public static void ReturnItem(TriggerData item)
		{
		}
	}

	public struct UnitTriggerKey
	{
		public int unitID;

		public int eventTriggerListKey;

		public int eventTriggerListIdx;

		public int eventTriggerIdx;
	}

	public class UnitAlarmData
	{
		public HashSet<int> baseAttackCounters;

		public HashSet<int> skillAttackCounters;

		public HashSet<int> hpRatioCounters;

		public HashSet<int> hpRatioOnceCounters;
	}

	public class UnitAlarmTriggeredData
	{
		public HashSet<int> triggeredHpRatioOnceCounters;
	}

	[Serializable]
	public class SaveData
	{
		public SerializedDictionary<int, SerializedList<ResourceEventTrigger.EventTriggerInfo>> eventTriggerInfoListDic;

		public SerializedDictionary<int, int> eventTriggerRemoveAfterBattleCountDic;
	}

	private int _battleManagerIdx;

	public const int REVERSED_EVENT_TRIGGER_ID_OFFSET = 1000000000;

	private SaveData _saveData;

	private Dictionary<int, List<ResourceEventTrigger.EventTriggerInfo>> eventTriggerInfoListDic;

	private Dictionary<int, int> eventTriggerRemoveAfterBattleCountDic;

	private Dictionary<UnitTriggerKey, float> unitTriggerCoolTimeDic;

	private List<int> _oneTimeEventTriggerIds;

	private BattleManager _battleManager => null;

	public EventTriggerManager(int battleManagerIdx)
	{
	}

	public bool HasEventTriggerInfo(int id)
	{
		return false;
	}

	public void AddEventTriggerInfo(int id, bool restoreAllUnits = false, bool once = false, bool reverse = false)
	{
	}

	public string GetTriggerKeys()
	{
		return null;
	}

	private bool CheckEventTriggerFromType(int eventTriggerKey, ResourceEventTrigger.FromType fromType)
	{
		return false;
	}

	public void RemoveAllReversedEventTriggerInfo()
	{
	}

	public void RemoveArtifactEventTriggerInfo()
	{
	}

	public void RemoveEventTriggerInfo(int id)
	{
	}

	public void RemoveOnceEventTrigger()
	{
	}

	private void HandleRemoveEventTriggerInfo(int id)
	{
	}

	private void HandleAddTriggerInfo(int id, bool restoreAllUnits)
	{
	}

	public void ClearAll()
	{
	}

	public void CheckRemoveAfterBattleCountLeft()
	{
	}

	public void ClearEventTriggerInfo()
	{
	}

	public void ClearUnitTriggerCoolTimeDic()
	{
	}

	public void ClearAllUnitAlarmData()
	{
	}

	public void SetAllUnitAlarmData()
	{
	}

	public void SetUnitAlarmData(GameUnit unit)
	{
	}

	private UnitAlarmData GetUnitAlarmData(GameUnit unit)
	{
		return null;
	}

	public void HandleTriggerData(TriggerData triggerData)
	{
	}

	private bool CheckTriggerInfoMatch(TriggerData triggerData, ResourceEventTrigger.TriggerInfo triggerInfo, UnitTriggerKey unitTriggerKey)
	{
		return false;
	}

	private void HandleEventTriggered(GameUnit target, ResourceEventTrigger.EventInfo eventInfo, int? delayPhaseChecker = null)
	{
	}

	public SaveData ToSaveData()
	{
		return null;
	}

	public void LoadFromSaveData(SaveData saveData)
	{
	}
}
