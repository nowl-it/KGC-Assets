using System.Collections.Generic;

public class CloneBossAI : MoveAttackAI
{
	private int _cloneUnitID;

	private float _cloneSkillTime;

	private float _cloneSkillTimer;

	private int _cloneUnitCount;

	private List<int> _posX;

	private List<int> _posY;

	private List<GameUnit> _cloneUnits;

	private bool _isUsingCloneSkill;

	private long _totalHp;

	private int _liveUnitCount;

	private bool _summonedUnits;

	public CloneBossAI(GameUnit me)
		: base(null)
	{
	}

	public override void OnInitStage()
	{
	}

	private void SummonCloneUnits()
	{
	}

	public override void HandleStartBattle()
	{
	}

	public override void HandleEvent(string eventName)
	{
	}

	public override void UpdateForCheck(float dt)
	{
	}

	private void EndCloneSkill()
	{
	}

	private void UseCloneSkill()
	{
	}

	private void KillCloneUnits()
	{
	}

	public void UnreserveCloneUnits()
	{
	}

	public override void Clear()
	{
	}

	public void UseCloneHealSkill()
	{
	}
}
