using System.Collections.Generic;
using System.Xml;
using Awesomepiece.Model;
using JetBrains.Annotations;

public class BuffOption : TriggerBase<BuffOption.Conditions, BuffOption.BuffOptionConditionParams>
{
	public enum Conditions
	{
		None = 0,
		Always = 1,
		Once = 2,
		BattleEnd = 3,
		BattleStart = 4,
		EnterRoom = 5,
		BattleWin = 6,
		BattleLose = 7,
		Attack = 8,
		CastSkill = 9,
		DuringSkill = 10,
		AfterAttack = 11,
		AfterCastSkill = 12,
		AfterAttackMotion = 13,
		BeforeDealDamage = 14,
		DealDamage = 15,
		BeforeTakeDamage = 16,
		TakeDamage = 17,
		SuperShieldBroken = 18,
		OnHpTrigger = 19,
		ConsumeItem = 20,
		NoSameRunes = 21,
		UnderHpPer = 22,
		OverHpPer = 23,
		KillEnemy = 24,
		Dispose = 25,
		DuringBattle = 26,
		DuringBattleLate = 27,
		EquippedItem = 28,
		FeedingItem = 29,
		EquipItem = 30,
		Heal = 31,
		ManaHeal = 32,
		AddShield = 33,
		BrokenShield = 34,
		TeamDead = 35,
		Dead = 36,
		BeforeDead = 37,
		TileMove = 38,
		BeforeTileMove = 39,
		HasUnit = 40,
		AfterMove = 41,
		OverStack = 42,
		UnderStack = 43,
		DefaultTargetInRange = 44,
		ThemeUnder = 45,
		Invincible = 46,
		AdjustNormalDamage = 47,
		StatAOverStatB = 48,
		TargetIsFixedTarget = 49,
		DefDenListIsNotEmpty = 50,
		MeIsBestTierUnit = 51,
		HandleDefDen = 52,
		HandleGiveHardCC = 53,
		Execution = 54,
		TilePosY = 55
	}

	public class BuffOptionConditionParams : ConditionParams<Conditions>
	{
		public Buff parent;

		public GameUnit me;

		public GameUnit target;

		public DamageInfo damageInfo;

		public ResourceRogueLikeRoom.Type roomType;

		public int triggerCounter;
	}

	public delegate void BuffAction(Buff parent, GameUnit me, GameUnit targetUnit, ref DamageInfo damageInfo, List<GameUnit> defaultTargets);

	public static int UniqueIdCounter;

	private int _id;

	private List<(ResourceSkill.TargetType tag, Dictionary<string, string> param)> _targets;

	private RangeInfo _rangeInfo;

	private Dictionary<ValueParams, (float value, Dictionary<string, string> param)> _valueParams;

	private ResourceSkill.Effect _effect;

	private Dictionary<string, (float value, Dictionary<string, string> param)> _customStackParams;

	private float _coolTime;

	private float _targetCoolTime;

	private string _valueMultipleIfHasStack;

	private int _triggerCount;

	private float _coolTimeCounter;

	private float _targetCoolTimeCounter;

	private bool _resetCounters;

	private bool _doNextFrame;

	private bool _valueMultiplied;

	private bool _isDefDenConditioned;

	private (float baseValue, float apply) _probabilityByTreasureLevel;

	private BuffAction _buffActions;

	public BuffOption()
	{
	}

	public BuffOption(XmlNode n, XmlNode inherit)
	{
	}

	public BuffOption(BuffOption buffOption)
	{
	}

	public bool CheckConditions(BuffOptionConditionParams param)
	{
		return false;
	}

	protected override bool IsSameCondition(Conditions a, Conditions b)
	{
		return false;
	}

	protected override bool CheckConditionsImpl(BuffOptionConditionParams @params)
	{
		return false;
	}

	protected override BoolOperator GetOperator(Conditions inputKey)
	{
		return default(BoolOperator);
	}

