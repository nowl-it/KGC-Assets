using System.Collections.Generic;

public class TeamBoss_WizardAI : MoveAttackAI
{
	private int buffToTeamBossesWhenDead;

	private int manaDrain;

	private float drainTime;

	private float manaDrainInterval;

	private RangeInfo manaDrainRange;

	private List<GameUnit> teamBosses => null;

	public TeamBoss_WizardAI(GameUnit unit)
		: base(null)
	{
	}

	public override void Update(float dt)
	{
	}

	public override void HandleEvent(string eventName)
	{
	}

	private void DrainMana()
	{
	}

	public override void HandleDie()
	{
	}
}
