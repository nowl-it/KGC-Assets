using System.Collections.Generic;

public class SingleCounterBossAI : PhaseBossAI
{
	private float _grabTimer;

	private float _attackTimer;

	private RangeInfo _range;

	private int _tickAtkCount;

	private float _grabTime;

	private int _attackInt;

	private string _atkEffect;

	private string _waveEffect;

	private ResourceSkill _debuffSkill;

	public SingleCounterBossAI(GameUnit me)
		: base(null)
	{
	}

	public override void Update(float dt)
	{
	}

	private void TickDamage(int line = -1)
	{
	}

	private void Grab()
	{
	}

	public override void HandleShootSkill(ResourceSkill resSkill, List<GameUnit> targets)
	{
	}

	public override void HandleKillUnit(GameUnit target, DamageInfo damageInfo)
	{
	}
}
