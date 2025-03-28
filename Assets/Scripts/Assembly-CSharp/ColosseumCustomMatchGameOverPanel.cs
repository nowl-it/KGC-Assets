using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class ColosseumCustomMatchGameOverPanel : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CRepresent_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ColosseumCustomMatchGameOverPanel _003C_003E4__this;

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
		public _003CRepresent_003Ed__11(int _003C_003E1__state)
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

	private static ColosseumCustomMatchGameOverPanel _instance;

	[SerializeField]
	private ProfileAvatar _profileAvatar;

	[SerializeField]
	private Text _rankText;

	[SerializeField]
	private Text _resultText;

	[SerializeField]
	private CanvasGroup _buttonsCanvasGroup;

	[SerializeField]
	private GameObject _observeButton;

	[SerializeField]
	private Button _reportButton;

	private ColosseumGameOverPanel.ColosseumGameOverData _data;

	public static ColosseumCustomMatchGameOverPanel Instance => null;

	public void Show(ColosseumGameOverPanel.ColosseumGameOverData data)
	{
	}

	[IteratorStateMachine(typeof(_003CRepresent_003Ed__11))]
	private IEnumerator Represent()
	{
		return null;
	}

	private (string, string) GetResultTextAndSound()
	{
		return default((string, string));
	}

	public void Close()
	{
	}

	public void OnClickConfirm()
	{
	}
}
