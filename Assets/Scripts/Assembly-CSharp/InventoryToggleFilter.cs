using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryToggleFilter : MonoBehaviour
{
	[SerializeField]
	private Text _filterNameText;

	[SerializeField]
	private GameObject _onObj;

	[SerializeField]
	private GameObject _offObj;

	private Func<object, bool> _toggleFilterCallback;

	private bool _isOn;

	public Action<bool> onToggled;

	private IInventorySortFilterHandler _filterHandler;

	public void Set(IInventorySortFilterHandler filterHandler, Func<object, bool> toggleCallback, string filterName)
	{
	}

	public void ToggleFilter()
	{
	}

	public void SetToggle(bool on, bool callback = true)
	{
	}

	public List<T> Filtering<T>(List<T> inventoryItems)
	{
		return null;
	}

	public void Clear()
	{
	}

	public bool IsFilterActivated()
	{
		return false;
	}
}
