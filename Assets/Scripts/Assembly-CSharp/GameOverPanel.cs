using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Awesomepiece.Model;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class GameOverPanel : MonoBehaviour
{
	public class GameOverPanelData
	{
		public bool win;

		public bool newRecord;

		public bool newThemeClear;

		public int beforeLevel;

		public int beforeExp;

		public int addGold;

		public int adBonusGold;

		public int adBonusRemainCount;

		public int addExp;

		public int ppRewardCount;

		public int difficulty;

		public int foodBoosterLevel;

		public List<int> artifactIds;

		public List<int> artifactRewardCounts;

		public List<AccessoryModel> accessoryModels;

		public int addPassPoint;

		public List<int> addCardExpCardIds;

		public List<int> addCardExpCounts;

		public int addSeasonalEventToken;

		public int eventDifficulty;

		public int hotTimeBonusValue;

		public int addClanPoint;

		public int addHardModeToken;
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass48_0
	{
		public bool processed;

		internal void _003CGiveAdBonusReward_003Eb__0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass59_0
	{
		public GameOverPanel _003C_003E4__this;

		public int theme;

		public bool processed;

		internal void _003CContinueGame_003Eb__3(BuyResponseModel _)
		{
		}

		internal void _003CContinueGame_003Eb__4(UseInventoryResponseModel _)
		{
		}

		internal void _003CContinueGame_003Eb__0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass60_0
	{
		public bool processed;

		public GameStartResponseModel ret;

		internal void _003CRestartGame_003Eb__0()
		{
		}

		internal void _003CRestartGame_003Eb__1(bool yes)
		{
		}
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CContinueGame_003Ed__59 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

		public GameOverPanel _003C_003E4__this;

		private _003C_003Ec__DisplayClass59_0 _003C_003E8__1;

		private Scene_Game _003Cscene_003E5__2;

		private int _003C_003E7__wrap2;

		private UniTask<GameStartResponseModel>.Awaiter _003C_003Eu__1;

		private UniTask<bool>.Awaiter _003C_003Eu__2;

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

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CGiveAdBonusReward_003Ed__48 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public GameOverPanel _003C_003E4__this;

		private _003C_003Ec__DisplayClass48_0 _003C_003E8__1;

		private UniTask<ResponseModel>.Awaiter _003C_003Eu__1;

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

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CRestartGame_003Ed__60 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

		public GameOverPanel _003C_003E4__this;

		private _003C_003Ec__DisplayClass60_0 _003C_003E8__1;

		private int[] _003CeliteLevels_003E5__2;

		private int _003Cdifficulty_003E5__3;

		private UniTask<GameStartResponseModel>.Awaiter _003C_003Eu__1;

		private UniTask<bool>.Awaiter _003C_003Eu__2;

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

	[SerializeField]
	[Space(20f)]
	private Text _resultText;

	[SerializeField]
	private Text _stageText;

	[SerializeField]
	private Text _themeText;

	[SerializeField]
	private Text _difficultyText;

	[Space(20f)]
	[SerializeField]
	private RectTransform _rankingScoreBox;

	[SerializeField]
	private Text _rankingScoreText;

	[SerializeField]
	[Space(20f)]
	private GameObject _levelUpEffectGroup;

	[SerializeField]
	private Gauge _expGauge;

	[SerializeField]
	private Text _levelText;

	[SerializeField]
	private Text _maxLevelText;

	[Space(20f)]
	[SerializeField]
	private LayoutFitter _rewardDescFitter;

	[SerializeField]
	private Text _rewardText;

	[SerializeField]
	private GameObject _bonusRewardArea;

	[SerializeField]
	[Space(20f)]
	private Button _adBonusButton;

	[SerializeField]
	private Text _adBonusGoldText;

	[SerializeField]
	private Text _adBonusRemainCountText;

	[SerializeField]
	private ConditionalGroup _adCond;

	[Space(20f)]
	[SerializeField]
	private GameOverRewardBoxPanel _rewardBoxPanel;

	[SerializeField]
	private RewardBoxItem _rewardBoxItemPrefab;

	[SerializeField]
	private Transform _rewardBoxItemsLayoutTransform;

	[SerializeField]
	private GameObject _rewardBoxArea;

	[SerializeField]
	[Space(20f)]
	private CanvasGroup _cardExpBox;

	[SerializeField]
	private CardPreviewItem[] _cardExpItems;

	[Space(20f)]
	[SerializeField]
	private GameOverGuideObject _gameOverGuideObject;

	[SerializeField]
	private Button _continueButton;

	[SerializeField]
	private ConditionalGroup _continueButtonCond;

	[SerializeField]
	private Text _continueButtonText;

	[SerializeField]
	private Text _costCountText;

	[SerializeField]
	private Text _costConsumeCount;

	[SerializeField]
	private List<ConditionalGroup> _costImages;

	[Space(20f)]
	[SerializeField]
	private ConditionalRootGroup _winConditionalGroup;

	[SerializeField]
	private Transform _underRewardBoxPanelRect;

	[SerializeField]
	private BuyItemPanel_Voucher _buyItemPanel;

	[SerializeField]
	private Button _animationBlocker;

	[SerializeField]
	private List<UIFitter> _fitters;

	[SerializeField]
	private PassBenefitMessageObj_Simple _passBenefitObj;

	[SerializeField]
	private ConditionalGroup _earlyAccessModeCond;

	private GameOverPanelData _data;

	[NonSerialized]
	public List<RewardBoxItem> rewardBoxItems;

	private bool _continueOrRestartGameRequested;

	private bool _canEventModeContinue;

	private bool _canNormalModeReplay;

	public static readonly int Trigger;

	public Transform underRewardBoxPanelRect => null;

	public void Show(GameOverPanelData data)
	{
	}

	public void Fit()
	{
	}

	public void OnClickAdBonus()
	{
	}

	[AsyncStateMachine(typeof(_003CGiveAdBonusReward_003Ed__48))]
	private void GiveAdBonusReward()
	{
	}

	public void OnClickClose()
	{
	}

	public void OnClickContinue()
	{
	}

	public void ShowLevelUp()
	{
	}

	public void ShowRewardAnimation()
	{
	}

	public void OnClickRegisterPvPDeckPool()
	{
	}

	public void AddRewardBoxItem(RewardBoxItem.Type type, int id, int value, int hotTimeValue = 0)
	{
	}

	private void AddRewardBoxItem(AccessoryModel accessoryModel)
	{
	}

	private void ReloadEventModeContinueUI(int theme)
	{
	}

	private void ReloadNormalModeReplayUI()
	{
	}

	[AsyncStateMachine(typeof(_003CContinueGame_003Ed__59))]
	private UniTaskVoid ContinueGame()
	{
		return default(UniTaskVoid);
	}

	[AsyncStateMachine(typeof(_003CRestartGame_003Ed__60))]
	public UniTaskVoid RestartGame()
	{
		return default(UniTaskVoid);
	}

	public void EndAnimation()
	{
	}

	public void SkipAnimation()
	{
	}
}
