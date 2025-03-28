using System.Collections.Generic;

public class CloneHealAI : MoveAttackAI
{
	private List<GameUnit> cloneUnits;

	public int averageHp;

	public CloneHealAI(GameUnit me)
		: base(null)
	{
	}

	public override void HandleStartBattle()
	{
	}

	public override void HandleEvent(string eventName)
	{
	}

	private void UseCloneHealSkill()
	{
	}
}
