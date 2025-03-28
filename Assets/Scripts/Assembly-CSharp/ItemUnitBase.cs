using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ItemUnitBase : GameUnit
{
	[CompilerGenerated]
	private sealed class _003CIdleSequenceCoroutine_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ItemUnitBase _003C_003E4__this;

		private float _003Cv_003E5__2;

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
		public _003CIdleSequenceCoroutine_003Ed__4(int _003C_003E1__state)
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

	public SpriteRenderer spriteRenderer;

	protected Coroutine _idleSequence;

	public void Init(int battleManagerIdx = 0)
	{
	}

	protected virtual void IdleSequencing()
	{
	}

	[IteratorStateMachine(typeof(_003CIdleSequenceCoroutine_003Ed__4))]
	protected virtual IEnumerator IdleSequenceCoroutine()
	{
		return null;
	}

	public override void BeginDrag()
	{
	}

	public override void EndDrag()
	{
	}

	public virtual void SetSpriteOrder(int order)
	{
	}
}
