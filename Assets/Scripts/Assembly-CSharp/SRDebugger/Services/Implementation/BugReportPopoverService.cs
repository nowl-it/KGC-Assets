using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SRDebugger.UI.Other;
using SRF.Service;

namespace SRDebugger.Services.Implementation
{
	[Service(typeof(BugReportPopoverService))]
	public class BugReportPopoverService : SRServiceBase<BugReportPopoverService>
	{
		[CompilerGenerated]
		private sealed class _003COpenCo_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public bool takeScreenshot;

			public BugReportPopoverService _003C_003E4__this;

			public string descriptionText;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003COpenCo_003Ed__7(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		private BugReportCompleteCallback _callback;

		private bool _isVisible;

		private BugReportPopoverRoot _popover;

		private BugReportSheetController _sheet;

		public bool IsShowingPopover => false;

		public void ShowBugReporter(BugReportCompleteCallback callback, bool takeScreenshotFirst = true, string descriptionText = null)
		{
		}

		[IteratorStateMachine(typeof(_003COpenCo_003Ed__7))]
		private IEnumerator OpenCo(bool takeScreenshot, string descriptionText)
		{
			return null;
		}

		private void SubmitComplete(bool didSucceed, string errorMessage)
		{
		}

		private void CancelPressed()
		{
		}

		private void OnComplete(bool success, string errorMessage, bool close)
		{
		}

		private void TakingScreenshot()
		{
		}

		private void ScreenshotComplete()
		{
		}

		protected override void Awake()
		{
		}

		private void Load()
		{
		}
	}
}
