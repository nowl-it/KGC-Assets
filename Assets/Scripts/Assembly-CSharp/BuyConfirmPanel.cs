using System;
using UnityEngine;
using UnityEngine.UI;

public class BuyConfirmPanel : MonoBehaviour, IClosable
{
	[ComponentConnect]
	public Text title;

	[ComponentConnect]
	public RectTransform box;

	[ComponentConnect]
	public ShopItem shopItem;

	[ComponentConnect]
	public Button buyButton;

	[ComponentConnect]
	public Price price;

	[ComponentConnect]
	public GameObject upImage;

	[ComponentConnect]
	public GameObject gachaInfo;

	public GameObject[] partitions;

	[ComponentConnect]
	public ImageTextPair gachaGold;

	[ComponentConnect]
	public ImageTextPair gachaContents;

	[ComponentConnect]
	public Text gachaContentsText;

	[ComponentConnect]
	public Text gachaNewInfo;

	[ComponentConnect]
	public Button closeArea;

	[ComponentConnect]
	public UnitCard newUnitCard;

	[ComponentConnect]
	public GameObject twoItems;

	[ComponentConnect]
	public GameObject threeItems;

	[ComponentConnect]
	public ShopItem shopItem2;

	[ComponentConnect]
	public ShopItem shopItem3;

	[ComponentConnect]
	public ShopItem shopItem4;

	[ComponentConnect]
	public ShopItem shopItem5;

	[ComponentConnect]
	public ShopItem shopItem6;

	[ComponentConnect]
	public GameObject normalTitle;

	[ComponentConnect]
	public GameObject packageTitle;

	[ComponentConnect]
	public Text packageTitleLabel;

	private Action _buyCallback;

	private ShopItem _fromShopItem;

	private bool _loading;

	private int _newUnitId;

	public virtual void Show(ShopItem from, Action callback)
	{
	}

	public void SetLoading(bool set)
	{
	}

	public void ShowUnitExp(int unitID, int exp)
	{
	}

	public void ShowUnit(int unitId)
	{
	}

	public void Hide()
	{
	}

	public void OnClickBuy()
	{
	}

	private void ShowBuyCurrencyPopup()
	{
	}

	public bool Close()
	{
		return false;
	}

	public void OnClickClose()
	{
	}
}
