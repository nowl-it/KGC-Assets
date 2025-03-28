using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectItemPanel : MonoBehaviour
{
	public SelectItem[] items;

	[ComponentConnect]
	public Border ribbon;

	[ComponentConnect]
	public Text countText;

	[ComponentConnect("CountText", false)]
	public ConditionalTextColor countTextCond;

	public Text timeLimitText;

	public ItemInfoOptionBox[] options;

	public LayoutFitter optionTooltip;

	public RectTransform optionTooltipRectTransform;

	public ClickOutsideClose clickOutsideClose;

	private List<Item> _itemPool;

	private Action<List<Item>> _callback;

	private void Update()
	{
	}

	public void Show(List<Item> itemPool, Action<List<Item>> callback)
	{
	}

	private int GetSelectedCount()
	{
		return 0;
	}

	public void OnClickItem(int idx)
	{
	}

	public void OnClickConfirm()
	{
	}

	public void Close()
	{
	}

	private void ShowOptions(Item item, Vector3 itemPosition)
	{
	}
}
