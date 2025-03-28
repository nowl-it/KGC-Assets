using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace SRF.UI
{
	[AddComponentMenu("SRF/UI/Flash Graphic")]
	[ExecuteInEditMode]
	public class FlashGraphic : UIBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
	{
		public float DecayTime;

		public Color DefaultColor;

		public Color FlashColor;

		public Graphic Target;

		public void OnPointerDown(PointerEventData eventData)
		{
		}

		public void OnPointerUp(PointerEventData eventData)
		{
		}

		protected override void OnEnable()
		{
		}

		protected void Update()
		{
		}

		public void Flash()
		{
		}
	}
}
