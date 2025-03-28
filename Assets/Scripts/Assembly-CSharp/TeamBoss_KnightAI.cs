using System.Collections.Generic;
using UnityEngine;

public class TeamBoss_KnightAI : MoveAttackAI
{
	private int buffToTeamBossesWhenDead;

	private Vector2Int homePos;

	private int defPerByDistance;

	private List<GameUnit> teamBosses => null;

	public TeamBoss_KnightAI(GameUnit unit)
		: base(null)
	{
	}

	public override void Update(float dt)
	{
	}

	public override void HandleEvent(string eventName)
	{
	}

	public override void HandleDie()
	{
	}
}
