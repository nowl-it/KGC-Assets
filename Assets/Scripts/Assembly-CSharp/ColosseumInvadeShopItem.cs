using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class ColosseumInvadeShopItem : MonoBehaviour
{
	[SerializeField]
	private ColosseumInvadeTierIcon _tierIcon;

	[SerializeField]
	private Image _frameImage;

	[SerializeField]
	private Image _unitImage;

	[SerializeField]
	private Text _unitNameText;

	[SerializeField]
	private Text _unitCountText;

	[SerializeField]
	private Text _bossText;

	[SerializeField]
	private Text _descText;

	[SerializeField]
	private Image _unitThemeTextBGImage;

	[SerializeField]
	private Text _unitThemeNameText;

	[SerializeField]
	private Border _unitThemeBGBorder;

	[SerializeField]
	private TextFitter _unitThemeTextFitter;

	[SerializeField]
	private Text _abilityExpAmountText;

	[SerializeField]
	private Text _priceText;

	[SerializeField]
	private Text _soldOutText;

	[SerializeField]
	private Button _buyButton;

	[SerializeField]
	private ConditionalGroup _buyButtonConditionals;

	[SerializeField]
	private ConditionalGroup _soldOutConditionals;

	[SerializeField]
	private Button _tooltipButton;

	[SerializeField]
	private Text _tooltipText;

	[SerializeField]
	private TextFitter _tooltipTextFitter;

	[SerializeField]
	private Border _tooltipBorder;

	[SerializeField]
	private CanvasGroup _tooltipCanvas;

	[SerializeField]
	private GameObject _activeObj;

	[SerializeField]
	private GameObject _effectObj;

	[SerializeField]
	private Animator _animator;

	private ResourceColosseumInvadeItem _resInvadeItem;

	private ColosseumData _colosseumData;

	public bool buy;

	private Tween _tooltipTween;

	private int _price => 0;

	public void Set(int index, ResourceColosseumInvadeItem resInvadeItem, bool init = false, float effectDelay = 0f)
	{
	}

	public void OnClickBuy()
	{
	}

	public void ReloadPrice()
	{
	}

	public void ReloadPriceText()
	{
	}

	public void ReloadByBuyState()
	{
	}

	public void ShowToolTip()
	{
	}
}
