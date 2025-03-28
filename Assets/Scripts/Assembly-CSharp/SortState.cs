using System.Collections.Generic;

public abstract class SortState
{
	public readonly string[] SortCategories;

	public abstract void Sort<T>(int index, List<T> elements, bool desc = false);

	public abstract void Sort<T>(string category, List<T> elements, bool desc = false);

	public virtual string[] GetSortCategories()
	{
		return null;
	}
}