	protected override int? GetSeed(BuffOptionConditionParams @params)
	{
		return null;
	}

	[UsedImplicitly]
	private void AddCheckConditionNoSameRunes(Dictionary<string, string> param)
	{
	}

	private bool NoSameRunes(BuffOptionConditionParams @params)
	{
		return false;
	}

	[UsedImplicitly]
	private void AddCheckConditionOverHpPer(Dictionary<string, string> param)
	{
	}

	private bool OverHpPer(BuffOptionConditionParams @params, float overValuePer, int overTriggerCount, bool target, bool applyDamage)
	{
		return false;
	}

	[UsedImplicitly]
	private void AddCheckConditionOnHpTrigger(Dictionary<string, string> param)
	{
	}

	private bool OnHpTrigger(BuffOptionConditionParams @params, float value, int count)
	{
		return false;
	}

	[UsedImplicitly]
	private void AddCheckConditionUnderHpPer(Dictionary<string, string> param)
	{
	}

	private bool UnderHpPer(BuffOptionConditionParams @params, float underValuePer, int underTriggerCount, bool target, bool applyDamage)
	{
		return false;
	}

	[UsedImplicitly]
	private void AddCheckConditionEquippedItem(Dictionary<string, string> param)
	{
	}

	private bool EquippedItem(BuffOptionConditionParams @params, ResourceItem.EquipType equipType)
	{
		return false;
	}

	[UsedImplicitly]
	private void AddCheckConditionBattleEnd(Dictionary<string, string> param)
	{
	}

	private bool BattleEnd(BuffOptionConditionParams @params, string survived)
	{
		return false;
	}

	[UsedImplicitly]
	private void AddCheckConditionEnterRoom(Dictionary<string, string> param)
	{
	}

	private bool EnterRoom(BuffOptionConditionParams @params, string type)
	{
		return false;
	}

	[UsedImplicitly]
	private void AddCheckConditionBeforeTakeDamage(Dictionary<string, string> param)
	{
	}

	[UsedImplicitly]
	private void AddCheckConditionTakeDamage(Dictionary<string, string> param)
	{
	}

	[UsedImplicitly]
	private void AddCheckConditionBeforeDealDamage(Dictionary<string, string> param)
	{
	}

	[UsedImplicitly]
	private void AddCheckConditionDealDamage(Dictionary<string, string> param)
	{
	}

	private bool TakeOrDealDamage(BuffOptionConditionParams @params, ResourceSkill.TargetType by, List<DamageInfo.Type> with, float hpPer, bool containsReflected, bool allowBlocked)
	{
		return false;
	}

	[UsedImplicitly]
	private void AddCheckConditionAttack(Dictionary<string, string> param)
	{
	}

	private bool Attack(BuffOptionConditionParams @params, int atkCount, bool first)
	{
		return false;
	}

	[UsedImplicitly]
	private void AddCheckConditionAfterAttackMotion(Dictionary<string, string> param)
	{
	}

	private bool AfterAttackMotion(BuffOptionConditionParams @params, int atkCount, bool first)
	{
		return false;
	}

	[UsedImplicitly]
	private void AddCheckConditionAdjustNormalDamage(Dictionary<string, string> param)
	{
	}

	private bool AdjustNormalDamage(BuffOptionConditionParams @params, int atkCount, bool first)
	{
		return false;
	}

	[UsedImplicitly]
	private void AddCheckConditionAfterAttack(Dictionary<string, string> param)
	{
	}

	private bool AfterAttack(BuffOptionConditionParams @params, int atkCount, bool first)
	{
		return false;
	}

	[UsedImplicitly]
	private void AddCheckConditionAfterCastSkill(Dictionary<string, string> param)
	{
	}

	private bool AfterCastSkill(BuffOptionConditionParams @params, int skillCount)
	{
		return false;
	}

	[UsedImplicitly]
	private void AddCheckConditionTeamDead(Dictionary<string, string> param)
	{
	}

