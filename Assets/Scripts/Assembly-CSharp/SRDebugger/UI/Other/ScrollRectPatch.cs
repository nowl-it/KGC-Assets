using UnityEngine;
using UnityEngine.UI;

namespace SRDebugger.UI.Other
{
	[RequireComponent(typeof(ScrollRect))]
	[ExecuteInEditMode]
	public class ScrollRectPatch : MonoBehaviour
	{
		public RectTransform Content;

		public Mask ReplaceMask;

		public RectTransform Viewport;

		private void Awake()
		{
		}
	}
}
