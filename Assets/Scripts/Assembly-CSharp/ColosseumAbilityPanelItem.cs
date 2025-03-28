using System;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class ColosseumAbilityPanelItem : MonoBehaviour
{
	[SerializeField]
	private GameObject _lockedObject;

	[SerializeField]
	private GameObject _fullExpObject;

	[SerializeField]
	private Button _button;

	[SerializeField]
	private Image _expGaugeImage;

	[SerializeField]
	private Text _expGaugeText;

	[SerializeField]
	private Image _fullExpImage;

	[SerializeField]
	private Image _iconImage;

	[SerializeField]
	private Text _representativeValue;

	private ColosseumAbilityPanel _abilityPanel;

	private bool _isMine;

	private ResourceColosseumAbility _resAbility;

	private bool _canUnlock;

	private Tween _fullExpImageTween;

	private IDisposable _activeChecker;

	private IDisposable _representativeValueChecker;

	public bool canShowWhenFolded => false;

	public void Set(ColosseumAbilityPanel abilityPanel, ResourceColosseumAbility resAbility, BattleManager battleManager, bool activated = true)
	{
	}

	public void SetExp(int currentExp, int maxExp)
	{
	}

	public void OnClick()
	{
	}

	public void OnDestroy()
	{
	}
}