	private bool TeamDead(BuffOptionConditionParams @params, bool checkEnemy)
	{
		return false;
	}

	[UsedImplicitly]
	private void AddCheckConditionEquipItem(Dictionary<string, string> param)
	{
	}

	private bool EquipItem(BuffOptionConditionParams @params, ResourceItem.EquipType equipType)
	{
		return false;
	}

	[UsedImplicitly]
	private void AddCheckConditionHasUnit(Dictionary<string, string> param)
	{
	}

	private bool HasUnit(BuffOptionConditionParams @params, int id, bool fromInvade)
	{
		return false;
	}

	[UsedImplicitly]
	private void AddCheckConditionUnderStack(Dictionary<string, string> param)
	{
	}

	private bool UnderStack(BuffOptionConditionParams @params, string stackName, int value, bool world)
	{
		return false;
	}

	[UsedImplicitly]
	private void AddCheckConditionOverStack(Dictionary<string, string> param)
	{
	}

	private bool OverStack(BuffOptionConditionParams @params, string stackName, int value, bool world, bool useDefaultTarget)
	{
		return false;
	}

	[UsedImplicitly]
	private void AddCheckConditionDefDenListIsNotEmpty(Dictionary<string, string> param)
	{
	}

	private bool DefDenListIsNotEmpty(BuffOptionConditionParams @params)
	{
		return false;
	}

	[UsedImplicitly]
	private void AddCheckConditionHandleDefDen(Dictionary<string, string> param)
	{
	}

	[UsedImplicitly]
	private void AddCheckConditionHandleGiveHardCC(Dictionary<string, string> param)
	{
	}

	[UsedImplicitly]
	private void AddCheckConditionMeIsBestTierUnit(Dictionary<string, string> param)
	{
	}

	private bool MeIsBestTierUnit(BuffOptionConditionParams @params)
	{
		return false;
	}

	[UsedImplicitly]
	private void AddCheckConditionDefaultTargetInRange(Dictionary<string, string> param)
	{
	}

	private bool DefaultTargetInRange(BuffOptionConditionParams @params, RangeInfo rangeInfo)
	{
		return false;
	}

	[UsedImplicitly]
	private void AddCheckConditionThemeUnder(Dictionary<string, string> param)
	{
	}

	private bool ThemeUnder(BuffOptionConditionParams @params, int value)
	{
		return false;
	}

	[UsedImplicitly]
	private void AddCheckConditionInvincible(Dictionary<string, string> param)
	{
	}

	private bool Invincible(BuffOptionConditionParams @params, bool value)
	{
		return false;
	}

	[UsedImplicitly]
	private void AddCheckConditionStatAOverStatB(Dictionary<string, string> param)
	{
	}

	private bool StatAOverStatB(BuffOptionConditionParams @params, BuffManager.StatType statA, BuffManager.StatType statB, bool useTarget, bool value)
	{
		return false;
	}

	[UsedImplicitly]
	private void AddCheckConditionTargetIsFixedTarget(Dictionary<string, string> param)
	{
	}

	private bool TargetIsFixedTarget(BuffOptionConditionParams @params)
	{
		return false;
	}

	[UsedImplicitly]
	private void AddCheckConditionBeforeDead(Dictionary<string, string> param)
	{
	}

	private bool BeforeDead(BuffOptionConditionParams @params, bool ignoreIfCanRevive)
	{
		return false;
	}

	[UsedImplicitly]
	private void AddCheckConditionTilePosY(Dictionary<string, string> param)
	{
	}

	private bool TilePosY(BuffOptionConditionParams @params, string checkType, int value)
	{
		return false;
	}

	public List<GameUnit> GetTarget(GameUnit me, List<GameUnit> defaultTargets)
	{
		return null;
	}

	public void EffectToTarget(Buff parent, GameUnit me, List<GameUnit> targetUnits, ref DamageInfo damageInfo, List<GameUnit> defaultTargets)
	{
	}

