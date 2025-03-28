using System.Collections.Generic;

public class TreasureSortState : SortState
{
	public new readonly string[] SortCategories;

	public override void Sort<T>(int index, List<T> elements, bool desc = false)
	{
	}

	public override void Sort<T>(string category, List<T> elements, bool desc = false)
	{
	}

	public override string[] GetSortCategories()
	{
		return null;
	}
}
