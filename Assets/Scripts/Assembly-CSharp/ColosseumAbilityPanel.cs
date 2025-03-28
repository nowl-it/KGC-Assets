using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class ColosseumAbilityPanel : MonoBehaviour
{
	[SerializeField]
	private CanvasGroup _canvasGroup;

	[SerializeField]
	private FlexibleUIElements _abilityElements;

	[SerializeField]
	private ClickOutsideClose _tooltip;

	[SerializeField]
	private Border _tooltipBorder;

	[SerializeField]
	private TextFitter _tooltipDescTextFitter;

	[SerializeField]
	private Text _tooltipNameText;

	[SerializeField]
	private Text _tooltipDescText;

	[SerializeField]
	private Image _tooltipIconImage;

	private readonly List<ColosseumAbilityPanelItem> _abilityItems;

	private ColosseumAbilityPanelItem _currentLevelAbilityItem;

	private BattleManager _battleManager;

	private ColosseumData _colosseumData;

	[SerializeField]
	private ColosseumAbilityPanelItem _expIndicator;

	[SerializeField]
	public Text expEffect;

	private int _expEffectCount;

	private float _lastCallTime;

	private bool _folded;

	private Tween _foldTween;

	private Tween _expIndicatorTween;

	private bool _isMyView;

	private int _lastAbilityLevel;

	private void Awake()
	{
	}

	public void Reload(BattleManager battleManager)
	{
	}

	public void ReloadAbilityExp(BattleManager battleManager)
	{
	}

	public void Fold(bool fold)
	{
	}

	public void ShowTooltip(Vector3 position, ResourceColosseumAbility resAbility)
	{
	}

	public void SetAlpha(float alpha)
	{
	}

	public void ShowGainAbilityExp(int exp, bool fromWorldTrigger)
	{
	}

	private void ShowAddExp(string text)
	{
	}

	private void ShowAddExpInner(string text, Text expEffectText = null)
	{
	}
}
