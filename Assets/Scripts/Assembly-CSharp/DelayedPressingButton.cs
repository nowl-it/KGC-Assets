using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;

public class DelayedPressingButton : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IPointerExitHandler
{
	public UnityEvent onDown;

	public UnityEvent onDelayedPressing;

	public float delay;

	private bool _pressing;

	private float _pressingTime;

	public void OnPointerDown(PointerEventData eventData)
	{
	}

	public void OnPointerUp(PointerEventData eventData)
	{
	}

	public void OnPointerExit(PointerEventData eventData)
	{
	}

	public void Update()
	{
	}
}
