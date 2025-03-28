using System;
using System.Collections.Generic;
using System.Xml;
using JetBrains.Annotations;

public class WorldTrigger : TriggerBase<WorldTrigger.Conditions, WorldTrigger.WorldTriggerConditionParams>
{
	public enum Conditions
	{
		None = 0,
		ImmediatelyOnce = 1,
		ImmediatelyOnceWithoutReenter = 2,
		PlayerLose = 3,
		InvadeSuccess = 4,
		StageStart = 5,
		AddSlot = 6,
		MergeUnit = 7,
		UnitLevelUp = 8,
		AbilityLevelUp = 9,
		BattleLose = 10,
		BattleStart = 11,
		InvadeShopReroll = 12,
		UseInvadeItem = 13,
		BuyInvadeItem = 14,
		Dispose = 15,
		OverStack = 16,
		UnderStack = 17,
		TriggerCount = 18,
		ReqFieldUnitCount = 19,
		Life = 20,
		ReadyPhaseStart = 21,
		InvadeItemCountOver = 22,
		InvadeItemUnder = 23,
		ReqDeckUnitCount = 24,
		BuildingLevel = 25
	}

	public class WorldTriggerConditionParams : ConditionParams<Conditions>
	{
		public BattleManager battle;

		public Dictionary<string, float> counters;

		public bool toEnemy;
	}

	public struct ActionParams
	{
		public BattleManager battle;

		public bool toEnemy;
	}

	protected class ValueParams
	{
		public BattleManager battle;
	}

	protected delegate float ValueCalculator(ValueParams @params);

	public delegate void TriggerAction(ActionParams @params);

	protected List<ValueCalculator> valueCalculator;

	public readonly Dictionary<string, float> counters;

	private TriggerAction _triggerActions;

	private WorldTriggerConditionParams _conditionParamsInstance;

	public WorldTrigger(XmlNode n, XmlNode inherit)
	{
	}

	public WorldTrigger(WorldTrigger worldTrigger)
	{
	}

	public bool CheckConditions(BattleManager battleManager, Conditions condition, bool toEnemy)
	{
		return false;
	}

	public bool CheckAndOperatorConditions(BattleManager battleManager)
	{
		return false;
	}

	[UsedImplicitly]
	private void AddCheckConditionAddSlot(Dictionary<string, string> param)
	{
	}

	private bool AddSlot(WorldTriggerConditionParams @params, int slotCount)
	{
		return false;
	}

	[UsedImplicitly]
	private void AddCheckConditionStageStart(Dictionary<string, string> param)
	{
	}

	private bool StartStage(WorldTriggerConditionParams @params, int stage)
	{
		return false;
	}

	[UsedImplicitly]
	private void AddCheckConditionMergeUnit(Dictionary<string, string> param)
	{
	}

	private bool MergeUnit(WorldTriggerConditionParams @params, int level)
	{
		return false;
	}

	[UsedImplicitly]
	private void AddCheckConditionUnitLevelUp(Dictionary<string, string> param)
	{
	}

	private bool UnitLevelUp(WorldTriggerConditionParams @params, int level)
	{
		return false;
	}

	[UsedImplicitly]
	private void AddCheckConditionAbilityLevelUp(Dictionary<string, string> param)
	{
	}

	private bool AbilityLevelUp(WorldTriggerConditionParams @params, int level)
	{
		return false;
	}

	[UsedImplicitly]
	private void AddCheckConditionOverStack(Dictionary<string, string> param)
	{
	}

	private bool OverStack(WorldTriggerConditionParams @params, string stackName, int value)
	{
		return false;
	}

	[UsedImplicitly]
	private void AddCheckConditionUnderStack(Dictionary<string, string> param)
	{
	}

	private bool UnderStack(WorldTriggerConditionParams @params, string stackName, int value)
	{
		return false;
	}

	[UsedImplicitly]
	private void AddCheckConditionTriggerCount(Dictionary<string, string> param)
	{
	}

	private bool TriggerCount(WorldTriggerConditionParams @params, int value)
	{
		return false;
	}

	[UsedImplicitly]
	private void AddCheckConditionReqFieldUnitCount(Dictionary<string, string> param)
	{
	}

	private bool ReqFieldUnitCount(WorldTriggerConditionParams @params, ResourceUnit.Region region, ResourceUnit.Role role, int value)
	{
		return false;
	}

	[UsedImplicitly]
	private void AddCheckConditionReqDeckUnitCount(Dictionary<string, string> param)
	{
	}

	private bool ReqDeckUnitCount(WorldTriggerConditionParams @params, ResourceUnit.Region region, ResourceUnit.Role role, int value)
	{
		return false;
	}

