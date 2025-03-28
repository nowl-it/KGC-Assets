using System.Collections.Generic;

public class Unit21610AI : MoveAttackAI
{
	private int _summonUnitId;

	public Unit21610AI(GameUnit me)
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
