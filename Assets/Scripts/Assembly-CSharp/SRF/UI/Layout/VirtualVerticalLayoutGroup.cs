using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.UI;

namespace SRF.UI.Layout
{
	[AddComponentMenu("SRF/UI/Layout/VerticalLayoutGroup (Virtualizing)")]
	public class VirtualVerticalLayoutGroup : LayoutGroup, IPointerClickHandler, IEventSystemHandler
	{
		[Serializable]
		public class SelectedItemChangedEvent : UnityEvent<object>
		{
		}

		[Serializable]
		private class Row
		{
			public object Data;

			public int Index;

			public RectTransform Rect;

			public StyleRoot Root;

			public IVirtualView View;
		}

		private readonly SRList<object> _itemList;

		private readonly SRList<int> _visibleItemList;

		private bool _isDirty;

		private SRList<Row> _rowCache;

		private ScrollRect _scrollRect;

		private int _selectedIndex;

		private object _selectedItem;

		[SerializeField]
		private SelectedItemChangedEvent _selectedItemChanged;

		private int _visibleItemCount;

		private SRList<Row> _visibleRows;

		public StyleSheet AltRowStyleSheet;

		public bool EnableSelection;

		public RectTransform ItemPrefab;

		public int RowPadding;

		public StyleSheet RowStyleSheet;

		public StyleSheet SelectedRowStyleSheet;

		public float Spacing;

		public bool StickToBottom;

		private float _itemHeight;

		public SelectedItemChangedEvent SelectedItemChanged
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public object SelectedItem
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override float minHeight => 0f;

		private ScrollRect ScrollRect => null;

		private bool AlignBottom => false;

		private bool AlignTop => false;

		private float ItemHeight => 0f;

		public void OnPointerClick(PointerEventData eventData)
		{
		}

		protected override void Awake()
		{
		}

		private void OnScrollRectValueChanged(Vector2 d)
		{
		}

		protected override void Start()
		{
		}

		protected override void OnEnable()
		{
		}

		protected void Update()
		{
		}

		protected void InvalidateItem(int itemIndex)
		{
		}

		protected void RefreshIndexCache()
		{
		}

		protected void ScrollUpdate()
		{
		}

		public override void CalculateLayoutInputVertical()
		{
		}

		public override void SetLayoutHorizontal()
		{
		}

		public override void SetLayoutVertical()
		{
		}

		private new void SetDirty()
		{
		}

		public void AddItem(object item)
		{
		}

		public void RemoveItem(object item)
		{
		}

		public void ClearItems()
		{
		}

		private Row GetRow(int forIndex)
		{
			return null;
		}

		private void RecycleRow(Row row)
		{
		}

		private void PopulateRow(int index, Row row)
		{
		}

		private Row CreateRow()
		{
			return null;
		}
	}
}
