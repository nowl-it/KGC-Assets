using System.Collections.Generic;

public class Unit42000AI : MoveAttackAI
{
	private int _summonCount;

	private int _summonUnitID;

	private ulong? _summonTimer;

	private ulong? _timer;

	public Unit42000AI(GameUnit me)
		: base(null)
	{
	}

	public override void HandleAdjustBeforeDamaged(ref DamageInfo damageInfo, GameUnit from)
	{
	}

	public override void HandleShootSkill(ResourceSkill resSkill, List<GameUnit> targets)
	{
	}

	private void SkillImpl()
	{
	}

	public override void HandleEndBattle()
	{
	}

	public override void Update(float dt)
	{
	}
}
