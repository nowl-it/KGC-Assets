using System;
using System.Collections.Generic;
using UnityEngine;

public class HighestValuePosHelper
{
	public struct HighestValuePosInfo
	{
		public float value;

		public int tileValue;

		public Vector2Int pos;
	}

	private readonly Dictionary<Vector2Int, int> _tileValueMap;

	private List<Vector2Int> _splashRangeOffset;

	private HighestValuePosInfo _posInfo;

	private GameUnit _me;

	private Func<ResourceSkill> _getSkillCallback;

	private ResourceSkill _skill => null;

	public HighestValuePosHelper(GameUnit me, Func<ResourceSkill> getSkillCallback)
	{
	}

	public void StartBattle()
	{
	}

	private List<Vector2Int> GetSplashRangeOffset()
	{
		return null;
	}

	public void CalculateHighestValue()
	{
	}

	private void AddTileValueNearby(GameUnit unit)
	{
	}

	public void CalculateHighestValuePos(Func<Vector2Int, float?> valueAddAmount)
	{
	}

	public HighestValuePosInfo GetHighestValuePosInfo()
	{
		return default(HighestValuePosInfo);
	}

	public void ClearValues()
	{
	}
}
