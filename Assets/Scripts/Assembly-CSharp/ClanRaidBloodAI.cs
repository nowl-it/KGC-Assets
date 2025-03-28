using System.Collections.Generic;

public class ClanRaidBloodAI : MoveAttackAI, IHpBarCustomizable
{
	private ResourceSkill _onDamagedDebuffSkill;

	private float _addTakeDamagePerOnDamaged;

	private float _addTakeDamagePerCounterDecAfterSec;

	private float _addTakeDamagePerCounter;

	private List<float> _addTakeDamagePerCounterDecTimers;

	public ClanRaidBloodAI(GameUnit me)
		: base(null)
	{
	}

	public override void Clear()
	{
	}

	public override void Update(float dt)
	{
	}

	public override void HandleDamaged(GameUnit from, DamageInfo damageInfo)
	{
	}

	public void UpdateHpBar(bool reloadMax)
	{
	}

	public bool SetHpBar()
	{
		return false;
	}
}
