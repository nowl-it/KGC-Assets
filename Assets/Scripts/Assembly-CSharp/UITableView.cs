using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UITableView : MonoBehaviour
{
	public enum HierarchyPolicy
	{
		Normal = 0,
		Reverse = 1
	}

	public delegate void ItemDelegate(int index, GameObject obj);

	public delegate void OnClickDelegate(int index);

	public RectOffset padding;

	public HierarchyPolicy hierarchyPolicy;

	protected RectTransform _contentView;

	protected List<GameObject> _cells;

	protected bool _initialized;

	protected int _count;

	protected ItemDelegate _delegate;

	protected OnClickDelegate _onClick;

	protected int _start;

	protected int _end;

	protected Vector2 _size;

	public GameObject prefab;

	public int rowHeight;

	public bool vertical;

	public Scrollbar scrollBar;

	public bool masking;

	public bool showMaskGraphic;

	public bool scrollable;

	public bool usingScrollRectEx;

	private RectTransform _rectTransform;

	private List<GameObject> _recycleCells;

	public RectTransform contentView => null;

	public int count => 0;

	public RectTransform rectTransform => null;

	public virtual void Awake()
	{
	}

	public void ScrollsToTop()
	{
	}

	public void ScrollsToBottom()
	{
	}

	public void ScrollsToIndex(int index)
	{
	}

	public void StopScroll()
	{
	}

	public virtual void Initialize(int count, ItemDelegate @delegate = null, OnClickDelegate onClick = null)
	{
	}

	public virtual void ReloadData()
	{
	}

	public void Reload(int count)
	{
	}

	protected void OnScrollUpdated()
	{
	}

	protected virtual void Refresh(int newStart, int newEnd)
	{
	}

	public void UpdateSize()
	{
	}

	public GameObject FindItem(Func<GameObject, bool> condition)
	{
		return null;
	}

	public GameObject GetItemByIndex(int index)
	{
		return null;
	}
}
