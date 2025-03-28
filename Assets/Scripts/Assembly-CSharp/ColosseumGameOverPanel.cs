using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class ColosseumGameOverPanel : MonoBehaviour
{
	public class ColosseumGameOverData
	{
		public int rank;

		public int lifeLeft;

		public int survivedRound;

		public int addedToken;

		public bool isWin;

		public int score;

		public int addedScore;

		public int tier;
	}

	[CompilerGenerated]
	private sealed class _003CRepresent_003Ed__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ColosseumGameOverPanel _003C_003E4__this;

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
		public _003CRepresent_003Ed__20(int _003C_003E1__state)
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

	private static ColosseumGameOverPanel _instance;

	[SerializeField]
	private Animator _profileAnimator;

	[SerializeField]
	private ProfileAvatar _profileAvatar;

	[SerializeField]
	private Text _rankText;

	[SerializeField]
	private PvPScoreResultPanel _scoreResultPanel;

	[SerializeField]
	private LerpText _tokenRewardText;

	[SerializeField]
	private FlexibleUIElements _rewardItemElements;

	[SerializeField]
	private Text _currentHeartText;

	[SerializeField]
	private CanvasGroup _buttonsCanvasGroup;

	[SerializeField]
	private GameObject _observeButton;

	[SerializeField]
	private GameObject _reportButton;

	public bool buyProcessing;

	private ColosseumGameOverData _data;

	private ResourceColosseumRankTier _resTier;

	private int _rewardCount;

	public static ColosseumGameOverPanel Instance => null;

	public void Show(ColosseumGameOverData data)
	{
	}

	private void SetRewardItem(int index, GameObject go, ColosseumGameOverPanelRewardItem item)
	{
	}

	[IteratorStateMachine(typeof(_003CRepresent_003Ed__20))]
	private IEnumerator Represent()
	{
		return null;
	}

	public void Close()
	{
	}

	public void OnClickObserve()
	{
	}

	public void OnClickConfirm()
	{
	}

	public void ReloadHeartText()
	{
	}

	public void OnClickReport()
	{
	}
}
