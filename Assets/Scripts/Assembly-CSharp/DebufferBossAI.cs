using System.Collections.Generic;

public class DebufferBossAI : PhaseBossAI
{
	public DebufferBossAI(GameUnit me)
		: base(null)
	{
	}

	protected override void OnAction(AIAction action)
	{
	}

	public override bool UseCustomFindSkillTargetFunc(ResourceSkill resSkill)
	{
		return false;
	}

	public override List<GameUnit> CustomFindSkillTargets(ResourceSkill resourceSkill)
	{
		return null;
	}

	private bool IsBaseAttackTarget(GameUnit unit)
	{
		return false;
	}

	private bool CanUseSkill()
	{
		return false;
	}
}
