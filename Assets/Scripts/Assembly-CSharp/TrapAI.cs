using System;
using System.Collections.Generic;
using UnityEngine;

public class TrapAI : MoveAttackAI
{
	public class TrapInfo
	{
		public float trapTimer;

		public List<GameObject> trapEffects;
	}

	private float _trapDuration;

	private RangeInfo _trapRange;

	private float _tick;

	private float _tickCounter;

	private float _trapMAtkPer;

	private int _trapTargetAttackMinusDebuff;

	private float _trapTargetAttackMinusDebuffTime;

	private List<ResourceSkill.Effect> _targetEffects;

	private List<ResourceSkill.Effect> _trapEffects;

	private List<ResourceSkill.Effect> _trapTargetEffects;

	private bool _addBaseAttackOnTrap;

	private RangeInfo _auraRange;

	private float _auraTick;

	private ResourceSkill _auraDebuffSkill;

	private ResourceSkill _enemyMoveBuffSkill;

	private Dictionary<Vector2Int, TrapInfo> _trapInfos;

	private static readonly int _bye;

	private float _auraTimer;

	private IDisposable _spawnUnitDisposable;

	public TrapAI(GameUnit me)
		: base(null)
	{
	}

	public override void Update(float dt)
	{
	}

	private void UpdateTraps(float dt)
	{
	}

	private void TrapAttack(List<Vector2Int> attackPos = null)
	{
	}

	public void DebuffToAuraTarget()
	{
	}

	public override void HandleEvent(string eventName)
	{
	}

	private void AddBaseAttack()
	{
	}

	private void MakeTraps()
	{
	}

	public override void Clear()
	{
	}

	public override void HandleDie()
	{
	}

	public override void HandleEndBattle()
	{
	}

	public override void HandleStartBattle()
	{
	}

	public void MoveSkillBuff(GameUnit unit, Vector2Int before, Vector2Int after)
	{
	}
}
