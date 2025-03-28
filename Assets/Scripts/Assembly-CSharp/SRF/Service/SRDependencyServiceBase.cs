using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SRF.Service
{
	public abstract class SRDependencyServiceBase<T> : SRServiceBase<T>, IAsyncService where T : class
	{
		[CompilerGenerated]
		private sealed class _003CLoadDependencies_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public SRDependencyServiceBase<T> _003C_003E4__this;

			private Type[] _003C_003E7__wrap1;

			private int _003C_003E7__wrap2;

			private IAsyncService _003Ca_003E5__4;

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
			public _003CLoadDependencies_003Ed__8(int _003C_003E1__state)
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

		private bool _isLoaded;

		protected abstract Type[] Dependencies { get; }

		public bool IsLoaded => false;

		[Conditional("ENABLE_LOGGING")]
		private void Log(string msg, UnityEngine.Object target)
		{
		}

		protected override void Start()
		{
		}

		protected virtual void OnLoaded()
		{
		}

		[IteratorStateMachine(typeof(SRDependencyServiceBase<>._003CLoadDependencies_003Ed__8))]
		private IEnumerator LoadDependencies()
		{
			return null;
		}
	}
}
