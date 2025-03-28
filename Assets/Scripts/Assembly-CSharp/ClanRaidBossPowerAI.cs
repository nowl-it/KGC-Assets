using UnityEngine.UI;

public abstract class ClanRaidBossPowerAI : MoveAttackAI
{
	public readonly float baseBossPower;

	public readonly bool bossPowerActive;

	protected Slider powerGauge;

	public float bossPower;

	public float displayedBossPower;

	public int bossDifficulty => 0;

	protected float bossPowerMax => 0f;

	public ClanRaidBossPowerAI(GameUnit me)
		: base(null)
	{
	}

	public override void HandleStartBattle()
	{
	}

	private void SubscribeAdjustDamageCallback()
	{
	}

	protected virtual DamageInfo ClanRaidBossAdjustDamageCallback(DamageInfo damageInfo)
	{
		return default(DamageInfo);
	}

	protected virtual void AssignClanRaidBossPowerBuff(BuffManager.StatInfo statInfo, float value)
	{
	}

	protected virtual void SetBossPower(float bossPower)
	{
	}

	protected abstract void HandleBossPowerChanged(float bossPower);

	public override void Update(float dt)
	{
	}

	public override void HandleDie()
	{
	}
}
