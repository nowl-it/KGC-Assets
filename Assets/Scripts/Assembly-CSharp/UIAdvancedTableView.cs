using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIAdvancedTableView : MonoBehaviour
{
	[Header("Row")]
	public GameObject prefab;

	public int defaultRowHeight;

	public int spacing;

	[Header("Scroll")]
	public bool scrollable;

	public bool vertical;

	public Scrollbar scrollBar;

	public bool usingScrollRectEx;

	[Header("Masking")]
	public bool masking;

	public bool showMaskGraphic;

	[Header("Min Size")]
	public bool adjustMinSize;

	public int minSize;

	private RectTransform _rectTransform;

	private RectTransform _contentView;

	private List<GameObject> _cells;

	private List<GameObject> _recycleCells;

	private Action<int, GameObject> _onInit;

	private Func<int, int> _onHeight;

	private Action<int> _onClick;

	private bool _initialized;

	private int _start;

	private int _end;

	private Vector2 _size;

	private List<object> _items;

	public int start => 0;

	public int end => 0;

	public virtual void Awake()
	{
	}

	public void Initialize<T>(List<T> items, Action<int, GameObject> onInit = null, Func<int, int> onHeight = null, Action<int> onClick = null, Action onValueChanged = null)
	{
	}

	public void Reload()
	{
	}

	private int GetIndex(float pos)
	{
		return 0;
	}

	private int GetRowHeight(int idx)
	{
		return 0;
	}

	private void OnScrollUpdated()
	{
	}

	private int GetPos(int idx)
	{
		return 0;
	}

	private int GetSize()
	{
		return 0;
	}

	private void Refresh(int newStart, int newEnd)
	{
	}

	public void UpdateSize()
	{
	}

	public GameObject FindItem(Func<GameObject, bool> condition)
	{
		return null;
	}

	public void ScrollsToTop()
	{
	}

	public void ScrollsToBottom()
	{
	}

	public void ScrollsToTopTween()
	{
	}

	public void ScrollsToBottomTween()
	{
	}

	public bool IsScrollTop(float gap = 10f)
	{
		return false;
	}

	public bool IsScrollBottom(float gap = 10f)
	{
		return false;
	}

	public void ScrollsToTargetVertical(int idx)
	{
	}
}
