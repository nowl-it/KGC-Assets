using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SRF;
using UnityEngine.UI;

namespace SRDebugger.UI.Controls
{
	public class ProfilerMemoryBlock : SRMonoBehaviourEx
	{
		[CompilerGenerated]
		private sealed class _003CCleanUp_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ProfilerMemoryBlock _003C_003E4__this;

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
			public _003CCleanUp_003Ed__8(int _003C_003E1__state)
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

		private float _lastRefresh;

		[RequiredField]
		public Text CurrentUsedText;

		[RequiredField]
		public Slider Slider;

		[RequiredField]
		public Text TotalAllocatedText;

		protected override void OnEnable()
		{
		}

		protected override void Update()
		{
		}

		public void TriggerRefresh()
		{
		}

		public void TriggerCleanup()
		{
		}

		[IteratorStateMachine(typeof(_003CCleanUp_003Ed__8))]
		private IEnumerator CleanUp()
		{
			return null;
		}
	}
}
