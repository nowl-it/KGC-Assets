using UnityEngine;
using UnityEngine.UI;

public class RogueLikeMerchantItem : MonoBehaviour
{
	[SerializeField]
	private RogueLikeItemUI _itemUI;

	[SerializeField]
	private RogueLikeMerchantHeroItem _heroItemUI;

	[SerializeField]
	private GameObject _itemIcon;

	[SerializeField]
	private RectTransform _textGroup;

	[SerializeField]
	private ConditionalGroup _itemStateConditionals;

	[SerializeField]
	private Text _discountPerText;

	[SerializeField]
	private Text _priceText;

	[SerializeField]
	private Border _border;

	private int _index;

	private bool _soldOut;

	private int _price;

	public RogueLikeMerchantPanel.ItemData itemData { get; private set; }

	public void Set(RogueLikeMerchantPanel.ItemData item, GameUnit equippedBy, int price, int index, int discountPer, bool own)
	{
	}

	public void ReloadPrice()
	{
	}

	public void SoldOut(bool v = true)
	{
	}

	public void OnClickBuy()
	{
	}
}
