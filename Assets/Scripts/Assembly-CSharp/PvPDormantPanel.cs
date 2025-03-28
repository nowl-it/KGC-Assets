using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class PvPDormantPanel : MonoBehaviour, IClosable
{
	[CompilerGenerated]
	private sealed class _003CRepresent_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PvPDormantPanel _003C_003E4__this;

		public int rankScore;

		private Color _003Ccolor_003E5__2;

		private ResourceRankTier _003CnewTier_003E5__3;

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
		public _003CRepresent_003Ed__18(int _003C_003E1__state)
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

	[ComponentConnect]
	public LerpText rankScoreText;

	[ComponentConnect]
	public Text deltaText;

	[ComponentConnect]
	public Text tierText;

	[ComponentConnect]
	public Image tierTextEffect;

	[ComponentConnect]
	public Image tierIcon;

	[ComponentConnect]
	public Image tierIconEffect;

	[ComponentConnect]
	public Image starIcon;

	[ComponentConnect]
	public Image starIconEffect;

	[ComponentConnect]
	public Text descText;

	[GetComponent]
	public ConditionalRootGroup condGroup;

	[ComponentConnect]
	public CanvasGroup confirmButton;

	public LerpText dormantTimeText;

	public LerpText decreaseScoreText;

	private int _decreasedScore;

	private int _newTier;

	private int _originTier;

	private DateTime _dormantStartedAt;

	private bool _closedByClick;

	public void Show(int decreasedScore, DateTime dormantStartedAt)
	{
	}

	[IteratorStateMachine(typeof(_003CRepresent_003Ed__18))]
	private IEnumerator Represent(int rankScore)
	{
		return null;
	}

	public void OnClickClose()
	{
	}

	public bool Close()
	{
		return false;
	}
}
