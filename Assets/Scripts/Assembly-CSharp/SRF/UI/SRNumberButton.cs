using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace SRF.UI
{
	[AddComponentMenu("SRF/UI/SRNumberButton")]
	public class SRNumberButton : Button, IPointerClickHandler, IEventSystemHandler, IPointerDownHandler, IPointerUpHandler
	{
		private const float ExtraThreshold = 3f;

		public const float Delay = 0.4f;

		private float _delayTime;

		private float _downTime;

		private bool _isDown;

		public double Amount;

		public SRNumberSpinner TargetField;

		public override void OnPointerDown(PointerEventData eventData)
		{
		}

		public override void OnPointerUp(PointerEventData eventData)
		{
		}

		protected virtual void Update()
		{
		}

		private void Apply()
		{
		}
	}
}
