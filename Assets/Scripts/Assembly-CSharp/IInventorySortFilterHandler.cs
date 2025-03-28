using System.Collections.Generic;

public interface IInventorySortFilterHandler
{
	void DoFiltering();

	InventoryFilterComponent GetActivatedFilterComponent();

	InventoryPanel.InventoryCategory GetInventoryCategory();

	T GetCurrentInventoryItems<T>();

	List<T> GetAllInventoryItems<T>();

	void HandleInitSortComponent();

	void SortItemsByIdx(int tabIdx, int sortIdx);

	InventorySortComponent GetActivatedSortComponent();
}
