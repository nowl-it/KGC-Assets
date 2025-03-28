using System;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class BuildingItem : MonoBehaviour
{
	public Animator altar;

	public Animator flame;

	public Text levelText;

	public Text nameText;

	public Text[] descText;

	public Image[] descEffect;

	public Sequence[] descEffectSequence;

	public Button[] upgradeButtons;

	public ConditionalRoot condRoot;

	public bool descTextRemoveNewline;

	[HideInInspector]
	public BuildingData buildingData;

	private Action<BuildingItem> _onClickCallback;

	private Sequence _altarTween;

	private Tween _levelTween;

	private bool _clanRaidMode;

	public int level => 0;

	private int _currentLevel => 0;

	public void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnEnable()
	{
	}

	public void Init(int id, bool setFlamePosition)
	{
	}

	public void Set(BuildingData buildingData, bool effect = false)
	{
	}

	public void SetClanRaidMode(bool v)
	{
	}

	public void SetUpgradable(bool v)
	{
	}

	private void Reload()
	{
	}

	private void Reload(bool effect)
	{
	}

	public void OnClick()
	{
	}

	public void OnClickLevelUp(int level)
	{
	}

	private void LevelUpImpl(int levelIncreaseAmount)
	{
	}
}
