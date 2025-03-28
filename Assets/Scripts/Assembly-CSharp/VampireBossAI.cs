using System.Collections.Generic;

public class VampireBossAI : MoveAttackAI
{
	private int _phase;

	private RangeInfo _range;

	private float _tick;

	private float _atkPer;

	private float _passiveHpPer;

	private float _drainPer;

	private int _tickMana;

	private List<ResourceSkill.Effect> _effects;

	private float _tickCounter;

	private AudioObject _skillSound;

	public VampireBossAI(GameUnit me)
		: base(null)
	{
	}

	public override void Update(float dt)
	{
	}

	private void Drain()
	{
	}

	public override void HandleEvent(string eventName)
	{
	}

	public override void Clear()
	{
	}
}
