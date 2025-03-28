using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ColosseumTarotAnnouncePanel : PopupPanel
{
	[CompilerGenerated]
	private sealed class _003CReloadImpl_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ColosseumTarotAnnouncePanel _003C_003E4__this;

		private WaitForSeconds _003CwaitForSeconds_003E5__2;

		private List<int> _003CchoiceTarotList_003E5__3;

		private List<int> _003CrandomTarotList_003E5__4;

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
		public _003CReloadImpl_003Ed__13(int _003C_003E1__state)
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

	private static ColosseumTarotAnnouncePanel _instance;

	[SerializeField]
	private List<ColosseumTarotItem> _tarotItems;

	private bool _inited;

	private bool _autoShowing;

	private Coroutine _reloadRoutine;

	public static ColosseumTarotAnnouncePanel Instance => null;

	public List<CommonData.ChoiceUserSelectorType> selectorTypes => null;

	public void Show(bool auto)
	{
	}

	public void AutoClose()
	{
	}

	public override bool Close()
	{
		return false;
	}

	private void Reload()
	{
	}

	[IteratorStateMachine(typeof(_003CReloadImpl_003Ed__13))]
	private IEnumerator ReloadImpl()
	{
		return null;
	}

	public override void OnClickClose()
	{
	}
}
