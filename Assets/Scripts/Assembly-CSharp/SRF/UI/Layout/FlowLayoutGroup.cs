using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace SRF.UI.Layout
{
	[AddComponentMenu("SRF/UI/Layout/Flow Layout Group")]
	public class FlowLayoutGroup : LayoutGroup
	{
		private readonly IList<RectTransform> _rowList;

		private float _layoutHeight;

		public bool ChildForceExpandHeight;

		public bool ChildForceExpandWidth;

		public float Spacing;

		protected bool IsCenterAlign => false;

		protected bool IsRightAlign => false;

		protected bool IsMiddleAlign => false;

		protected bool IsLowerAlign => false;

		public override void CalculateLayoutInputHorizontal()
		{
		}

		public override void SetLayoutHorizontal()
		{
		}

		public override void SetLayoutVertical()
		{
		}

		public override void CalculateLayoutInputVertical()
		{
		}

		public float SetLayout(float width, int axis, bool layoutInput)
		{
			return 0f;
		}

		private float CalculateRowVerticalOffset(float groupHeight, float yOffset, float currentRowHeight)
		{
			return 0f;
		}

		protected void LayoutRow(IList<RectTransform> contents, float rowWidth, float rowHeight, float maxWidth, float xOffset, float yOffset, int axis)
		{
		}

		public float GetGreatestMinimumChildWidth()
		{
			return 0f;
		}
	}
}
