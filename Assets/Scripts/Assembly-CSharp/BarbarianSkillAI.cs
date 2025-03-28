using System.Collections.Generic;
using UnityEngine;

public class BarbarianSkillAI : MoveAttackAI
{
	private readonly Dictionary<Vector2Int, Vector2Int> _tilePrevPosMap;

	private readonly Buff _buffWhenLowHp;

	private bool _pausePathFinding;

	private readonly HighestValuePosHelper _highestValuePosHelper;

	private readonly List<Vector2Int> _queue;

	private readonly List<Vector2Int> _lst;

	private readonly HashSet<Vector2Int> _visited;

	private readonly List<Vector2Int> _path;

	public BarbarianSkillAI(GameUnit me)
		: base(null)
	{
	}

	public override void HandleStartBattle()
	{
	}

	protected override void OnAction(AIAction action)
	{
	}

	public override void HandleEvent(string eventName)
	{
	}

	public void CalculateAndMoveToHighestValue()
	{
	}

	private void CheckPathBfs()
	{
	}

	private float GetPathDistance(Vector2Int start, Vector2Int target)
	{
		return 0f;
	}

	private void MakePath(Vector2Int start, Vector2Int target)
	{
	}

	public override void HandleHpRatioChanged(float beforeRatio, float afterRatio)
	{
	}

	public override void HandleGridMapChanged()
	{
	}
}