	[UsedImplicitly]
	private void AddCheckConditionLife(Dictionary<string, string> param)
	{
	}

	private bool CheckLife(WorldTriggerConditionParams @params, int value)
	{
		return false;
	}

	[UsedImplicitly]
	private void AddCheckConditionBuildingLevel(Dictionary<string, string> param)
	{
	}

	private bool CheckBuildingLevel(WorldTriggerConditionParams @params, int index, int targetValue, bool greaterEqual)
	{
		return false;
	}

	[UsedImplicitly]
	private void AddCheckConditionReadyPhaseStart(Dictionary<string, string> param)
	{
	}

	private bool StartReadyPhase(WorldTriggerConditionParams @params, int stage)
	{
		return false;
	}

	[UsedImplicitly]
	private void AddCheckConditionInvadeItemCountOver(Dictionary<string, string> param)
	{
	}

	private bool InvadeItemCountOver(WorldTriggerConditionParams @params, int value)
	{
		return false;
	}

	[UsedImplicitly]
	private void AddCheckConditionInvadeItemCountUnder(Dictionary<string, string> param)
	{
	}

	private bool InvadeItemCountUnder(WorldTriggerConditionParams @params, int value)
	{
		return false;
	}

	protected override BoolOperator GetOperator(Conditions inputKey)
	{
		return default(BoolOperator);
	}

	public void Trigger(BattleManager battle, bool toEnemy = false)
	{
	}

	[UsedImplicitly]
	private void AddTriggerActionAddGold(Dictionary<string, string> param)
	{
	}

	private void AddGold(ActionParams @params)
	{
	}

	[UsedImplicitly]
	private void AddTriggerActionAddInvadePoint(Dictionary<string, string> param)
	{
	}

	private void AddInvadePoint(ActionParams @params)
	{
	}

	[UsedImplicitly]
	private void AddTriggerActionAddAbilityExp(Dictionary<string, string> param)
	{
	}

	private void AddAbilityExp(ActionParams @params)
	{
	}

	[UsedImplicitly]
	private void AddTriggerActionAddInvadeShopRerollCount(Dictionary<string, string> param)
	{
	}

	private void AddInvadeShopRerollCount(ActionParams @params)
	{
	}

	[UsedImplicitly]
	private void AddTriggerActionAddAbilityRerollCount(Dictionary<string, string> param)
	{
	}

	private void AddAbilityRerollCount(ActionParams @params)
	{
	}

	[UsedImplicitly]
	private void AddTriggerActionAddItem(Dictionary<string, string> param)
	{
	}

	private void AddItem(BattleManager battle, Item item)
	{
	}

	private void AddItem(ActionParams @params, int id)
	{
	}

	private void AddItem(ActionParams @params, ResourceItem.EquipType type, int tier)
	{
	}

	[UsedImplicitly]
	private void AddTriggerActionRemoveItem(Dictionary<string, string> param)
	{
	}

	private void RemoveItem(ActionParams @params, int id)
	{
	}

	[UsedImplicitly]
	private void AddTriggerActionEquipItem(Dictionary<string, string> param)
	{
	}

	private void EquipItem(ActionParams @params, int id)
	{
	}

	[UsedImplicitly]
	private void AddTriggerActionAddInvadeItem(Dictionary<string, string> param)
	{
	}

	private void AddInvadeItem(ActionParams @params, int id)
	{
	}

	private void AddInvadeItem(ActionParams @params, int theme, int tier)
	{
	}

	[UsedImplicitly]
	private void AddTriggerActionRemoveInvadeItem(Dictionary<string, string> param)
	{
	}

	private void RemoveInvadeItem(ActionParams @params)
	{
	}

	[UsedImplicitly]
	private void AddTriggerActionCopyInvadeItem(Dictionary<string, string> param)
	{
	}

	private void CopyInvadeItem(ActionParams @params)
	{
	}

	[UsedImplicitly]
	private void AddTriggerActionAddBuildingLevel(Dictionary<string, string> param)
	{
	}

	private void AddBuildingLevel(ActionParams @params, int index)
	{
	}

	[UsedImplicitly]
	private void AddTriggerActionApplyEventTrigger(Dictionary<string, string> param)
	{
	}

	private void ApplyEventTrigger(ActionParams @params, int id, bool once)
	{
	}

	[UsedImplicitly]
	private void AddTriggerActionAddInvadeItemProbPer(Dictionary<string, string> param)
	{
	}

	private void AddInvadeItemProbPer(ActionParams @params, List<int> isBoss, List<int> theme, List<int> tiers)
	{
	}

	[UsedImplicitly]
	private void AddTriggerActionAddInvadeItemTierProbPer(Dictionary<string, string> param)
	{
	}

