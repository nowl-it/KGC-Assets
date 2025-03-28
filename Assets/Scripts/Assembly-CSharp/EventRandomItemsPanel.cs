using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EventRandomItemsPanel : MonoBehaviour
{
	public SelectItem[] items;

	[ComponentConnect]
	public Border ribbon;

	[ComponentConnect]
	public Text countText;

	[ComponentConnect("CountText", false)]
	public ConditionalTextColor countTextCond;

	private int _count;

	private List<Item> _itemPool;

	private int[][] _tables;

	public void Show(int count)
	{
	}

	private int GetItemTier(int tier)
	{
		return 0;
	}

	public void SetResult()
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
}
