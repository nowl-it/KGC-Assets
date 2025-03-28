using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace SRF.UI
{
	[AddComponentMenu("SRF/UI/SRNumberSpinner")]
	public class SRNumberSpinner : InputField
	{
		private double _currentValue;

		private double _dragStartAmount;

		private double _dragStep;

		public float DragSensitivity;

		public double MaxValue;

		public double MinValue;

		protected override void Awake()
		{
		}

		public override void OnPointerClick(PointerEventData eventData)
		{
		}

		public override void OnPointerDown(PointerEventData eventData)
		{
		}

		public override void OnPointerUp(PointerEventData eventData)
		{
		}

		public override void OnBeginDrag(PointerEventData eventData)
		{
		}

		public override void OnDrag(PointerEventData eventData)
		{
		}

		public override void OnEndDrag(PointerEventData eventData)
		{
		}
	}
}
