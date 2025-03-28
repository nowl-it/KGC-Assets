using UnityEngine;
using UnityEngine.UI;

public class RogueLikeUnitInfoPanel : MonoBehaviour, IClosable
{
	public static RogueLikeUnitInfoPanel Instance;

	[SerializeField]
	private UnitInfoPanelBase _unitInfoPanel;

	[SerializeField]
	private LayoutFitter _layoutFitter;

	[SerializeField]
	private CanvasGroup _cg;

	[SerializeField]
	private Image _levelStarImage;

	[SerializeField]
	private Gauge _expGauge;

	[SerializeField]
	private Text _ownedHeroLevelText;

	[SerializeField]
	private Text[] _potentialDescTexts;

	[SerializeField]
	private ConditionalGroup _heroOwnTextConditionals;

	[SerializeField]
	private ConditionalTextColor[] _heroOwnPotentialLevelTexts;

	[SerializeField]
	private ConditionalGroup[] _potentialLockedConditionals;

	[SerializeField]
	private Text _potentialDescText;

	[SerializeField]
	private PotentialButton[] _potentialButtons;

	[SerializeField]
	private GameObject _runeInfosRoot;

	[SerializeField]
	private RuneInfoPanel[] _runeInfoPanels;

	[SerializeField]
	private LayoutFitter _itemInfoLayoutFitter;

	[SerializeField]
	private ItemInfoPanel[] _itemInfoPanels;

	[SerializeField]
	private ConditionalImage[] _itemStarConditionalImages;

	[SerializeField]
	private RuneInfoPanel _runeInfoPopup;

	private GameUnit _target;

	private float _updateTimer;

	private bool _setBG;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void SetBG()
	{
	}

	public void Show(GameUnit target)
	{
	}

	public void Hide()
	{
	}

	public bool Close()
	{
		return false;
	}

	public void OnClickClose()
	{
	}

	private void Reload()
	{
	}

	private void Update()
	{
	}

	private void ReloadTier1Potentials()
	{
	}

	private void OnClickPotentialButton(PotentialButton button, int slot)
	{
	}

	public void ShowRuneInfoPopup(Rune rune)
	{
	}
}
