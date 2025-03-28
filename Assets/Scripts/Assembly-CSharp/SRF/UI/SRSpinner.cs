using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.UI;

namespace SRF.UI
{
	[AddComponentMenu("SRF/UI/Spinner")]
	public class SRSpinner : Selectable, IDragHandler, IEventSystemHandler, IBeginDragHandler
	{
		[Serializable]
		public class SpinEvent : UnityEvent
		{
		}

		private float _dragDelta;

		[SerializeField]
		private SpinEvent _onSpinDecrement;

		[SerializeField]
		private SpinEvent _onSpinIncrement;

		public float DragThreshold;

		public SpinEvent OnSpinIncrement
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public SpinEvent OnSpinDecrement
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public void OnBeginDrag(PointerEventData eventData)
		{
		}

		public void OnDrag(PointerEventData eventData)
		{
		}

		private void OnIncrement(int amount)
		{
		}

		private void OnDecrement(int amount)
		{
		}
	}
}
