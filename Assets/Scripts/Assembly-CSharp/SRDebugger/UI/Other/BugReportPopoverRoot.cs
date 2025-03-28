using SRF;
using UnityEngine;

namespace SRDebugger.UI.Other
{
	public class BugReportPopoverRoot : SRMonoBehaviourEx
	{
		[RequiredField]
		public CanvasGroup CanvasGroup;

		[RequiredField]
		public RectTransform Container;
	}
}
