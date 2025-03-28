using System.Collections.Generic;

public class ShadowBossAI : MoveAttackAI
{
	private int _skillTriggerHpRatio;

	private int _nextSkillTriggerHpRatio;

	private bool _appearCalled;

	private ResourceSkill _changeSkillWhenUnderHpHalf;

	private List<GameUnit> _summonedUnits;

	private List<GameUnit> summonedUnits => null;

	public ShadowBossAI(GameUnit me)
		: base(null)
	{
	}

	public override void Update(float dt)
	{
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
}
