using System.Collections.Generic;
using UnityEngine;

public class MoveAttackAI : BaseAI
{
	private Vector3 _moveDirection;

	private Vector2 _originPos;

	protected float attackActionCooltime;

	private bool _isLastRangeStrategyRandom;

	private HashSet<GameUnit> _targetExcepts;

	private bool prevActionIsSkill;

	public MoveAttackAI(GameUnit me)
		: base(null)
	{
	}

	private void Init()
	{
	}

	public void SetOriginPos(Vector2 pos)
	{
	}

	public override void SetEnabled(bool v, int afterFrame = 0)
	{
	}

	protected override void HandleTargetSelected()
	{
	}

	protected override void OnActionStart(AIAction action)
	{
	}

	protected override void OnAction(AIAction action)
	{
	}

	protected virtual (bool, GameUnit) GetSkillTarget(RangeInfo range)
	{
		return default((bool, GameUnit));
	}

	protected virtual void AttackProcess()
	{
	}

	protected virtual void UseSkillProcess(bool selfTarget, GameUnit target, RangeInfo range)
	{
	}

	public override void HandleEvent(string eventName)
	{
	}

	protected void ChangeTarget(RangeInfo range, bool fromSkill)
	{
	}

	public void SetAttackInterval(float val)
	{
	}

	public float GetAttackInterval()
	{
		return 0f;
	}

	public override void FindTarget(RangeInfo range, bool usingPathDist = false, HashSet<GameUnit> except = null, bool targetEnemy = true, bool excludeMe = true, bool setFixedTarget = false, bool usePathCheck = false, bool excludeSame = false, bool forceIgnoreTaunt = false)
	{
	}

	public override void HandleGridMapChanged()
	{
	}
}
