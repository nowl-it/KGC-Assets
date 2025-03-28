using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class TypeTextComponent : MonoBehaviour
{
	public delegate void OnComplete();

	[CompilerGenerated]
	private sealed class _003CTypeText_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TypeTextComponent _003C_003E4__this;

		public string text;

		private int _003Clen_003E5__2;

		private float _003Cspeed_003E5__3;

		private List<string> _003Cstack_003E5__4;

		private int _003Ci_003E5__5;

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
		public _003CTypeText_003Ed__15(int _003C_003E1__state)
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

	[SerializeField]
	private float _defaultSpeed;

	private Text label;

	private string _currentText;

	private string _finalText;

	private string _preText;

	private Coroutine _typeTextCoroutine;

	private static readonly string[] _uguiSymbols;

	private static readonly string[] _uguiCloseSymbols;

	private OnComplete _onCompleteCallback;

	private void Init()
	{
	}

	public void Awake()
	{
	}

	public void SetPreText(string preText)
	{
	}

	public void SetText(string text, float speed = -1f)
	{
	}

	public void SkipTypeText()
	{
	}

	[IteratorStateMachine(typeof(_003CTypeText_003Ed__15))]
	public IEnumerator TypeText(string text)
	{
		return null;
	}

	private string ReplaceSpeed(string text)
	{
		return null;
	}

	public bool IsSkippable()
	{
		return false;
	}

	public void SetOnComplete(OnComplete onComplete)
	{
	}
}
