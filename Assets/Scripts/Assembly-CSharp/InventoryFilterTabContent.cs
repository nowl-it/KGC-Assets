using System;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

public class InventoryFilterTabContent : MonoBehaviour
{
	[CanBeNull]
	[SerializeField]
	private Image _activatedBG;

	[CanBeNull]
	[SerializeField]
	private Image _activated;

	[SerializeField]
	[CanBeNull]
	private Image _filterIcon;

	[SerializeField]
	private Text _filterText;

	[SerializeField]
	private Text _filterCountText;

	private bool _isExceptFilter;

	private Func<object, int, bool> _callback;

	private bool _isActive;

	private Sprite _icon;

	[NonSerialized]
	public InventoryFilterTab parentFilterTab;

	[NonSerialized]
	public string filterCategoryStr;

	public Action<bool> onFilterToggled;

	private bool _isDismantleFilter;

	private int _index;

	public Sprite icon => null;

	private IInventorySortFilterHandler _inventorySortFilterHandler => null;

	public bool isAllSelectContent { get; private set; }

	public new bool enabled { get; private set; }

	public void Init(Func<object, int, bool> callback, int index, string filterCategory, Sprite sprite, InventoryFilterTab parent, bool isDismantleFilter, bool isAllSelectContent, bool isExceptFilter)
	{
	}

	public void SetFilterActive(bool active, bool callback = true)
	{
	}

	public void ToggleFilterActive(bool doFilter)
	{
	}

	public void ToggleFilterActive()
	{
	}

	public void ReloadFilterElementCountText<T>(List<T> filteredItems = null)
	{
	}

	public bool Filtering(object target)
	{
		return false;
	}

	public bool IsFilterActivated()
	{
		return false;
	}

	public void Clear()
	{
	}

	private void OnDestroy()
	{
	}
}
