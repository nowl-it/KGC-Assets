using System.Collections.Generic;

public class ShieldBossAI : MoveAttackAI, IHpBarCustomizable
{
	private int _shieldBossDefPer;

	private float _shieldTime;

	private int _shieldCCDurability;

	private float _shieldTimer;

	private int _remainCCDurability;

	private float _shieldMatkPer;

	private List<ResourceSkill.Effect> _shieldAttackTargetEffects;

	private Dictionary<GameUnit, bool> _ccDict;

	private ResourceSkill _onCCHitDebuffSkill;

	private static readonly int _bye;

	private float _tick;

	private float _tickCounter;

	private float _addDefPer;

	public ShieldBossAI(GameUnit me)
		: base(null)
	{
	}

	public override void Update(float dt)
	{
	}

	public override void HandleEvent(string eventName)
	{
	}

	public override void HandleStun(GameUnit from)
	{
	}

	private void ShieldAttack()
	{
	}

	private void UseShieldSkill()
	{
	}

	private void EndShieldSkill()
	{
	}

	private void ResetShieldParam()
	{
	}

	public override void Clear()
	{
	}

	public void UpdateHpBar(bool reloadMax = false)
	{
	}

	private void DeactivateHpBarStackIndicator()
	{
	}

	public bool SetHpBar()
	{
		return false;
	}

	public override void HandleEndBattle()
	{
	}
}
