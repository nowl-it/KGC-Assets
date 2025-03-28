using System;
using System.Collections.Generic;

public class Unit10640AI : MoveAttackAI
{
	private IReadOnlyList<ResourceSkill.Effect> _teamKillEffects;

	private IDisposable _disposable;

	private bool _bestTierUnit;

	public Unit10640AI(GameUnit me)
		: base(null)
	{
	}

	public override void HandleStartBattle()
	{
	}

	public override void HandleShootSkill(ResourceSkill resSkill, List<GameUnit> targets)
	{
	}

	public void AfterStartBattle()
	{
	}

	public override void Clear()
	{
	}
}
