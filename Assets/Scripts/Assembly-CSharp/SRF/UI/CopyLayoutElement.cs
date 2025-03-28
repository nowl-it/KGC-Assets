using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace SRF.UI
{
	[RequireComponent(typeof(RectTransform))]
	[AddComponentMenu("SRF/UI/Copy Layout Element")]
	[ExecuteInEditMode]
	public class CopyLayoutElement : UIBehaviour, ILayoutElement
	{
		public bool CopyMinHeight;

		public bool CopyMinWidth;

		public bool CopyPreferredHeight;

		public bool CopyPreferredWidth;

		public RectTransform CopySource;

		public float PaddingMinHeight;

		public float PaddingMinWidth;

		public float PaddingPreferredHeight;

		public float PaddingPreferredWidth;

		public float preferredWidth => 0f;

		public float preferredHeight => 0f;

		public float minWidth => 0f;

		public float minHeight => 0f;

		public int layoutPriority => 0;

		public float flexibleHeight => 0f;

		public float flexibleWidth => 0f;

		public void CalculateLayoutInputHorizontal()
		{
		}

		public void CalculateLayoutInputVertical()
		{
		}
	}
}
