using UnityEngine;

public class Unit10680AI : MoveAttackAI, IMimicBehaviourOverridable
{
	private bool _removeCCOnMaxTechnique;

	private bool _removeDebuffFlag;

	private int _friendUnitId;

	private int _friendUnitBuff;

	public Unit10680AI(GameUnit me)
		: base(null)
	{
	}

	public override void HandleStartBattle()
	{
	}

	private void CheckFriendBuff()
	{
	}

	protected override void OnAction(AIAction action)
	{
	}

	protected override void UseSkillProcess(bool selfTarget, GameUnit target, RangeInfo range)
	{
	}

	public Vector2Int MoveBeforeUseSkill()
	{
		return default(Vector2Int);
	}

	private Vector2Int GetPreferDir()
	{
		return default(Vector2Int);
	}

	public void MimicUseSkill()
	{
	}
}
