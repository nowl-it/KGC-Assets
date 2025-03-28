using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class PreButtonHandler : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IEndDragHandler, IDragHandler, IPointerDownHandler, IPointerUpHandler
{
	private Canvas _canvas;

	private EarlyAccessModeClickableObject _downedEarlyAccessModeClickableObject;

	private Selectable _downedSelectable;

	private PressToScale _currentPressToScale;

	private ButtonSound _currentButtonSound;

	private IBeginDragHandler _beginDragHandler;

	private IDragHandler _dragHandler;

	private IEndDragHandler _endDragHandler;

	private void OnEnable()
	{
	}

	public void OnPointerDown(PointerEventData eventData)
	{
	}

	public void OnPointerUp(PointerEventData eventData)
	{
	}

	public void OnBeginDrag(PointerEventData eventData)
	{
	}

	public void OnDrag(PointerEventData eventData)
	{
	}

	public void OnEndDrag(PointerEventData eventData)
	{
	}
}
