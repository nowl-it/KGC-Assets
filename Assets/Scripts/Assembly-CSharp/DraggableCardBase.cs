using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public abstract class DraggableCardBase<T> : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IDragHandler, IEndDragHandler
{
	public bool canDrag;

	[SerializeField]
	[Tooltip("UnitPrefab의 부모 오브젝트(= UnitObj)")]
	protected Transform _dragTargetRoot;

	[SerializeField]
	[Tooltip("드래그 시 지정할 UnitObj의 부모 오브젝트")]
	private Transform _draggingObjectRoot;

	private (Transform parent, int siblingIndex) _draggingObjectOriginRoot;

	protected T _data;

	protected IDraggableCardBaseHandler<T> _draggableCardBaseHandler;

	protected bool _isDragging;

	protected int _baseSortingOrder;

	protected ScrollRect _parentScrollRect;

	public T data => default(T);

	public virtual void OnBeginDrag(PointerEventData eventData)
	{
	}

	public virtual void OnDrag(PointerEventData eventData)
	{
	}

	public virtual void OnEndDrag(PointerEventData eventData)
	{
	}

	public virtual void SetBaseSortingOrder(int order)
	{
	}

	public void SetDraggableCardBaseHandler(IDraggableCardBaseHandler<T> handler)
	{
	}

	public abstract void Reload();

	protected abstract void OnBeginDrag(Vector2 mousePosition);

	protected abstract void OnDrag(Vector2 mousePosition);

	protected abstract void OnEndDrag(Vector2 mousePosition);

	protected abstract void SetDragTargetSortingOrder(int order);

	protected abstract void OnDragIntoSlot([NotNull] DraggableCardBase<T> toCard, int fromIndex, int toIndex);

	protected abstract void OnSwapCard([NotNull] DraggableCardBase<T> toCard, int fromIndex, int toIndex);

	public abstract void Restore();

	protected abstract void OnUnEquip(int fromIndex);
}
