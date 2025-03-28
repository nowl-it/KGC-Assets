using System;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

public class CustomGrowthPanel : MonoBehaviour, IClosable
{
	[SerializeField]
	private UnitIllust _illust;

	[SerializeField]
	private Button _unitSelectButton;

	[SerializeField]
	private CustomGrowthItem _itemPrefab;

	[SerializeField]
	private RectTransform _itemsRoot;

	[Header("Select Panel")]
	[SerializeField]
	private CustomGrowthUnitItem _unitItemPrefab;

	[SerializeField]
	private RectTransform _unitItemsRoot;

	[SerializeField]
	private GameObject _selectPanel;

	[SerializeField]
	private ScrollRect _scrollRect;

	[SerializeField]
	private GameObject _bottomArrow;

	[SerializeField]
	private Image _bottomGradation;

	private List<CustomGrowthItem> _items;

	private List<CustomGrowthUnitItem> _unitItems;

	private CustomGrowthUnitItem _lastSelectedUnitItem;

	[CanBeNull]
	private ResourceUnit _resUnit;

	public string firstBoughtAt;

	public DateTime firstBoughtAt_;

	public void Show()
	{
	}

	private void Reload()
	{
	}

	public void ShowSelectPanel()
	{
	}

	public void CloseSelectPanel(bool select)
	{
	}

	private void ReloadSelectPanel()
	{
	}

	public void SetSelected(CustomGrowthUnitItem unitUnitItem)
	{
	}

	public void OnClickClose()
	{
	}

	public bool Close()
	{
		return false;
	}

	public void OnValueChanged()
	{
	}
}
