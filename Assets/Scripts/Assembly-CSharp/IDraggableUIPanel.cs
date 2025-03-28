using UnityEngine.EventSystems;

public interface IDraggableUIPanel
{
	void OnBeginDragDraggableUI(PointerEventData eventData, DraggableUI draggableUI);

	void OnDragDraggableUI(PointerEventData eventData, DraggableUI draggableUI);

	void OnEndDragDraggableUI(PointerEventData eventData, DraggableUI draggableUI);
}