	private float GetCalculatedValue(GameUnit me, Buff parent, List<GameUnit> defaultTargets, DamageInfo damageInfo, GameUnit targetUnit, TreasureModel treasure, float defaultAtException, ValueParams param, (float value, Dictionary<string, string> param) valueParam)
	{
		return 0f;
	}

	public float CalculateValue(GameUnit me, Buff parent, List<GameUnit> defaultTargets, DamageInfo damageInfo = default(DamageInfo), GameUnit targetUnit = null, TreasureModel treasure = null, float defaultAtException = 0f)
	{
		return 0f;
	}

	[UsedImplicitly]
	private void AddBuffActionHeal(Dictionary<string, string> param)
	{
	}

	private void Heal(Buff parent, GameUnit me, GameUnit targetUnit, ref DamageInfo damageInfo, float tickTime, int tickCount, List<GameUnit> defaultTargets, bool forceBlockTrigger)
	{
	}

	[UsedImplicitly]
	private void AddBuffActionManaHeal(Dictionary<string, string> param)
	{
	}

	private void ManaHeal(Buff parent, GameUnit me, GameUnit targetUnit, ref DamageInfo damageInfo, float tickTime, int tickCount, List<GameUnit> defaultTargets, bool applyFirstTick)
	{
	}

	[UsedImplicitly]
	private void AddBuffActionRemoveDebuffs(Dictionary<string, string> param)
	{
	}

	private void RemoveDebuffs(Buff parent, GameUnit me, GameUnit targetUnit, ref DamageInfo damageInfo, List<GameUnit> defaultTargets)
	{
	}

	[UsedImplicitly]
	private void AddBuffActionHealMana(Dictionary<string, string> param)
	{
	}

	private void HealMana(Buff parent, GameUnit me, GameUnit targetUnit, ref DamageInfo damageInfo, float tickTime, int tickCount, List<GameUnit> defaultTargets)
	{
	}

	[UsedImplicitly]
	private void AddBuffActionHealManaPer(Dictionary<string, string> param)
	{
	}

	private void HealManaPer(Buff parent, GameUnit me, GameUnit targetUnit, ref DamageInfo damageInfo, float tickTime, int tickCount, List<GameUnit> defaultTargets)
	{
	}

	[UsedImplicitly]
	private void AddBuffActionAddDamagePer(Dictionary<string, string> param)
	{
	}

	private void AddDamagePer(Buff parent, GameUnit me, GameUnit targetUnit, ref DamageInfo damageInfo, List<GameUnit> defaultTargets)
	{
	}

	[UsedImplicitly]
	private void AddBuffActionAddTakeDamagePer(Dictionary<string, string> param)
	{
	}

	private void AddTakeDamagePer(Buff parent, GameUnit me, GameUnit targetUnit, ref DamageInfo damageInfo, List<GameUnit> defaultTargets)
	{
	}

	[UsedImplicitly]
	private void AddBuffActionAddDamageMult(Dictionary<string, string> param)
	{
	}

	private void AddDamageMult(Buff parent, GameUnit me, GameUnit targetUnit, ref DamageInfo damageInfo, List<GameUnit> defaultTargets)
	{
	}

	[UsedImplicitly]
	private void AddBuffActionDefPer(Dictionary<string, string> param)
	{
	}

	private void DefPer(Buff parent, GameUnit me, GameUnit targetUnit, ref DamageInfo damageInfo, List<GameUnit> defaultTargets)
	{
	}

	[UsedImplicitly]
	private void AddBuffActionSetHp(Dictionary<string, string> param)
	{
	}

	private void SetHp(Buff parent, GameUnit me, GameUnit targetUnit, ref DamageInfo damageInfo, List<GameUnit> defaultTargets, bool removeDamage)
	{
	}

	[UsedImplicitly]
	private void AddBuffActionEquipItems(Dictionary<string, string> param)
	{
	}

