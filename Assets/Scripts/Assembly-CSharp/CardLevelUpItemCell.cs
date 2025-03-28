using System;
using UnityEngine;
using UnityEngine.UI;

public class CardLevelUpItemCell : MonoBehaviour
{
	[SerializeField]
	private Image _iconImage;

	[SerializeField]
	private Text _countText;

	[SerializeField]
	private ConditionalSetActive _selectedConditional;

	[SerializeField]
	private ConditionalSetActive _inActiveSelectedConditional;

	[SerializeField]
	private GameObject[] _locked;

	private ResourceInventoryItem _resItem;

	private Action _onClick;

	private bool _isLocked;

	public ResourceInventoryItem resItem => null;

	public void Set(ResourceInventoryItem resItem, Action onClick)
	{
	}

	public void SetCount(int count)
	{
	}

	public void SetLocked(bool locked, int itemCount)
	{
	}

	public void SetSelected(bool selected)
	{
	}

	public void OnClick()
	{
	}
}
