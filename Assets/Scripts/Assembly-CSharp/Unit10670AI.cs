using System.Collections.Generic;

public class Unit10670AI : MoveAttackAI
{
	private RangeInfo _searchRange;

	private bool _skillAttackStarted;

	private HashSet<GameUnit> _targetExcepts;

	public Unit10670AI(GameUnit me)
		: base(null)
	{
	}

	protected override void OnAction(AIAction action)
	{
	}

	public override void HandleEvent(string eventName)
	{
	}
}
