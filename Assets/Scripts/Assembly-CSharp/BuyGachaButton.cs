using UnityEngine;
using UnityEngine.UI;

public class BuyGachaButton : MonoBehaviour
{
	[SerializeField]
	private Button _button;

	[SerializeField]
	private Price _price;

	[SerializeField]
	private ConditionalBase _stackBonusConditional;

	[SerializeField]
	private Text _buyCountText;

	[SerializeField]
	private ConditionalGroup _adCond;

	private BuyGachaButtonGroup _group;

	private ResourceShopItem _resShopItem;

	private int _gachaCount;

	private int _buttonIndex;

	public Price price => null;

	private void Awake()
	{
	}

	public void Set(BuyGachaButtonGroup group, ResourceShopItem resShopItem, bool canBuy, int gachaCount, int buttonIndex, string buyCountText)
	{
	}

	public void SetInteractable(bool interactable)
	{
	}

	public void SetStackBonus(bool bonusEnabled)
	{
	}

	public void SetAdCond(bool canPassAd)
	{
	}

	private void OnClick()
	{
	}

	private void OnDestroy()
	{
	}
}
