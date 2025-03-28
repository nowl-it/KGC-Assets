using System.Collections.Generic;
using Awesomepiece.Model;
using UnityEngine;
using UnityEngine.UI;

public class SpecialSeasonalEventShopPanel : MonoBehaviour, IClosable
{
	[ComponentConnect]
	public Text title;

	[ComponentConnect]
	public TabManager tabManager;

	[ComponentConnect]
	public TabComponent tabPrefab;

	[ComponentConnect]
	public UITableView itemListViewPrefab;

	[ComponentConnect]
	public RectTransform tabRect;

	[ComponentConnect]
	public RectTransform itemListViewRect;

	[ComponentConnect]
	public ImageTextPair tokenCountPair;

	[ComponentConnect]
	public ClickableShopItemIcon priceIcon;

	[ComponentConnect]
	public LerpText tokenCountText;

	[ComponentConnect]
	public Text remainTimeText;

	[ComponentConnect]
	public Text periodText;

	[ComponentConnect]
	public Text shopTitle;

	[ComponentConnect]
	public Text shopDesc;

	[ComponentConnect]
	public GameObject shopShortcut;

	[ComponentConnect]
	public SelectAmountPanel selectAmountPanel;

	private Dictionary<ResourceShopItem.SpecialSeasonalTokenType, UITableView> _itemListView;

	private Dictionary<ResourceShopItem.SpecialSeasonalTokenType, TabComponent> _tabs;

	private Dictionary<ResourceShopItem.SpecialSeasonalTokenType, List<ShopItemModel>> _items;

	private List<ResourceShopItem.SpecialSeasonalTokenType> _tokenTypes;

	private bool _init;

	private int _currentTabIdx;

	public void Show()
	{
	}

	public void Reload()
	{
	}

	private void InitializeTabs()
	{
	}

	private void ReloadItems()
	{
	}

	private void SetTokenPriceAndTextPair(bool force)
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
