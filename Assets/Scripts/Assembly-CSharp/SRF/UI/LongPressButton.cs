using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace SRF.UI
{
	[AddComponentMenu("SRF/UI/Long Press Button")]
	public class LongPressButton : Button
	{
		private bool _handled;

		[SerializeField]
		private ButtonClickedEvent _onLongPress;

		private bool _pressed;

		private float _pressedTime;

		public float LongPressDuration;

		public ButtonClickedEvent onLongPress
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override void OnPointerExit(PointerEventData eventData)
		{
		}

		public override void OnPointerDown(PointerEventData eventData)
		{
		}

		public override void OnPointerUp(PointerEventData eventData)
		{
		}

		public override void OnPointerClick(PointerEventData eventData)
		{
		}

		private void Update()
		{
		}
	}
}
