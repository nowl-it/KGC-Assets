using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.UI;

public class SwipeHandler : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IDragHandler, IBeginDragHandler, IEndDragHandler
{
	[SerializeField]
	private UnityEvent _onSwipeLeft;

	[SerializeField]
	private UnityEvent _onSwipeRight;

	[SerializeField]
	private float _swipeDistance;

	[SerializeField]
	private bool _controlButtonInteractable;

	private Vector2 _dragStartPos;

	[SerializeField]
	private Button _button;

	private Action<PointerEventData> _onBeginDragCallback;

	private Action<PointerEventData> _onDragCallback;

	private Action<PointerEventData> _onEndDragCallback;

	private void Start()
	{
	}

	public void OnPointerDown(PointerEventData eventData)
	{
	}

	public void OnPointerUp(PointerEventData eventData)
	{
	}

	public void OnDrag(PointerEventData eventData)
	{
	}

	public void OnBeginDrag(PointerEventData eventData)
	{
	}

	public void OnEndDrag(PointerEventData eventData)
	{
	}

	public void SetOnDragCallback(Action<PointerEventData> beginCallback, Action<PointerEventData> dragCallback, Action<PointerEventData> endCallback)
	{
	}
}
