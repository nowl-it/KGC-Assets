using System.Collections.Generic;
using UnityEngine;

public class BerserkerBossAI : MoveAttackAI
{
	private int _skillTriggerHpRatio;

	private int _nextSkillTriggerHpRatio;

	private GameObject auraObject;

	public BerserkerBossAI(GameUnit me)
		: base(null)
	{
	}

	public override void Update(float dt)
	{
	}

	public override void ShowCustomSelfEffects(IReadOnlyList<ResourceSkill.Effect> selfEffects)
	{
	}

	public override bool UseCustomSelfEffect()
	{
		return false;
	}

	public override void HandleStartBattle()
	{
	}

	public override void HandleShootSkill(ResourceSkill resSkill, List<GameUnit> targets)
	{
	}

	public override void HandleHpRatioChanged(float beforeRatio, float afterRatio)
	{
	}

	public override int GetBonusAttackCount(bool isSkill)
	{
		return 0;
	}
}
