using System;
using Awesomepiece.Model;
using UnityEngine;
using UnityEngine.UI;

public class PopupPackagePopup : MonoBehaviour, IClosable
{
	[SerializeField]
	private Text _title;

	[SerializeField]
	private Text _efficiencyText;

	[SerializeField]
	private ClickableShopItemIcon _clickableShopItemIcon;

	[SerializeField]
	private Text _subTitle;

	[SerializeField]
	private Text _remainTimeText;

	[SerializeField]
	private Price _price;

	[SerializeField]
	private Image _effect;

	private Action _onClose;

	private ShopItemModel _shopItem;

	private ResourceShopItem _resShopItemCache;

	private ResourceShopItem _resShopItem => null;

	public void Show(ShopItemModel shopItem, Action closeCallback = null)
	{
	}

	public void OnClickBuy()
	{
	}

	public void OnClickClose()
	{
	}

	public bool Close()
	{
		return false;
	}
}
