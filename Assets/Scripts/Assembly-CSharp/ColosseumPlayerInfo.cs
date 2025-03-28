using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class ColosseumPlayerInfo : MonoBehaviour
{
	public enum State
	{
		None = 0,
		Attack = 1,
		Defense = 2,
		Dual = 3
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CWaitUntilBattlePhaseEnd_003Ed__47 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

		public Action callback;

		private UniTask.Awaiter _003C_003Eu__1;

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

	private static readonly int DefaultKey;

	private static readonly int AbilityLevelUpKey;

	private static readonly int UnitMaxLevelKey;

	private static readonly int WinKey;

	private static readonly int LoseKey;

	private static readonly int ReadyKey;

	private static readonly int StartKey;

	private static readonly int EmoticonKey;

	private static readonly int AttackShowKey;

	private static readonly int AttackHideKey;

	private static readonly int DefenseShowKey;

	private static readonly int DefenseHideKey;

	private static readonly int DualShowKey;

	private static readonly int DualHideKey;

	private static readonly int UserinfoAnimWinResidualKey;

	private static readonly int UserinfoAnimLoseResidualKey;

	[SerializeField]
	private Animator _animator;

	[SerializeField]
	private ProfileAvatar _avatar;

	[SerializeField]
	private Text _playerNameText;

	[SerializeField]
	private Text _levelText;

	[SerializeField]
	private GameObject _currentViewObject;

	[SerializeField]
	private Transform _playerHpGroupRoot;

	[SerializeField]
	private Text _abilityLevelUpNotifyLevelText;

	[SerializeField]
	private Image _unitMaxLevelNotifyUnitAvatar;

	[SerializeField]
	private Image _winStreakImage;

	[SerializeField]
	private Text _winStreakCountText;

	[SerializeField]
	private ConditionalGroup _gameOverConditionals;

	[SerializeField]
	private Text _gameOverRankText;

	[SerializeField]
	private Image[] _unitLevelStarIcons;

	[SerializeField]
	private Image[] _unitLevelUpEffects;

	[SerializeField]
	private GameObject _emoticonObject;

	[SerializeField]
	private Image _emoticonImage;

	private BattleManager _battleManager;

	private ColosseumData _colosseumData;

	private Action _onAnimationEnd;

	private Sequence _emoticonSequence;

	private State _lastState;

	public void SetPlayer(ColosseumData colosseumData)
	{
	}

	public void ReloadAbilityLevel()
	{
	}

	public void ReloadLife()
	{
	}

	public void SetStateIcon(State state)
	{
	}

	public void SetAnimation(int key)
	{
	}

	public void ShowAbilityLevelUpNotify()
	{
	}

	public void ShowUnitMaxLevelNotify(int unitId, int skinId, int level)
	{
	}

	public void ShowReadyNotify()
	{
	}

	public void ShowCancelReadyNotify()
	{
	}

	[AsyncStateMachine(typeof(_003CWaitUntilBattlePhaseEnd_003Ed__47))]
	private UniTaskVoid WaitUntilBattlePhaseEnd(Action callback)
	{
		return default(UniTaskVoid);
	}

	public void ShowWinNotify()
	{
	}

	public void ShowLoseNotify()
	{
	}

	public void ReloadWinStreak()
	{
	}

	public void ShowEmoticon(ResourceEmoticon resEmoticon)
	{
	}

	public void SetOnAnimationEnd(Action onAnimationEnd)
	{
	}

	public void HandleAnimationEnd()
	{
	}

	public void HandleGameLose(int rank)
	{
	}

	public void SetCurrentView(bool isCurrentView)
	{
	}

	public void OnClick()
	{
	}

	public int CompareSortingOrder(ColosseumPlayerInfo otherInfo)
	{
		return 0;
	}
}
