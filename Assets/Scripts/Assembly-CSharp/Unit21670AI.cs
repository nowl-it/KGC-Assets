using System.Collections.Generic;

public class Unit21670AI : GroggyStateAI
{
	private Unit21671AI _core;

	private static readonly int _skill;

	private static readonly int _cancel;

	private static readonly int _revive;

	private ResourceSkill.Effect _customChannelingEffect;

	private readonly string _groggySound;

	public Unit21670AI(GameUnit me)
		: base(null)
	{
	}

	public override void HandleStartChanneling()
	{
	}

	public override void HandleStartBattle()
	{
	}

	private void HandleBeforeChannelingEnd()
	{
	}

	protected override void StartGroggy()
	{
	}

	public override void HandleEndChanneling()
	{
	}

	public override void HandleShootSkill(ResourceSkill resSkill, List<GameUnit> targets)
	{
	}

	public override void HandleDie()
	{
	}

	public override void HandleApplyDamage(GameUnit from, ref DamageInfo damageInfo)
	{
	}

	public override void AddGroggyDealMeter(float damage)
	{
	}

	private void ShowVerticalTileEffect()
	{
	}
}
