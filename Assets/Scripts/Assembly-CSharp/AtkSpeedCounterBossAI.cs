using System.Collections.Generic;
using UnityEngine;

public class AtkSpeedCounterBossAI : MoveAttackAI
{
	private Dictionary<int, int> attackCountDic;

	private float addAtkPerByEnemyBaseAtk;

	private float addMAtkPerByEnemyBaseAtk;

	private float addDefPerByEnemyBaseAtk;

	private float addAtkPerByEnemyBaseAtkMax;

	private float addMAtkPerByEnemyBaseAtkMax;

	private float addDefPerByEnemyBaseAtkMax;

	private GameObject auraGameObject;

	private Vector2Int homePos;

	public AtkSpeedCounterBossAI(GameUnit me)
		: base(null)
	{
	}

	public override void HandleStartBattle()
	{
	}

	public override void Update(float dt)
	{
	}

	public override void HandleDamaged(GameUnit from, DamageInfo damageInfo)
	{
	}

	public override void HandleEvent(string eventName)
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
}
