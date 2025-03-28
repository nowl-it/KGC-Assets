using System.Collections.Generic;

public class MultiHitBossAI : PhaseBossAI
{
	private List<MultiHitSubBossAI> _subBosses;

	private List<ResourceSkill> _eventBuffs;

	private bool _eventSkillStarted;

	private ResourceSkill _currentEventSkill;

	private float _timer;

	private float _interval;

	public MultiHitBossAI(GameUnit me)
		: base(null)
	{
	}

	public override void HandleStartBattle()
	{
	}

	public override void HandleDie()
	{
	}

	public override void Update(float dt)
	{
	}

	public bool IsTargetingBySubBosses(GameUnit gameUnit)
	{
		return false;
	}

	protected override void EnterPhase(int newPhase)
	{
	}

	private void RequestSubAttack()
	{
	}

	public override void HandleShootSkill(ResourceSkill resSkill, List<GameUnit> targets)
	{
	}
}
