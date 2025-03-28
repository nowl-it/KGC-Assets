using System.Collections.Generic;

public class DwarfAI : MoveAttackAI
{
	private ResourceSkill _dwarfSkill;

	private IReadOnlyList<ResourceSkill.Effect> _splashEffects;

	private IReadOnlyList<ResourceSkill.Effect> _targetEffects;

	private float _damageDelay;

	private string _damageDelayType;

	private RangeInfo _range;

	private float _mAtkPer;

	private float _healPerEachTarget;

	private float _tick;

	private float _tickCounter;

	public DwarfAI(GameUnit me)
		: base(null)
	{
	}

	public void HandleLevelChanged()
	{
	}

	private void Init()
	{
	}

	public override void Update(float dt)
	{
	}

	public override void Clear()
	{
	}
}
