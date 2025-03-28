using System.Collections.Generic;

public class TeamBoss_MagicianAI : MoveAttackAI
{
	private int buffToTeamBossesWhenDead;

	private bool[] hpRatioTriggered;

	private int _tauntEffectSkill;

	private HashSet<GameUnit> _excepts;

	private List<GameUnit> teamBosses => null;

	public TeamBoss_MagicianAI(GameUnit unit)
		: base(null)
	{
	}

	public override void Update(float dt)
	{
	}

	protected override void OnAction(AIAction action)
	{
	}

	private void ChangeTarget(RangeInfo range)
	{
	}

	public override void HandleEvent(string eventName)
	{
	}

	public override void HandleStartBattle()
	{
	}

	private void UnitTauntToAllBosses()
	{
	}

	public override void HandleDamaged(GameUnit from, DamageInfo damageInfo)
	{
	}

	public override void HandleDie()
	{
	}
}
