using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.UI;

public class PressButton : MonoBehaviour, IPointerDownHandler, IEventSystemHandler
{
	public UnityEvent onDown;

	public Button button;

	public void OnPointerDown(PointerEventData eventData)
	{
	}
}
