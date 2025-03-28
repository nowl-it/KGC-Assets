using System.Collections.Generic;

public class BeadMagicianAI : MoveAttackAI
{
	private int _stackBuffId;

	private int _maxBeadStack;

	private int _friendUnitId;

	private int _baseManaPerFromFriendUnit;

	private List<GameUnit> _gaveBeadUnits;

	public BeadMagicianAI(GameUnit me)
		: base(null)
	{
	}

	private void HandleFriendBuff()
	{
	}

	public override void HandleStartBattle()
	{
	}

	public override void HandleEndBattle()
	{
	}

	public override void HandleDie()
	{
	}

	public override void HandleReloadPotential()
	{
	}

	private void UpdateFriendUnitId()
	{
	}

	public override bool UseCustomFindSkillTargetFunc(ResourceSkill resSkill)
	{
		return false;
	}

	public override List<GameUnit> CustomFindSkillTargets(ResourceSkill resourceSkill)
	{
		return null;
	}

	public void HandleHasBeadUnitDead(GameUnit deadUnit)
	{
	}

	public void ReleaseBeadStack(GameUnit unit)
	{
	}

	public void HandleBeadUnitList(GameUnit unit, bool add)
	{
	}
}
