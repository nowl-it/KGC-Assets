using SRDebugger.Scripts;
using SRF;
using UnityEngine;

namespace SRDebugger.UI
{
	public class DebugPanelRoot : SRMonoBehaviourEx
	{
		[RequiredField]
		public Canvas Canvas;

		[RequiredField]
		public CanvasGroup CanvasGroup;

		[RequiredField]
		public DebuggerTabController TabController;

		public void Close()
		{
		}

		public void CloseAndDestroy()
		{
		}
	}
}