	private void AddInvadeItemTierProbPer(ActionParams @params, List<int> tiers)
	{
	}

	[UsedImplicitly]
	private void AddTriggerActionIncreaseCustomStack(Dictionary<string, string> param)
	{
	}

	private void IncreaseCustomStack(ActionParams @params, string stackName, int max)
	{
	}

	[UsedImplicitly]
	private void AddTriggerActionSetCustomStack(Dictionary<string, string> param)
	{
	}

	private void SetCustomStack(ActionParams @params, string stackName)
	{
	}

	[UsedImplicitly]
	private void AddTriggerActionAddInvadeItemCost(Dictionary<string, string> param)
	{
	}

	private void AddInvadeItemCost(ActionParams @params)
	{
	}

	[UsedImplicitly]
	private void AddTriggerActionChangeInvadeItems(Dictionary<string, string> param)
	{
	}

	private void ChangeInvadeItems(ActionParams @params, int from, int to)
	{
	}

	[UsedImplicitly]
	private void AddTriggerActionUpgradeInvadeItem(Dictionary<string, string> param)
	{
	}

	private void UpgradeInvadeItem(ActionParams @params, int theme, bool refreshWaiting)
	{
	}

	[UsedImplicitly]
	private void AddTriggerActionReplaceInvadeItem(Dictionary<string, string> param)
	{
	}

	private void ReplaceInvadeItem(ActionParams @params, List<(int, int)> replacements)
	{
	}

	[UsedImplicitly]
	private void AddTriggerActionUnlockInvadeItem(Dictionary<string, string> param)
	{
	}

	private void UnlockInvadeItem(ActionParams @params, List<int> ids)
	{
	}

	[UsedImplicitly]
	private void AddTriggerActionSpawnInvade(Dictionary<string, string> param)
	{
	}

	private void SpawnInvade(ActionParams @params, int id)
	{
	}

	[UsedImplicitly]
	private void AddTriggerActionShowRandomItem(Dictionary<string, string> param)
	{
	}

	private void ShowRandomItem(ActionParams @params, int tier)
	{
	}

	[UsedImplicitly]
	private void AddTriggerActionAddSlotUpgradeCost(Dictionary<string, string> param)
	{
	}

	private void AddSlotUpgradeCost(ActionParams @params)
	{
	}

	[UsedImplicitly]
	private void AddTriggerActionHighestLevelUnitLevelUp(Dictionary<string, string> param)
	{
	}

	private void HighestLevelUnitLevelUp(ActionParams @params)
	{
	}

	[UsedImplicitly]
	private void AddTriggerActionAddSellPriceOnLevel1UnitForSeconds(Dictionary<string, string> param)
	{
	}

	private void AddSellPriceOnLevel1UnitForSeconds(ActionParams @params, int addGold, float time)
	{
	}

	[UsedImplicitly]
	private void AddTriggerActionUnlimitedSpawnLevelUpAndPreventSellUnit(Dictionary<string, string> param)
	{
	}

	private void UnlimitedSpawnLevelUpAndPreventSellUnit(ActionParams @params)
	{
	}

	[UsedImplicitly]
	private void AddTriggerActionEnableDoubleInvadeUnit(Dictionary<string, string> param)
	{
	}

	private void DoubleInvadeUnit(ActionParams @params)
	{
	}

	[UsedImplicitly]
	private void AddTriggerActionEnableDevilStage(Dictionary<string, string> param)
	{
	}

	private void EnableDevilStage(ActionParams @params)
	{
	}

	[UsedImplicitly]
	private void AddTriggerActionAddConstantEnemyBerserkValue(Dictionary<string, string> param)
	{
	}

	private void AddConstantEnemyBerserkValue(ActionParams @params, int triggerId)
	{
	}

	public float CalculateValue(BattleManager battle)
	{
		return 0f;
	}

	[UsedImplicitly]
	private void AddCalculateFixedValue(float value, Dictionary<string, string> param)
	{
	}

	[UsedImplicitly]
	private void AddCalculateOwnGold(float value, Dictionary<string, string> param)
	{
	}

	[UsedImplicitly]
	private void AddCalculateSlotUpgradeCost(float value, Dictionary<string, string> param)
	{
	}

	protected override int? GetSeed(WorldTriggerConditionParams @params)
	{
		return null;
	}

	protected override bool IsSameCondition(Conditions a, Conditions b)
	{
		return false;
	}

	protected override bool Parse(ref XmlNode n, XmlNode inherit)
	{
		return false;
	}

	public static Func<BattleManager, WorldTriggerBundle, string> ParseParamFunc(XmlNode root, XmlNode descParam, XmlNode inherit, string representType = "")
	{
		return null;
	}
}
