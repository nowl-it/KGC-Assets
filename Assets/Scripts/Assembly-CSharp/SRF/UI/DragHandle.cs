using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace SRF.UI
{
	public class DragHandle : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IEndDragHandler, IDragHandler
	{
		private CanvasScaler _canvasScaler;

		private float _delta;

		private float _startValue;

		public RectTransform.Axis Axis;

		public bool Invert;

		public float MaxSize;

		public LayoutElement TargetLayoutElement;

		public RectTransform TargetRectTransform;

		private float Mult => 0f;

		public void OnBeginDrag(PointerEventData eventData)
		{
		}

		public void OnDrag(PointerEventData eventData)
		{
		}

		public void OnEndDrag(PointerEventData eventData)
		{
		}

		private void Start()
		{
		}

		private bool Verify()
		{
			return false;
		}

		private float GetCurrentValue()
		{
			return 0f;
		}

		private void SetCurrentValue(float value)
		{
		}

		private void CommitCurrentValue()
		{
		}

		private float GetMinSize()
		{
			return 0f;
		}

		private float GetMaxSize()
		{
			return 0f;
		}
	}
}
