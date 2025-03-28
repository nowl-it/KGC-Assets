using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Awesomepiece.Model;
using UnityEngine;
using UnityEngine.UI;

public class ColosseumTarotSelectPanel : PopupPanel
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass24_0
	{
		public ColosseumTarotSelectPanel _003C_003E4__this;

		public int lastPickedIndex;

		public List<int> indexes;

		public float startTime;

		internal bool _003CReloadRandomRound_003Eb__1(ColosseumTarotItem x)
		{
			return false;
		}

		internal bool _003CReloadRandomRound_003Eb__2()
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003CReloadRandomRound_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ColosseumTarotSelectPanel _003C_003E4__this;

		private _003C_003Ec__DisplayClass24_0 _003C_003E8__1;

		private WaitForSeconds _003CwaitForSeconds_003E5__2;

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
		public _003CReloadRandomRound_003Ed__24(int _003C_003E1__state)
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

	private static ColosseumTarotSelectPanel _instance;

	[SerializeField]
	private Animator _animator;

	[SerializeField]
	private CanvasGroup _canvasGroup;

	[SerializeField]
	private GameObject _randomRoundTitleObj;

	[SerializeField]
	private GameObject _selectRoundTitleObj;

	[SerializeField]
	private PlayerProfile _choiceUserProfile;

	[SerializeField]
	private Text _choiceUserSelectorTypeText;

	[SerializeField]
	private List<ColosseumTarotItem> _tarotItems;

	private ColosseumPlayerDataResponseModel.ColosseumPlayerData _choiceUserData;

	private CommonData.ChoiceUserSelectorType _choiceUserSelectorType;

	private List<ResourceColosseumTarot> _randomTarotPool;

	private ResourceColosseumTarot _randomRoundTarot;

	private bool _canClose;

	private bool _isRandom;

	private int _lastSelectedTarotIdx;

	public static ColosseumTarotSelectPanel Instance => null;

	public void Show(SetTarotPhaseMessage setTarotPhaseMessage)
	{
	}

	private void Reload()
	{
	}

	public void HandleUserPreferred(int tarotId, string userId)
	{
	}

	public void OnClickSelectTarotItem(int tarotId)
	{
	}

	public void ChoicePhaseEnd(int tarotId)
	{
	}

	private bool IsChoiceUser(string userId = null)
	{
		return false;
	}

	public void HandleChoiceTarot(int tarotId)
	{
	}

	[IteratorStateMachine(typeof(_003CReloadRandomRound_003Ed__24))]
	private IEnumerator ReloadRandomRound()
	{
		return null;
	}

	public override bool Close()
	{
		return false;
	}
}
