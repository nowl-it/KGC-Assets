using System.Collections.Generic;

public class Unit42200AI : ClanRaidBossPowerAI
{
	private readonly float _clanRaidBossPowerAmountWhenSkill;

	private readonly float _totalDamageToHealFromUnit;

	private readonly float _totalDamageToHealFromUnitTime;

	private GameUnit _childUnit;

	private float _bossPowerOverTime;

	private readonly BuffManager.StatInfo _totalDamagePerStatInfo;

	public Unit42200AI(GameUnit me)
		: base(null)
	{
	}

	public override void Update(float dt)
	{
	}

	protected override void HandleBossPowerChanged(float bossPower)
	{
	}

	public override void HandleShootSkill(ResourceSkill resSkill, List<GameUnit> targets)
	{
	}

	public override void HandleDamaged(GameUnit from, DamageInfo damageInfo)
	{
	}

	public void HandleSummonedUnitHealed(int value, GameUnit fromUnit)
	{
	}

	public float GetHealAdaptability()
	{
		return 0f;
	}
}
