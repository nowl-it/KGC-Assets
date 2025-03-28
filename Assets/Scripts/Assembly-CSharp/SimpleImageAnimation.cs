using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class SimpleImageAnimation : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CAnim_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SimpleImageAnimation _003C_003E4__this;

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
		public _003CAnim_003Ed__11(int _003C_003E1__state)
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

	public bool loop;

	public bool destroyOnEnd;

	public bool playOnAwake;

	public bool playOnEnable;

	private Image _image;

	private int _idx;

	private Coroutine _coroutine;

	private bool _toPlay;

	public void Awake()
	{
	}

	[IteratorStateMachine(typeof(_003CAnim_003Ed__11))]
	private IEnumerator Anim()
	{
		return null;
	}

	public void Play()
	{
	}

	private void OnEnable()
	{
	}

	public void Stop()
	{
	}
}
