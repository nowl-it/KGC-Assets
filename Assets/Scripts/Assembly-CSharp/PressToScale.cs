using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class PressToScale : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IPointerExitHandler
{
	public Transform trans;

	private Button _button;

	public Vector2 pressScale;

	private Vector2 _originScale;

	private bool _pressed;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	public void SetOriginScale(Vector2 scale)
	{
	}

	public void Restore()
	{
	}

	public void OnPointerDown(PointerEventData eventData)
	{
	}

	public void OnPointerUp(PointerEventData eventData)
	{
	}

	public void OnPointerExit(PointerEventData eventData)
	{
	}
}
