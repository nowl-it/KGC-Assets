using System.Collections.Generic;
using UnityEngine;

public class DashBossAI : MoveAttackAI
{
	private int _phase;

	private float _manaDrainPer;

	private List<ResourceSkill.Effect> _effects;

	private float _effectTime;

	private float _transformTime;

	private Vector2Int _initPos;

	private Dictionary<int, int> _manaDic;

	private AudioObject _skillSound;

	public DashBossAI(GameUnit me)
		: base(null)
	{
	}

	public override void HandleStartBattle()
	{
	}

	public override void Update(float dt)
	{
	}

	private void DrainMana()
	{
	}

	public override void HandleEvent(string eventName)
	{
	}

	private void TeleportToHome()
	{
	}

	public override void Clear()
	{
	}
}
