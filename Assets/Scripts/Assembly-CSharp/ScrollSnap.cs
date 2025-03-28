using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[RequireComponent(typeof(ScrollRect))]
public class ScrollSnap : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IEndDragHandler
{
	public delegate void OnSelected(int idx);

	public delegate void OnScrollSelected(int idx);

	[CompilerGenerated]
	private sealed class _003Ctest_003Ed__25 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ScrollSnap _003C_003E4__this;

		public int idx;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003Ctest_003Ed__25(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	public RectTransform rectTransform;

	public RectTransform content;

	public int snapWidth;

	public float snappingPoint;

	public float scrollSpeed;

	private OnSelected _callback;

	private OnScrollSelected _scrollCallback;

	private bool _dragging;

	private bool _moving;

	private float _goalPosition;

	private int _index;

	private int _contentCount;

	private UITableView _uiTableView;

	public int index => 0;

	public void Start()
	{
	}

	public void Update()
	{
	}

	public void SetCallback(OnSelected callback)
	{
	}

	public void SetScrollCallback(OnScrollSelected callback)
	{
	}

	public void Reload()
	{
	}

	public void OnBeginDrag(PointerEventData eventData)
	{
	}

	public void OnEndDrag(PointerEventData eventData)
	{
	}

	public void SetIndex(int idx)
	{
	}

	[IteratorStateMachine(typeof(_003Ctest_003Ed__25))]
	private IEnumerator test(int idx)
	{
		return null;
	}
}
