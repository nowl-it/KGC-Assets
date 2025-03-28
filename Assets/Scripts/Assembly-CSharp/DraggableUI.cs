using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DraggableUI : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IDragHandler, IEndDragHandler
{
	public struct DragArea
	{
		public RectTransform rectTransform;

		public Action<GameObject> onDragIn;

		public DragArea(RectTransform rect, Action<GameObject> onDragIn)
		{
			rectTransform = null;
			this.onDragIn = null;
		}
	}

	[SerializeField]
	private bool _rotateOnDrag;

	[SerializeField]
	private RectTransform _dragTarget;

	[SerializeField]
	private RectTransform _parentTransformOnDrag;

	protected bool _isDragging;

	private Vector3 _originDragTargetPos;

	private Transform _originDragTargetParent;

	private PressToScale _pressToScale;

	private IDraggableUIPanel _draggableUIPanel;

	private List<DragArea> _dragAreas;

	public bool canDrag { get; set; }

	protected virtual void Awake()
	{
	}

	public void SetDraggableUIPanel(IDraggableUIPanel _panel)
	{
	}

	public virtual void OnBeginDrag(PointerEventData eventData)
	{
	}

	public virtual void OnDrag(PointerEventData eventData)
	{
	}

	public virtual void OnEndDrag(PointerEventData eventData)
	{
	}

	protected void OnDisable()
	{
	}

	public void EndDrag()
	{
	}

	public void SetDragAreas(List<DragArea> dragAreas)
	{
	}
}
