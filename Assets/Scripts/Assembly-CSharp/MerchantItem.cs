using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MerchantItem : MonoBehaviour
{
	public ItemInfoPanel itemInfoPanel;

	public Button buyButton;

	public ConditionalRootGroup adButton;

	public ImageTextPair pricePair;

	public GameObject soldOut;

	public GameObject soldOutText;

	public Item item;

	public ResourceItem resItem;

	public int count;

	public int price;

	public Image itemPassIcon;

	public Image passIcon;

	private bool _soldOut;

	public bool isSoldOut => false;

	public void Set(ResourceItem resItem, int count, int price)
	{
	}

	public void Set(ResourceItem resItem, List<Item.Option> options, int count, int price)
	{
	}

	public void ReloadPrice()
	{
	}

	public void SoldOut(bool v = true)
	{
	}

	public void ReloadPassIcon(int addAmount = 0)
	{
	}
}
