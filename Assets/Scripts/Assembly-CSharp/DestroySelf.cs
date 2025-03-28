using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class DestroySelf : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CByeWithParticles_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public DestroySelf _003C_003E4__this;

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
		public _003CByeWithParticles_003Ed__7(int _003C_003E1__state)
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

	public bool withParent;

	public bool hasParticle;

	public ResourceSkill.Effect resEffect;

	private Coroutine _byeWithParticlesRoutine;

	private Action _onBye;

	private void Awake()
	{
	}

	public void Bye()
	{
	}

	[IteratorStateMachine(typeof(_003CByeWithParticles_003Ed__7))]
	private IEnumerator ByeWithParticles()
	{
		return null;
	}

	public void Hide()
	{
	}

	public void SetOnBye(Action onBye)
	{
	}
}
