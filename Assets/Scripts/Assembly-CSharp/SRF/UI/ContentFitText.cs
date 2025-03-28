using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace SRF.UI
{
	[ExecuteInEditMode]
	[RequireComponent(typeof(RectTransform))]
	[AddComponentMenu("SRF/UI/Content Fit Text")]
	public class ContentFitText : UIBehaviour, ILayoutElement
	{
		public SRText CopySource;

		public Vector2 Padding;

		public float minWidth => 0f;

		public float preferredWidth => 0f;

		public float flexibleWidth => 0f;

		public float minHeight => 0f;

		public float preferredHeight => 0f;

		public float flexibleHeight => 0f;

		public int layoutPriority => 0;

		public void CalculateLayoutInputHorizontal()
		{
		}

		public void CalculateLayoutInputVertical()
		{
		}

		protected override void OnEnable()
		{
		}

		private void CopySourceOnLayoutDirty(SRText srText)
		{
		}

		protected override void OnTransformParentChanged()
		{
		}

		protected override void OnDisable()
		{
		}

		protected override void OnDidApplyAnimationProperties()
		{
		}

		protected override void OnBeforeTransformParentChanged()
		{
		}

		protected void SetDirty()
		{
		}
	}
}
