using System.Collections.Generic;
using UnityEngine;

public class InventorySortComponent : MonoBehaviour
{
	[SerializeField]
	private RectTransform _sortContentsRoot;

	[SerializeField]
	private InventorySortContent _sortContentPrefab;

	[SerializeField]
	private List<InventorySortContent> _sortContents;

	public IInventorySortFilterHandler inventorySortFilterHandler;

	public void Clear()
	{
	}

	public void Set(IInventorySortFilterHandler sortFilterHandler, int tabIndex, int index, string sortCategory)
	{
	}

	public InventorySortContent GetSortContent(int index)
	{
		return null;
	}
}
