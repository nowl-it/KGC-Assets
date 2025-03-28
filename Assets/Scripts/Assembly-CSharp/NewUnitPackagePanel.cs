using System;
using Awesomepiece.Model;
using UnityEngine;
using UnityEngine.UI;

public class NewUnitPackagePanel : MonoBehaviour, IClosable
{
	[ComponentConnect]
	public Text nameText;

	[ComponentConnect]
	public Image unitImage;

	[ComponentConnect]
	public Text unitExpText;

	[ComponentConnect]
	public Text efficiency;

	[ComponentConnect]
	public Text goldText;

	public GameObject soulItem;

	public Text soulItemText;

	public GridLayoutGroup grid;

	[ComponentConnect]
	public ProfileAvatar profile;

	[ComponentConnect]
	public Text remainTimeText;

	[ComponentConnect]
	public Text priceText;

	[ComponentConnect]
	public UnitIllust unitIllust;

	public Text subTitleText;

	public Text descText;

	private ShopItemModel _model;

	private Action _closeCallback;

	private int level;

	public void Awake()
	{
	}

	public void Show(int itemId, int unit, Action closeCallback = null)
	{
	}

	public void ShowWithoutPopupAdd(int itemId, int unit, Action closeCallback = null)
	{
	}

	private void ShowInner(int unit, Action closeCallback)
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

	public void Update()
	{
	}
}