	private void EquipItems(Buff parent, GameUnit me, GameUnit targetUnit, ref DamageInfo damageInfo, int tier, bool isTemporal, List<GameUnit> defaultTargets)
	{
	}

	[UsedImplicitly]
	private void AddBuffActionIncreaseCustomStack(Dictionary<string, string> param)
	{
	}

	private void IncreaseCustomStack(Buff parent, GameUnit me, GameUnit targetUnit, ref DamageInfo damageInfo, string stackName, int max, StackType type, List<GameUnit> defaultTargets)
	{
	}

	[UsedImplicitly]
	private void AddBuffActionManaflow(Dictionary<string, string> param)
	{
	}

	private void Manaflow(Buff parent, GameUnit me, GameUnit targetUnit, ref DamageInfo damageInfo, List<GameUnit> defaultTargets)
	{
	}

	[UsedImplicitly]
	private void AddBuffActionClearManaflowSet(Dictionary<string, string> param)
	{
	}

	private void ClearManaflowSet(Buff parent, GameUnit me, GameUnit targetUnit, ref DamageInfo damageInfo, List<GameUnit> defaultTargets)
	{
	}

	[UsedImplicitly]
	private void AddBuffActionSetCustomStack(Dictionary<string, string> param)
	{
	}

	private void SetCustomStack(Buff parent, GameUnit me, GameUnit targetUnit, ref DamageInfo damageInfo, string stackName, bool unique, StackType stackType, List<GameUnit> defaultTargets)
	{
	}

	[UsedImplicitly]
	private void AddBuffActionAddStat(Dictionary<string, string> param)
	{
	}

	private void AddStat(Buff parent, GameUnit me, GameUnit targetUnit, ref DamageInfo damageInfo, BuffManager.StatType statType, BuffManager.StatValueType statValueType, float time, bool haveToBind, float max, bool ignoreCCRatio, bool addHpOnAddMaxHp, bool fromTargetToMe, bool releaseBindWhenBattleStart, List<GameUnit> defaultTargets, int maxOverlapCount)
	{
	}

	[UsedImplicitly]
	private void AddBuffActionConsumeHp(Dictionary<string, string> param)
	{
	}

	private void ConsumeHp(Buff parent, GameUnit me, GameUnit targetUnit, ref DamageInfo damageInfo, float tickTime, int tickCount, List<GameUnit> defaultTargets)
	{
	}

	[UsedImplicitly]
	private void AddBuffActionDealDamage(Dictionary<string, string> param)
	{
	}

	private void DealDamage(Buff parent, GameUnit me, GameUnit targetUnit, ref DamageInfo damageInfo, DamageInfo.Type with, float tickTime, int tickCount, List<GameUnit> defaultTargets)
	{
	}

	[UsedImplicitly]
	private void AddBuffActionDealDamagePer(Dictionary<string, string> param)
	{
	}

	private void DealDamagePer(Buff parent, GameUnit me, GameUnit targetUnit, ref DamageInfo damageInfo, DamageInfo.Type with, float tickTime, int tickCount, List<GameUnit> defaultTargets)
	{
	}

	[UsedImplicitly]
	private void AddBuffActionAddShield(Dictionary<string, string> param)
	{
	}

	private void AddShield(Buff parent, GameUnit me, GameUnit targetUnit, ref DamageInfo damageInfo, float tickTime, int tickCount, List<GameUnit> defaultTargets, bool ignoreMasterValueRatio)
	{
	}

	[UsedImplicitly]
	private void AddBuffActionAddShield30018(Dictionary<string, string> param)
	{
	}

	private void AddShield30018(Buff parent, GameUnit me, GameUnit targetUnit, ref DamageInfo damageInfo, List<GameUnit> defaultTargets, float damageConversionRatioLimit)
	{
	}

