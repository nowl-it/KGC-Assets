using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.UI;

public class LongPressButton : Selectable, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IPointerExitHandler
{
	public float durationThreshold;

	public bool repeat;

	public float repeatInterval;

	public UnityEvent onLongPress;

	public UnityEvent onPointerDown;

	public UnityEvent onPointerUp;

	private bool isButtonPressed;

	private bool longPressTriggered;

	private float timePressStarted;

	private float timeInvokeStarted;

	protected override void OnEnable()
	{
	}

	private void Update()
	{
	}

	public new void OnPointerDown(PointerEventData eventData)
	{
	}

	public new void OnPointerUp(PointerEventData eventData)
	{
	}

	public new void OnPointerExit(PointerEventData eventData)
	{
	}
}
