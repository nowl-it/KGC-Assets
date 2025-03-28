using System.Collections.Generic;
using UnityEngine;

public class TwinBoss_MeleeAI : MoveAttackAI
{
	private float _minAttackDist;

	private float _minDist;

	public TwinBoss_MeleeAI(GameUnit me)
		: base(null)
	{
	}

	public override void HandleDie()
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

	public override bool UseCustomSplashRangeFromFunc(ResourceSkill resSkill)
	{
		return false;
	}

	public override Vector2Int CustomSplashRangeFrom(ResourceSkill resourceSkill, Vector2Int targetPos)
	{
		return default(Vector2Int);
	}

	protected override void InitCustomFindTargetImplVariables()
	{
	}

	protected override bool CustomFindTargetImpl(bool checkCanAttack, float dist, float attackDist, GameUnit target)
	{
		return false;
	}
}
