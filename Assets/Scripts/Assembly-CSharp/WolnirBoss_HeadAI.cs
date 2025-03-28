using System.Collections.Generic;

public class WolnirBoss_HeadAI : GroggyStateAILegacy
{
	private new int phase;

	private List<GameUnit> _arms;

	private Gauge _manaBar => null;

	private Gauge _channelingBar => null;

	private Gauge _groggyBar => null;

	public WolnirBoss_HeadAI(GameUnit me)
		: base(null)
	{
	}

	public override void HandleStartBattle()
	{
	}

	public override void Update(float dt)
	{
	}

	public override void HandleShootSkill(ResourceSkill resSkill, List<GameUnit> targets)
	{
	}

	protected override void OnAction(AIAction action)
	{
	}

	public override void HandleDie()
	{
	}

	public override void HandleDamaged(GameUnit from, DamageInfo damageInfo)
	{
	}

	public override void HandleEndChanneling()
	{
	}

	public void HandleArmAttack()
	{
	}

	public override void StartGroggy()
	{
	}

	public override bool IsChanneling()
	{
		return false;
	}
}