	private void DealDamage(Buff parent, GameUnit me, GameUnit targetUnit, ref DamageInfo damageInfo, DamageInfo.Type with, float tickTime, int tickCount, int value)
	{
	}

	[UsedImplicitly]
	private void AddBuffActionAddSuperShield(Dictionary<string, string> param)
	{
	}

	private void AddSuperShield(Buff parent, GameUnit me, GameUnit targetUnit, List<GameUnit> defaultTargets, int max)
	{
	}

	[UsedImplicitly]
	private void AddBuffActionUseSkillTo(Dictionary<string, string> param)
	{
	}

	private void UseSkillTo(Buff parent, GameUnit me, GameUnit targetUnit, List<GameUnit> defaultTargets, int id)
	{
	}

	[UsedImplicitly]
	private void AddBuffActionUseSkill(Dictionary<string, string> param)
	{
	}

	private void UseSkill(Buff parent, GameUnit me, GameUnit targetUnit, List<GameUnit> defaultTargets, int id)
	{
	}

	[UsedImplicitly]
	private void AddBuffActionSpawn(Dictionary<string, string> param)
	{
	}

	private void Spawn(Buff parent, GameUnit me, GameUnit targetUnit, int spawnId, float time, bool checkCollision, List<GameUnit> defaultTargets, string effect, int maxSpawnCount, bool selfParent)
	{
	}

	[UsedImplicitly]
	private void AddBuffActionAddRestHealPer(Dictionary<string, string> param)
	{
	}

	private void AddRestHealPer(Buff parent, GameUnit me, List<GameUnit> defaultTargets, GameUnit targetUnit)
	{
	}

	[UsedImplicitly]
	private void AddBuffActionBolt(Dictionary<string, string> param)
	{
	}

	private void Bolt(Buff parent, GameUnit me, GameUnit targetUnit, ref DamageInfo damageInfo, List<GameUnit> defaultTargets)
	{
	}

	[UsedImplicitly]
	private void AddBuffActionFire(Dictionary<string, string> param)
	{
	}

	private void Fire(Buff parent, GameUnit me, GameUnit targetUnit, ref DamageInfo damageInfo, List<GameUnit> defaultTargets)
	{
	}

	[UsedImplicitly]
	private void AddBuffActionShadowAttack(Dictionary<string, string> param)
	{
	}

	private void ShadowAttack(Buff parent, GameUnit me, GameUnit targetUnit, ref DamageInfo damageInfo, int targetCount, List<GameUnit> defaultTargets)
	{
	}

	[UsedImplicitly]
	private void AddBuffActionPhysicalArrow(Dictionary<string, string> param)
	{
	}

	private void PhysicalArrow(Buff parent, GameUnit me, GameUnit targetUnit, ref DamageInfo damageInfo, float atkPer, float treasureLevelPer, List<GameUnit> defaultTargets, float delay, float speed, string prefab, string hitEffect, string sound, int targetEffectUnit)
	{
	}

	[UsedImplicitly]
	private void AddBuffActionMagicArrow(Dictionary<string, string> param)
	{
	}

	private void MagicArrow(Buff parent, GameUnit me, GameUnit targetUnit, ref DamageInfo damageInfo, float damageValue, List<GameUnit> defaultTargets, float delay)
	{
	}

	[UsedImplicitly]
	private void AddBuffActionThrow(Dictionary<string, string> param)
	{
	}

	private void Throw(Buff parent, GameUnit me, GameUnit targetUnit, ref DamageInfo damageInfo, List<GameUnit> defaultTargets)
	{
	}

	[UsedImplicitly]
	private void AddBuffActionEnableWhiteDamageDrain(Dictionary<string, string> param)
	{
	}

	private void EnableWhiteDamageDrain(Buff parent, GameUnit me, GameUnit targetUnit, ref DamageInfo damageInfo, List<GameUnit> defaultTargets)
	{
	}

	[UsedImplicitly]
	private void AddBuffActionStaffTickDamage(Dictionary<string, string> param)
	{
	}

