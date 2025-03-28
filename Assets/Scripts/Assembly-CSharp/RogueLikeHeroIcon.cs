using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class RogueLikeHeroIcon : MonoBehaviour
{
	[SerializeField]
	private Image _iconImage;

	[SerializeField]
	private ImageFontText _levelText;

	[SerializeField]
	private ImageFont[] _levelFonts;

	[SerializeField]
	private Image _levelStar;

	[SerializeField]
	private RectTransform _expGauge;

	[SerializeField]
	private Text _expText;

	[SerializeField]
	private RectTransform _hpGauge;

	[SerializeField]
	private Text _nameText;

	[SerializeField]
	private Image _potentialIcon;

	[SerializeField]
	private Text _potentialUnlockText;

	[SerializeField]
	private ConditionalGroup _potentialConditionals;

	private float _expGaugeOriginWidth;

	private float _hpGaugeOriginWidth;

	private Tween _potentialUnlockTextTween;

	public RogueLikeCardData cardData { get; private set; }

	private void OnEnable()
	{
	}

	public void Set(RogueLikeCardData card)
	{
	}

	public void Reload()
	{
	}

	public void SetExpGauge(float per)
	{
	}

	public void SetHpGauge(float per)
	{
	}

	public void ShowPotentialUnlockText(int level, bool isPermanent)
	{
	}

	public void OnClick()
	{
	}
}
