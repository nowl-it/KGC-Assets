using System;
using Awesomepiece.Model;
using UnityEngine;
using UnityEngine.UI;

public class NewHeroPackPanel : MonoBehaviour, IClosable
{
	public static NewHeroPackPanel Instance;

	public UnitSoulItem soulItem;

	[ComponentConnect]
	public Text nameText;

	public Text priceText;

	private ShopItemModel _newUnitPackageModel;

	public ResourceUnit resUnit;

	public GameObject unitSprite;

	public GameObject skinSprite;

	public GameObject unitPrefab;

	public GameObject skinPrefab;

	public Action onClose;

	public UnitIllust unitIllust;

	public Text unitName;

	public Text skinName;

	public Text unitDesc;

	public Text leftTime;

	public Image kingSoulImage;

	private bool _ownCard;

	private DateTime untilAt;

	private ResourceShopItem _packageItem;

	private ResourceSkin _resSkin;

	private int _unitID;

	public Price packPrice;

	public Image unitInfoIcon;

	public void Awake()
	{
	}

	public void ReloadIllust()
	{
	}

	public void Show()
	{
	}

	private void ReloadUnitSprite()
	{
	}

	private void ReloadSkin()
	{
	}

	public void ShowSkinPrefab(string prefabName)
	{
	}

	public void Update()
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

	public void OnClickBuy()
	{
	}

	public void OnClickShowInfo()
	{
	}
}
