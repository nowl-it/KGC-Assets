using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(LimitVisibleCharacters))]
[RequireComponent(typeof(Text))]
public class Typewriter : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CPlayTypewriter_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Typewriter _003C_003E4__this;

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
		public _003CPlayTypewriter_003Ed__10(int _003C_003E1__state)
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

	public float delayBetweenSymbols;

	public AudioClip[] typeSoundEffects;

	public AudioSource audioSourceForTypeEffect;

	private float _timer;

	private LimitVisibleCharacters _limitVisibleCharactersComponent;

	private Text _textComponent;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	[IteratorStateMachine(typeof(_003CPlayTypewriter_003Ed__10))]
	private IEnumerator PlayTypewriter()
	{
		return null;
	}
}