	private void StaffTickDamage(Buff parent, GameUnit me, GameUnit targetUnit, ref DamageInfo damageInfo, List<GameUnit> defaultTargets)
	{
	}

	[UsedImplicitly]
	private void AddBuffActionMimicSelf(Dictionary<string, string> param)
	{
	}

	private void MimicSelf(Buff parent, GameUnit me, GameUnit targetUnit, ref DamageInfo damageInfo, List<GameUnit> defaultTargets)
	{
	}

	[UsedImplicitly]
	private void AddBuffActionEatItem(Dictionary<string, string> param)
	{
	}

	private void EatItem(Buff parent, GameUnit me, GameUnit targetUnit, ref DamageInfo damageInfo, List<GameUnit> defaultTargets)
	{
	}

	[UsedImplicitly]
	private void AddBuffActionCloaking(Dictionary<string, string> param)
	{
	}

	private void Cloaking(Buff parent, GameUnit me, GameUnit targetUnit, ref DamageInfo damageInfo, List<GameUnit> defaultTargets)
	{
	}

	private void AddStackStarfish(ResourceItem targetItem, Dictionary<string, int> customStacks, Rune parent, int random = 0)
	{
	}

	[UsedImplicitly]
	private void AddBuffActionShowEffect(Dictionary<string, string> param)
	{
	}

	private void ShowEffect(Buff parent, GameUnit me, GameUnit targetUnit, ref DamageInfo damageInfo, List<GameUnit> defaultTargets, string valueType, float max, bool damaged, float time)
	{
	}

	[UsedImplicitly]
	private void AddBuffActionRemoveEffect(Dictionary<string, string> param)
	{
	}

	private void RemoveEffect(Buff parent, GameUnit me, GameUnit targetUnit, ref DamageInfo damageInfo, List<GameUnit> defaultTargets, string prefab, string customStackName)
	{
	}

	[UsedImplicitly]
	private void AddBuffActionShowTileEffect(Dictionary<string, string> param)
	{
	}

	private void ShowTileEffect(Buff parent, GameUnit me, GameUnit targetUnit, ref DamageInfo damageInfo, List<GameUnit> defaultTargets, string prefab, bool animator, bool checkValid)
	{
	}

	[UsedImplicitly]
	private void AddBuffActionRemoveTileEffect(Dictionary<string, string> param)
	{
	}

	private void RemoveTileEffect(Buff parent, GameUnit me, GameUnit targetUnit, ref DamageInfo damageInfo, List<GameUnit> defaultTargets, string prefab, bool animator, bool allTiles)
	{
	}

	[UsedImplicitly]
	private void AddBuffActionPlaySound(Dictionary<string, string> param)
	{
	}

	private void PlaySound(Buff parent, GameUnit me, GameUnit targetUnit, ref DamageInfo damageInfo, List<GameUnit> defaultTargets, string name)
	{
	}

	[UsedImplicitly]
	private void AddBuffActionInstantKill(Dictionary<string, string> param)
	{
	}

	private void InstantKill(Buff parent, GameUnit me, GameUnit targetUnit, ref DamageInfo damageInfo, List<GameUnit> defaultTargets, bool fromSelf)
	{
	}

	[UsedImplicitly]
	private void AddBuffActionDispose(Dictionary<string, string> param)
	{
	}

	private void Dispose(Buff parent, GameUnit me, GameUnit targetUnit, ref DamageInfo damageInfo, List<GameUnit> defaultTargets, float addTime)
	{
	}

	[UsedImplicitly]
	private void AddBuffActionAddMoveStopTime(Dictionary<string, string> param)
	{
	}

	private void AddMoveStopTime(Buff parent, GameUnit me, GameUnit targetUnit, ref DamageInfo damageInfo, List<GameUnit> defaultTargets)
	{
	}

	[UsedImplicitly]
	private void AddBuffActionSetInvincible(Dictionary<string, string> param)
	{
	}

