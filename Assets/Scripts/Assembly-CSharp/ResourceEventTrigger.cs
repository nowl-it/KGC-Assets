using System;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

public class ResourceEventTrigger : ResourceBase<ResourceEventTrigger>
{
	public enum TargetType
	{
		PlayerUnit = 0,
		EnemyUnit = 1,
		AllUnit = 2
	}

	public enum TriggerType
	{
		StartBattle = 0,
		PerSecond = 1,
		GetHit = 2,
		Dead = 3,
		BaseAttackCount = 4,
		SkillAttackCount = 5,
		HpRatio = 6,
		HpRatioOnce = 7,
		TargetAttack = 8,
		TargetKill = 9,
		ReceiveHeal = 10,
		GiveHeal = 11,
		GiveDamage = 12,
		ReceiveCC = 13,
		ClearUnitBuffs = 14,
		StartGame = 15
	}

	public enum FromType
	{
		None = 0,
		Artifact = 1
	}

	public enum EventType
	{
		SpawnPlayerUnit = 0,
		SpawnEnemyUnit = 1,
		GiveGold = 2,
		SelfHeal = 3,
		AddBuffToTarget = 4,
		AddBuffToSelf = 5,
		AddBuffsToSelfByUnitCount = 6,
		AddShieldPerToSelf = 7,
		HealManaToMaxAndSetAttackFlag = 8,
		SetAttackHpDrain = 9,
		SetSkillHpDrain = 10,
		AddMaxManaPer = 11,
		AddSuperShieldToSelf = 12,
		AddItem = 13
	}

	public enum TriggerValueType
	{
		None = 0,
		Stun = 1,
		Fear = 2,
		Charm = 3
	}

	[Serializable]
	public struct TriggerInfo
	{
		public TriggerType triggerType;

		public TriggerValueType valueType;

		public float value;

		public float delay;
	}

	[Serializable]
	public class EventInfo
	{
		public EventType eventType;

		public ResourceUnit.Role targetRole;

		public ResourceUnit.Region targetRegion;

		public int highestUnitCount;

		public int lowestUnitCount;

		public float value;

		public List<ResourceStage.Spawn> spawnInfoList;

		public bool IsBuffDataEvent()
		{
			return false;
		}
	}

	[Serializable]
	public class EventTriggerInfo
	{
		public TargetType targetType;

		public List<EventTrigger> eventTriggers;

		public EventTriggerInfo Reverse()
		{
			return null;
		}
	}

	[Serializable]
	public struct EventTrigger
	{
		public TriggerInfo triggerInfo;

		public EventInfo eventInfo;

		public EventTrigger(TriggerInfo triggerInfo, EventInfo eventInfo)
		{
			this.triggerInfo = default(TriggerInfo);
			this.eventInfo = null;
		}
	}

	private string _descKey;

	private string _iconName;

	public Color _selectedColor;

	public List<EventTriggerInfo> eventTriggerInfos;

	public int applyArenaSeason;

	public int applyArenaSemiSeason;

	public string desc => null;

	public Sprite icon => null;

	public Color selectedColor => default(Color);

	public int removeAfterBattleCount { get; private set; }

	public bool isRogueLikeTrial { get; private set; }

	public ResourceUnit.Role targetRole { get; private set; }

	public ResourceUnit.Region targetRegion { get; private set; }

	public static FromType GetFromType(int eventTriggerId)
	{
		return default(FromType);
	}

	public override void Init(XmlNode n)
	{
	}

	private EventTriggerInfo GetEventTriggerInfo(XmlNode node, string path, TargetType type)
	{
		return null;
	}

	public ResourceUnit.Role GetTargetRole()
	{
		return default(ResourceUnit.Role);
	}

	public ResourceUnit.Region GetTargetRegion()
	{
		return default(ResourceUnit.Region);
	}

	public static bool IsValueCoolTimeTriggerType(TriggerType triggerType)
	{
		return false;
	}

	public static List<ResourceEventTrigger> FindGrandArenaEventTriggers(int season, int semiSeason)
	{
		return null;
	}

	public static void Load(Action callback = null)
	{
	}
}
