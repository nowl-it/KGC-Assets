using SRDebugger.UI.Other;
using SRF;
using UnityEngine;

namespace SRDebugger.UI.Tabs
{
	public class BugReportTabController : SRMonoBehaviourEx, IEnableTab
	{
		[RequiredField]
		public BugReportSheetController BugReportSheetPrefab;

		[RequiredField]
		public RectTransform Container;

		public bool IsEnabled => false;

		protected override void Start()
		{
		}

		private void TakingScreenshot()
		{
		}

		private void ScreenshotComplete()
		{
		}
	}
}
