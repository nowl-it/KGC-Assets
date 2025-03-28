using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SRDebugger.Services;
using UnityEngine;

namespace SRDebugger.Internal
{
	public class BugReportApi
	{
		[CompilerGenerated]
		private sealed class _003CSubmit_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public BugReportApi _003C_003E4__this;

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
			public _003CSubmit_003Ed__19(int _003C_003E1__state)
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

		private readonly string _apiKey;

		private readonly BugReport _bugReport;

		private bool _isBusy;

		private WWW _www;

		public bool IsComplete { get; private set; }

		public bool WasSuccessful { get; private set; }

		public string ErrorMessage { get; private set; }

		public float Progress => 0f;

		public BugReportApi(BugReport report, string apiKey)
		{
		}

		[IteratorStateMachine(typeof(_003CSubmit_003Ed__19))]
		public IEnumerator Submit()
		{
			return null;
		}

		private void SetCompletionState(bool wasSuccessful)
		{
		}

		private static string BuildJsonRequest(BugReport report)
		{
			return null;
		}

		private static IList<IList<string>> CreateConsoleDump()
		{
			return null;
		}
	}
}
