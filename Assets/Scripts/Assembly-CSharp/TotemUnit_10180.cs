using System.Collections.Generic;

public class TotemUnit_10180 : TotemUnit
{
	private ResourceSkill _resSkill;

	private int _curDamageCount;

	private int _maxDamageCount;

	private bool _targetDied;

	public override void Init(GameUnit parent, List<GameUnit> targets, ResourceSkill resSkill, float damageRatio)
	{
	}

	protected override void AfterDamaged()
	{
	}

	protected override bool CheckBoomCondition()
	{
		return false;
	}

	protected override DamageInfo GetTotemDamageInfo(int originalDamage)
	{
		return default(DamageInfo);
	}

	public override void Clear(GameUnit target)
	{
	}
}
