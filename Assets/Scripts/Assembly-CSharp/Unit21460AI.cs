using System.Collections.Generic;
using UnityEngine;

public class Unit21460AI : PhaseBossAI
{
	private const int SUB_BOSS_COUNT = 4;

	private List<GameUnit> _subBosses;

	private List<ResourceSkill> _eventBuffs;

	private bool _eventSkillStarted;

	private int _changePhaseTransformSkill;

	private float _timer;

	private float _interval;

	private float _transformInvincibleTime;

	private List<int> _randomSkillPool;

	private List<int> _nextSkillList;

	private int _ultimateSkill;

	private int _skillCountForUlt;

	private float _summonDelay;

	private int _randomSkillIteration;

	private int _subBossId;

	private string _bossGaugeBarPrefix;

	private readonly Vector2Int[] _summonOffsets;

	private readonly Dictionary<int, List<int>> _animationMap;

	public Unit21460AI(GameUnit me)
		: base(null)
	{
	}

	protected override void OnAction(AIAction action)
	{
	}

	public override void HandleDie()
	{
	}

	protected override void EnterPhase(int newPhase)
	{
	}

	private int PickNextSkill()
	{
		return 0;
	}

	public override void HandleShootSkill(ResourceSkill resSkill, List<GameUnit> targets)
	{
	}

	public override bool SetHpBar()
	{
		return false;
	}
}
