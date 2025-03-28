using System.Collections.Generic;

public class Unit10710AI : MoveAttackAI
{
	private bool _bestTierUnit;

	private HashSet<GameUnit> _excepts;

	private bool _prevCanTarget;

	private float _minAttackDist;

	private float _minDist;

	private float _minHpPer;

	public Unit10710AI(GameUnit me)
		: base(null)
	{
	}

	public override void HandleStartBattle()
	{
	}

	protected override void OnAction(AIAction action)
	{
	}

	public override void HandleShootSkill(ResourceSkill resSkill, List<GameUnit> targets)
	{
	}

	public override void FindTarget(RangeInfo range, bool usingPathDist = false, HashSet<GameUnit> except = null, bool targetEnemy = true, bool excludeMe = true, bool setFixedTarget = false, bool usePathCheck = false, bool excludeSame = false, bool forceIgnoreTaunt = false)
	{
	}

	protected override bool CustomFindTargetImpl(bool checkCanAttack, float dist, float attackDist, GameUnit target)
	{
		return false;
	}

	public override void HandleEvent(string eventName)
	{
	}

	private bool SummonerFilter(GameUnit unit)
	{
		return false;
	}
}
