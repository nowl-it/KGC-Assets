using System.Collections.Generic;

public class MultiHitSubBossAI : BaseAI
{
	public const int SkillIntWhenAttack = 0;

	public const int SkillIntWhenSkill = 1;

	public const int SkillIntWhenEventSkill = 2;

	private MultiHitBossAI _parent;

	public GameUnit currentTarget { get; private set; }

	public MultiHitSubBossAI(GameUnit me)
		: base(null)
	{
	}

	public void SubAttack()
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

	public override void HandleEvent(string eventName)
	{
	}

	public void SetParent(MultiHitBossAI parent)
	{
	}

	public void SetAttackAnimation()
	{
	}

	public void SetSkillAnimation()
	{
	}

	public void SetPhaseEventAnimation()
	{
	}
}
