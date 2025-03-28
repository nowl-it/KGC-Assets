using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class GridTile : MonoBehaviour
{
	public UnitGrid grid;

	public SpriteRenderer gridSprite;

	public SpriteRenderer icon;

	public GridObject gridObj;

	public Tween effectTween;

	public SpriteRenderer effectSprite;

	public SpriteRenderer mergiableSprite;

	public List<(List<Buff> fromList, SpriteRenderer sprite)> customEffectSprites;

	public Animator effectAnimator;

	private List<Animator> _effectAnimators;

	private List<ConditionalRoot> _effectAnimatorsRoot;

	private List<Animator> _tileBuffAnimators;

	private ResourceItem _resItem;

	private bool _mergiableActive;

	private ulong? _effectWorkTimerKey;

	public Vector2Int tilePos => default(Vector2Int);

	private void Awake()
	{
	}

	private void Update()
	{
	}

	public void SetMergible(bool set)
	{
	}

	public void SetPos(Vector2Int pos, Vector2 offset = default(Vector2))
	{
	}

	public void SetTileBuff(ResourceItem resItem)
	{
	}

	public void SetWaiting(bool set)
	{
	}

	public Animator ShowAnim(int value, string trigger, float delay = 0f)
	{
		return null;
	}

	public void StopAnim()
	{
	}

	public void ClearTileBuffs()
	{
	}

	public void AddCustomEffectSprite(string prefab, Buff from)
	{
	}

	public void AddTileEffectAnimator(string prefab)
	{
	}

	public void RemoveAllCustomEffectSprite()
	{
	}

	public void RemoveCustomEffectSprite(string prefab, Buff from)
	{
	}

	public void RemoveTileEffectAnimator(string prefab)
	{
	}

	public void ClearCustomEffectSprite()
	{
	}
}
