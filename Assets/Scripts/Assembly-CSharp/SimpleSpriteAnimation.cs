using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class SimpleSpriteAnimation : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CAnim_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SimpleSpriteAnimation _003C_003E4__this;

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
		public _003CAnim_003Ed__8(int _003C_003E1__state)
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

	public Sprite[] sprites;

	public float interval;

	public float loopTerm;

	[SerializeField]
	private SpriteRenderer _spriteRenderer;

	[SerializeField]
	private Image _image;

	private int _idx;

	private Coroutine _coroutine;

	public void Start()
	{
	}

	[IteratorStateMachine(typeof(_003CAnim_003Ed__8))]
	private IEnumerator Anim()
	{
		return null;
	}

	public void Play()
	{
	}

	public void Stop()
	{
	}
}
