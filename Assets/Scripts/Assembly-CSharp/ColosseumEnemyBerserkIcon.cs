using UnityEngine;
using UnityEngine.UI;

public class ColosseumEnemyBerserkIcon : MonoBehaviour
{
	[SerializeField]
	private Transform _enemyBerserkFireEffect;

	[SerializeField]
	private Text _enemyBerserkValueText;

	[SerializeField]
	private ClickOutsideClose _tooltip;

	[SerializeField]
	private Border _tooltipBorder;

	[SerializeField]
	private TextFitter _tooltipDescTextFitter;

	[SerializeField]
	private Text _enemyBerserkTooltipDescText;

	[SerializeField]
	private ConditionalGroup _berserkValueConditionals;

	[SerializeField]
	private Text _valueAddEffectText;

	private int _valueAddEffectCount;

	private int _prevValue;

	private float _lastCallTime;

	public void BerserkValueCallback(bool force)
	{
	}

	private void Start()
	{
	}

	public void SetValue(int value, bool showEffect)
	{
	}

	private void ShowAddValueAnimation(int value, Text effectText)
	{
	}

	public void OnClick()
	{
	}
}
