using System;
using System.Collections.Generic;
using UnityEngine;

public class InventoryFilterComponent : MonoBehaviour
{
	public enum MirroredActionCondition
	{
		On = 0,
		Off = 1,
		All = 2
	}

	public class FilterTabOption
	{
		public Func<object, int, bool>[] filterCallbacks;

		public string[] filterCategories;

		public int index;

		public string tabName;

		public Sprite[] sprites;

		public bool isDismantleFilter;

		public int maxRowCount;

		public bool allSelectContent;

		public int mirroredTabIdx;

		public MirroredActionCondition mirroredActionCondition;

		public bool isMultiFilter;

		public bool partitionEnabled;

		public bool isExceptFilter;
	}

	public class ToggleFilterTabOption
	{
		public Func<object, bool>[] filterCallbacks;

		public string[] filterNames;
	}

	private RectTransform _rectTransform;

	[SerializeField]
	private RectTransform _inventoryFilterTabsRoot;

	[SerializeField]
	private InventoryFilterTab _inventoryFilterTabPrefab;

	[SerializeField]
	private List<InventoryFilterTab> _inventoryFilterTabs;

	[SerializeField]
	private UIFitter[] _uiFitters;

	[SerializeField]
	private RectTransform _inventoryToggleFiltersRoot;

	[SerializeField]
	private InventoryToggleFilter _inventoryToggleFilterPrefab;

	[SerializeField]
	private List<InventoryToggleFilter> _inventoryToggleFilters;

	public IInventorySortFilterHandler inventorySortFilterHandler;

	[SerializeField]
	private GameObject _toggleFilterObj;

	[SerializeField]
	private ClickOutsideClose _clickOutsideClose;

	public RectTransform rectTransform => null;

	public List<InventoryFilterTab> inventoryFilterTabs => null;

	public List<InventoryToggleFilter> InventoryToggleFilters => null;

	public InventoryFilterTab lastToggledFilterTab { get; private set; }

	public InventoryFilterTab SetFilterTab(IInventorySortFilterHandler handler, FilterTabOption option)
	{
		return null;
	}

	public void SetToggleFilter(IInventorySortFilterHandler handler, ToggleFilterTabOption option)
	{
	}

	public void Clear()
	{
	}

	public void ReleaseAllFilters()
	{
	}

	public void FitLayout()
	{
	}

	public List<T> Filtering<T>(List<T> inventoryItems, InventoryFilterTab exclude = null)
	{
		return null;
	}

	public int GetActivateFilterCount()
	{
		return 0;
	}

	public void HandleMultiFilterToggled(InventoryFilterTab filterTab)
	{
	}

	public void Show()
	{
	}

	public void Close()
	{
	}

	public void AddOutsideCloseExcept(RectTransform rt)
	{
	}

	public void Toggle()
	{
	}

	public void ReloadFilterElementCountText()
	{
	}
}
