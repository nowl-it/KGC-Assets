using System.Collections.Generic;
using UnityEngine;

public class EffectAreaDrawer : MonoBehaviour
{
	private class CurrentlyShowingEffectArea
	{
		public int team;

		public int skillID;
	}

	public const int EFFECT_INDEX_START_OFFSET = 1;

	public const int MAX_EFFECT_AT_THE_SAME_TIME = 8;

	public Color teamOutlineColor;

	public Color enemyOutlineColor;

	public Color overlappedOutlineColor;

	[SerializeField]
	private GameObjectPool _effectAreaPool;

	[SerializeField]
	private Material _stencilMaterial;

	[SerializeField]
	private Material _stenciledMaterial;

	private readonly CurrentlyShowingEffectArea[] _currentlyShowingEffectAreas;

	private readonly Dictionary<int, EffectArea> _effectAreaDict;

	private readonly List<ulong> _effectAreaRemoveWorkTimers;

	private readonly Dictionary<int, Material> _stencilMaterialDict;

	private readonly Dictionary<int, Material> _stenciledMaterialDict;

	public BattleManager battle;

	public void Awake()
	{
	}

	public void ShowSplashEffectArea(GameUnit from, ResourceSkill resSkill, Vector2Int skillUsingPos, float duration)
	{
	}

	public Material GetStencilMaterial(int mask)
	{
		return null;
	}

	public Material GetStenciledMaterial(int mask)
	{
		return null;
	}

	public void ReturnToPool(GameObject gameObject)
	{
	}

	public void Clear()
	{
	}
}
