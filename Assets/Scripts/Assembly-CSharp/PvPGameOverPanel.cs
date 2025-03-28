using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class PvPGameOverPanel : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CRepresent_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PvPGameOverPanel _003C_003E4__this;

		public int addRankPoint;

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
		public _003CRepresent_003Ed__22(int _003C_003E1__state)
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
	public Text myNameText;

	[ComponentConnect]
	public LerpText myScoreText;

	[ComponentConnect]
	public Image myGauge;

	[ComponentConnect]
	public Text enemyNameText;

	[ComponentConnect]
	public LerpText enemyScoreText;

	public GameObject _arenaTrainingAlertText;

	public ConditionalRoot[] scoreItems;

	[ComponentConnect]
	public Text resultText;

	[ComponentConnect]
	public Text totalPointText;

	[ComponentConnect]
	public LerpText addRankScoreText;

	[GetComponent]
	public ConditionalRootGroup condGroup;

	[ComponentConnect]
	public CanvasGroup confirmButton;

	[ComponentConnect]
	public PlayerProfile myProfile;

	[ComponentConnect]
	public PlayerProfile enemyProfile;

	[ComponentConnect]
	public PvPScoreResultPanel scoreResultPanel;

	[SerializeField]
	private ArenaWinRewardUI _arenaWinRewardUI;

	[SerializeField]
	private ConditionalGroup _earlyAccessModeCond;

	private int _score;

	private int _addGold;

	private int _newTier;

	private List<(int stage, bool win)> _effectQueue;

	public void Show(int score, int addRankPoint, int rankScore, int tier, int addArenaToken, bool isTraining)
	{
	}

	[IteratorStateMachine(typeof(_003CRepresent_003Ed__22))]
	private IEnumerator Represent(int addRankPoint, int addArenaToken)
	{
		return null;
	}

	public void OnClickClose()
	{
	}

	public void RegisterScore(int stage, bool win)
	{
	}

	private void ReloadGauge(int myScore, int enemyScore)
	{
	}
}
