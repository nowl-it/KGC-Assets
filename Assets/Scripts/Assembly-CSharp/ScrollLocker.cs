using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ScrollLocker : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
{
	public ScrollRect target;

	private bool _locked;

	public void OnPointerDown(PointerEventData eventData)
	{
	}

	public void OnPointerUp(PointerEventData eventData)
	{
	}
}
