using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RogueLikeSelectFirstBuildingPanel : MonoBehaviour, IClosable
{
	[SerializeField]
	private RogueLikeSelectFirstBuildingPanelBuildingItem _buildingItemPrefab;

	[SerializeField]
	private RogueLikeSelectFirstBuildingPanelBuildingItem _lockedBuildingItemPrefab;

	[SerializeField]
	private GameObject _lockedBuildingsPartition;

	[SerializeField]
	private RectTransform _buildingItemsRoot;

	[SerializeField]
	private RectTransform _lockedBuildingItemsRoot;

	[SerializeField]
	private List<Image> _selectedBuildingIcons;

	[SerializeField]
	private RectTransform _buildingPanel;

	private List<RogueLikeSelectFirstBuildingPanelBuildingItem> _buildingItems;

	private List<RogueLikeSelectFirstBuildingPanelBuildingItem> _lockedBuildingItems;

	private Action _closeCallback;

	public void Show(Action closeCallback)
	{
	}

	public void Reload()
	{
	}

	public void OnSelectedBuildingsChanged()
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
