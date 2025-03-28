public class Unit42210AI : MoveAttackAI
{
	private Unit42200AI _parentAI;

	private float _healAdaptabilityFromUnitDefDen;

	public Unit42210AI(GameUnit me)
		: base(null)
	{
	}

	public override void HandleStartBattle()
	{
	}

	public override int HandleHeal(int value, GameUnit from)
	{
		return 0;
	}

	public void SetParentAI(Unit42200AI parentAI)
	{
	}
}
