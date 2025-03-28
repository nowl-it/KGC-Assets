using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DevColosseumItemPanel : MonoBehaviour
{
	public Dropdown filterDropdown;

	public ScrollRect scrollRect;

	public GameObject itemObject;

	private List<GameObject> list;

	public InputField searchInput;

	private const int INVADE_ITEM = 0;

	private const int ABILITY = 1;

	private const int TAROT = 2;

	private const int TAROT_POOL = 3;

	private const int SELECTOR_POOL = 4;

	private int _type;

	private List<int> _selectedTarotPool;

	private List<int> _selectedSelectorPool;

	public void Init()
	{
	}

	public void Reload()
	{
	}

	public void Show(int type)
	{
	}

	public void OnClickClearSearch()
	{
	}

	public void OnChangeSearch()
	{
	}

	public void OnClickItem(int id, bool close = true)
	{
	}

	private void SetSelected(int id, bool value)
	{
	}

	private void Update()
	{
	}

	public void Close()
	{
	}
}
