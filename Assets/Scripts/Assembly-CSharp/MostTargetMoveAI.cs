using System.Collections.Generic;
using UnityEngine;

public class MostTargetMoveAI : MoveAttackAI
{
	protected HighestValuePosHelper highestValuePosHelper;

	private Vector2Int _moveToPos;

	public MostTargetMoveAI(GameUnit me)
		: base(null)
	{
	}

	public override void HandleStartBattle()
	{
	}

	protected override void UseSkillProcess(bool selfTarget, GameUnit target, RangeInfo range)
	{
	}

	public override void HandleShootSkill(ResourceSkill resSkill, List<GameUnit> targets)
	{
	}

	protected virtual void ShowTileEffect()
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

	public override Vector2Int CustomMoveToPosition()
	{
		return default(Vector2Int);
	}
}
