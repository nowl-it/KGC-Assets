using UnityEngine;
using UnityEngine.UI;

public class InventorySortContent : MonoBehaviour
{
	[SerializeField]
	private GameObject _selectedObj;

	[SerializeField]
	private Text _sortCategoryText;

	private int _tabIndex;

	private int _index;

	private bool _set;

	private bool _desc;

	private InventorySortComponent _parent;

	private string _sortCategory;

	public string sortCategory => null;

	public void Set(InventorySortComponent parent, int tabIndex, int index, string sortCategory)
	{
	}

	public void OnClickSort(bool force = false)
	{
	}

	public void SortSetting(bool set)
	{
	}
}