	private void SetInvincible(Buff parent, GameUnit me, GameUnit targetUnit, ref DamageInfo damageInfo, List<GameUnit> defaultTargets, bool removeHeal)
	{
	}

	[UsedImplicitly]
	private void AddBuffActionAddReviveCount(Dictionary<string, string> param)
	{
	}

	private void AddReviveCount(Buff parent, GameUnit me, ref DamageInfo damageInfo, GameUnit targetUnit, List<GameUnit> defaultTargets, float maxHpPer, float maxManaPer, int reviveCount, bool setFlag, GameUnit.ReviveCategory category)
	{
	}

	[UsedImplicitly]
	private void AddBuffActionAddCustomBuff(Dictionary<string, string> param)
	{
	}

	private void AddCustomBuff(Buff parent, GameUnit me, GameUnit targetUnit, ref DamageInfo damageInfo, List<GameUnit> defaultTargets, string key, float time, int overlapCount, bool applyTargetToSource, bool applyCCRatio)
	{
	}

	[UsedImplicitly]
	private void AddBuffActionAddCustomBuffCalcTime(Dictionary<string, string> param)
	{
	}

	private void AddCustomBuffCalcTime(Buff parent, GameUnit me, GameUnit targetUnit, ref DamageInfo damageInfo, List<GameUnit> defaultTargets, string key, float value, int overlapCount)
	{
	}

	[UsedImplicitly]
	private void AddBuffActionAddConditionalCustomBuff(Dictionary<string, string> param)
	{
	}

	private void AddConditionalCustomBuff(Buff parent, GameUnit me, GameUnit targetUnit, ref DamageInfo damageInfo, List<GameUnit> defaultTargets, string key1, string key2, BuffManager.StatType stat1, BuffManager.StatType stat2, float time, int overlapCount)
	{
	}

	[UsedImplicitly]
	private void AddBuffActionAddCustomBuffFromSkill(Dictionary<string, string> param)
	{
	}

	private void AddCustomBuffFromSkill(Buff parent, GameUnit me, GameUnit targetUnit, ref DamageInfo damageInfo, List<GameUnit> defaultTargets, int skillID)
	{
	}

	[UsedImplicitly]
	private void AddBuffActionForceSilence(Dictionary<string, string> param)
	{
	}

	private void ForceSilence(Buff parent, GameUnit me, GameUnit targetUnit, ref DamageInfo damageInfo, List<GameUnit> defaultTargets, string silenceEffect)
	{
	}

	[UsedImplicitly]
	private void AddBuffActionFixAttackSpeed(Dictionary<string, string> param)
	{
	}

	private void FixAttackSpeed(Buff parent, GameUnit me, GameUnit targetUnit, ref DamageInfo damageInfo, List<GameUnit> defaultTargets, float time)
	{
	}

	[UsedImplicitly]
	private void AddBuffActionAddPriorityShield(Dictionary<string, string> param)
	{
	}

	private void AddPriorityShield(Buff parent, GameUnit me, GameUnit targetUnit, ref DamageInfo damageInfo, List<GameUnit> defaultTargets, float time)
	{
	}

	[UsedImplicitly]
	private void AddBuffActionGiveGuard(Dictionary<string, string> param)
	{
	}

	private void GiveGuard(Buff parent, GameUnit me, GameUnit targetUnit, ref DamageInfo damageInfo, List<GameUnit> defaultTargets)
	{
	}

	private ResourceSkill.TargetType GetTargetType(GameUnit me, GameUnit target)
	{
		return default(ResourceSkill.TargetType);
	}

	public void Update()
	{
	}

	public void ResetCounters()
	{
	}

	protected override bool Parse(ref XmlNode n, XmlNode inherit)
	{
		return false;
	}

	public override bool Parse<T>(IRecursiveInheritable<T> n, int index)
	{
		return false;
	}
}
