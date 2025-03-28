using System.Collections.Generic;
using Awesomepiece.Model;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class HeroExpPackagePanel : MonoBehaviour, IClosable
{
	public static HeroExpPackagePanel Instance;

	[SerializeField]
	private UITableView _tableView;

	[SerializeField]
	private ScrollSnap _scrollSnap;

	[SerializeField]
	private ScrollRect _itemScrollRect;

	[SerializeField]
	private GameObject _itemPrefab;

	[SerializeField]
	private GameObject _iconPrefab;

	[SerializeField]
	private RectTransform _iconContentView;

	[SerializeField]
	private GameObject _iconsRoot;

	[SerializeField]
	private int _iconWidth;

	[SerializeField]
	private ConditionalSetActive[] _arrowConditionalSetActives;

	private List<ShopItemModel> _packageModels;

	private int _curIndex;

	private readonly List<Sequence> _arrowSequences;

	public void Show()
	{
	}

	private void SetPackagePanel(int idx, GameObject obj)
	{
	}

	private void ReloadPackages()
	{
	}

	private void OnScrolledToNext(int idx)
	{
	}

	private void ReloadTableView()
	{
	}

	private void ScrollTo(int idx)
	{
	}

	private void Update()
	{
	}

	public void HandleBuyPackage()
	{
	}

	public void HandleFetchShop()
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

	public void OnClickArrow(int addIndex)
	{
	}
}
