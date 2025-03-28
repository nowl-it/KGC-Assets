using System.Collections.Generic;

public class Unit21630AI : MoveAttackAI
{
	public Unit21630AI(GameUnit me)
		: base(null)
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
}
