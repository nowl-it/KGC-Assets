using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class RogueLikeGameOverPanel : MonoBehaviour
{
	public struct RogueLikeGameOverPanelData
	{
		public bool win;

		public int challengeLevel;

		public int floor;

		public int addExp;

		public int addGold;

		public int beforeLevel;

		public int beforeExp;

		public int score;

		public int addSeasonalEventToken;

		public int addPassPoint;

		public int hotTimeBonusValue;

		public int addClanPoint;
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass35_0
	{
		public int displayExp;

		public int needExp;

		public Func<bool> _003C_003E9__2;

		internal void _003CShowAnim_003Eb__1(int v)
		{
		}

		internal bool _003CShowAnim_003Eb__2()
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass40_0
	{
		public RogueLikeGameOverPanel _003C_003E4__this;

		public bool processed;

		internal void _003COnClickToNextFloor_003Eb__0()
		{
		}

		internal void _003COnClickToNextFloor_003Eb__1()
		{
		}
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003COnClickToNextFloor_003Ed__40 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public RogueLikeGameOverPanel _003C_003E4__this;

		private _003C_003Ec__DisplayClass40_0 _003C_003E8__1;

		private UniTask<Awesomepiece.Model.StartRogueLikeFloorResponseModel>.Awaiter _003C_003Eu__1;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[CompilerGenerated]
	private sealed class _003CShowAnim_003Ed__35 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public RogueLikeGameOverPanel _003C_003E4__this;

		private _003C_003Ec__DisplayClass35_0 _003C_003E8__1;

		private int _003Clevel_003E5__2;

		private int _003Cexp_003E5__3;

		private int _003CaddExp_003E5__4;

		private IEnumerator<Transform> _003C_003E7__wrap4;

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
		public _003CShowAnim_003Ed__35(int _003C_003E1__state)
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

		private void _003C_003Em__Finally1()
		{
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	private static RogueLikeGameOverPanel _instance;

	[SerializeField]
	private ConditionalGroup _winConditionals;

	[SerializeField]
	private LayoutFitter _layoutFitter;

	[SerializeField]
	private Text _challengeText;

	[SerializeField]
	private Text _floorText;

	[SerializeField]
	private Text _resultText;

	[SerializeField]
	private CanvasGroup _expGuageCanvasGroup;

	[SerializeField]
	private Gauge _expGauge;

	[SerializeField]
	private Text _levelText;

	[SerializeField]
	private Text _maxLevelText;

	[SerializeField]
	private Text _lvUpEffect;

	[SerializeField]
	private Text _lvUpEffect2;

	[SerializeField]
	private CanvasGroup _rewardDescBoxCanvasGroup;

	[SerializeField]
	private Text _chapterRewardDesc;

	[SerializeField]
	private Text _challengeRewardDesc;

	[SerializeField]
	private CanvasGroup _rewardBoxItemsRootCanvasGroup;

	[SerializeField]
	private RewardBoxItem _rewardBoxItemPrefab;

	[SerializeField]
	private CanvasGroup _scorePanelCanvasGroup;

	[SerializeField]
	private Text _scoreText;

	[SerializeField]
	private Transform _buttonsRoot;

	[SerializeField]
	private Button _confirmButton;

	[SerializeField]
	private Text _currentHeartText;

	[SerializeField]
	private Button _toNextFloorButton;

	[SerializeField]
	private Text _toNextFloorButtonText;

	[SerializeField]
	private TextFitter _toNextFloorTextFitter;

	[SerializeField]
	private Button _saveAndQuitButton;

	private RogueLikeGameOverPanelData _data;

	private Sequence _lvUpEffectSeq;

	private int _rewardBoxCount;

	private bool _setBG;

	public static RogueLikeGameOverPanel Instance => null;

	private void SetBG()
	{
	}

	public void Show(RogueLikeGameOverPanelData data)
	{
	}

	[IteratorStateMachine(typeof(_003CShowAnim_003Ed__35))]
	public IEnumerator ShowAnim()
	{
		return null;
	}

	private void ShowLevelUp(int level)
	{
	}

	private void AddRewardBoxItem(RewardBoxItem.Type type, int id, int value, int hotTimeBonusValue = 0)
	{
	}

	private void Close()
	{
	}

	public void OnClickConfirm()
	{
	}

	[AsyncStateMachine(typeof(_003COnClickToNextFloor_003Ed__40))]
	public void OnClickToNextFloor()
	{
	}
}
