using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.EventSystems;

public class FieldViewButton : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IPointerExitHandler
{
	public CanvasGroup canvasGroup;

	private List<Tweener> _tweeners;

	private int _originCamPos;

	public static bool active { get; private set; }

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void OnPointerDown(PointerEventData eventData)
	{
	}

	private void Release()
	{
	}

	public void OnPointerUp(PointerEventData eventData)
	{
	}

	public void OnPointerExit(PointerEventData eventData)
	{
	}

	private void OnApplicationFocus(bool hasFocus)
	{
	}
}
