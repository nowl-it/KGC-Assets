using System;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

public class InventoryFilterTab : MonoBehaviour
{
	[Serializable]
	public enum MultiFilterTab
	{
		None = 0,
		Parent = 1,
		Child = 2
	}

	[SerializeField]
	private RectTransform _filterContentsRoot;

	[SerializeField]
	private List<InventoryFilterTabContent> _filterContents;

	[SerializeField]
	private ScrollRect _filterContentsScrollView;

	[SerializeField]
	private LayoutFitter _filterContentsLayoutFitter;

	[SerializeField]
	[CanBeNull]
	private Border _filterContentsBorder;

	[SerializeField]
	private Text _categoryNameText;

	[SerializeField]
	[Space(20f)]
	private List<InventoryFilterTab> _multiFilterTabs;

	[SerializeField]
	[CanBeNull]
	private Image _multiFilterActivatedBG;

	[SerializeField]
	private Image _multiFilterActivated;

	[SerializeField]
	private Button _multiFilterReleaseButton;

	[SerializeField]
	private Text _multiFilterDropdownIcon;

	[SerializeField]
	private Text _multiFilterText;

	[SerializeField]
	[Space(20f)]
	private MultiFilterTab _multiFilterTabState;

	[SerializeField]
	private GameObject _partition;

	[NonSerialized]
	public bool isSingleFilter;

	private int _multiFilterTabContentCount;

	private bool _isMultiFilterActive;

	[NonSerialized]
	public InventoryFilterComponent filterParent;

	[NonSerialized]
	public InventoryFilterTab parentTab;

	private string _tabName;

	private bool _checkOutsideClick;

	private bool _isDismantleFilter;

	private float _originalScrollRectViewHeight;

	private int _maxRowCount;

	public InventoryFilterComponent.MirroredActionCondition _mirroredActionCondition;

	private bool _isExceptFilter;

	private InventoryFilterTabContent _lastToggledContent;

	public bool toggleAllFlag;

	public List<InventoryFilterTabContent> filterContents => null;

	public List<InventoryFilterTab> multiFilterTabs => null;

	public MultiFilterTab multiFilterTabState => default(MultiFilterTab);

	public bool filterContentsActive => false;

	public int mirroredTabIdx { get; private set; }

	public bool allSelectContent { get; private set; }

	public void Init(InventoryFilterComponent.FilterTabOption option)
	{
	}

	private void Awake()
	{
	}

	private void UpdateScrollRectViewHeight()
	{
	}

	private void Update()
	{
	}

	public List<T> Filtering<T>(List<T> inventoryItems, InventoryFilterTab exclude = null)
	{
		return null;
	}

	public void Clear()
	{
	}

	public void ReleaseAllFilters()
	{
	}

	public void ToggleMultiFilterContentsActive()
	{
	}

	public void CloseFilterContentsRoot()
	{
	}

	public void SetMultiFilterTabState(List<InventoryFilterTabContent> activatedFilterContents = null)
	{
	}

	public void OnClick()
	{
	}

	public void ToggleFilterActive()
	{
	}

	public void SetMultiFilterActive(bool active)
	{
	}

	public List<InventoryFilterTab> GetActivatedMultiFilterTabs()
	{
		return null;
	}

	public List<InventoryFilterTabContent> GetActivatedFilterContents()
	{
		return null;
	}

	public void HandleContentToggled(InventoryFilterTabContent content)
	{
	}

	public void ReloadFilterElementCountText()
	{
	}

	public void RefreshWhenAllSelectTab(InventoryFilterTabContent from)
	{
	}
}
