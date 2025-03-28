using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Awesomepiece.Model;
using Cysharp.Threading.Tasks;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class PvPPanel : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass69_0
	{
		public PvPInfoResponseModel ret;

		public string themeText;

		public string difficultyText;

		public PvPPanel _003C_003E4__this;

		internal void _003CInit_003Eb__0(ConditionalImage x)
		{
		}

		internal void _003CInit_003Eb__2(Text x)
		{
		}

		internal void _003CInit_003Eb__3(Text x)
		{
		}

		internal bool _003CInit_003Eb__4(ResourceEventTrigger x)
		{
			return false;
		}
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CInit_003Ed__69 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public PvPPanel _003C_003E4__this;

		private _003C_003Ec__DisplayClass69_0 _003C_003E8__1;

		private UniTask<PvPInfoResponseModel>.Awaiter _003C_003Eu__1;

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
	private struct _003COnClickClearWinRewardReceived_003Ed__102 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public PvPPanel _003C_003E4__this;

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
	private struct _003COnClickSetWinCount_003Ed__101 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public InputField inputField;

		public PvPPanel _003C_003E4__this;

		private int _003Ccount_003E5__2;

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
	private struct _003COnClickTestResetDeckPool_003Ed__95 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

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
	private struct _003COnClickTestSetDormantTimeLeft_003Ed__94 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public int minuteLeft;

		public PvPPanel _003C_003E4__this;

		private UniTask<PvPInfoResponseModel>.Awaiter _003C_003Eu__1;

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
	private struct _003COnClickTraining_003Ed__100 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public PvPPanel _003C_003E4__this;

		private UniTask<bool>.Awaiter _003C_003Eu__1;

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
	private struct _003CPvpDormantProgress_003Ed__93 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public PvPPanel _003C_003E4__this;

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

	public static PvPPanel Instance;

	[ComponentConnect]
	public LeagueContentRankBox seasonRankBox;

	[SerializeField]
	private ConditionalGroup _grandArenaCond;

	[ComponentConnect]
	public List<Text> themeNameTexts;

	[ComponentConnect]
	public List<ConditionalImage> themeIcons;

	[ComponentConnect]
	public List<Text> difficultyTexts;

	[SerializeField]
	private ArenaWinRewardUI _arenaWinRewardUI;

	[SerializeField]
	private ImageTextPair _winRewardRedDot;

	[SerializeField]
	[Space(20f)]
	private Image _seasonEventTriggerRegionImage;

	[SerializeField]
	private ConditionalGroup _seasonEventTriggerRoleCond;

	[SerializeField]
	private ConditionalGroup _seasonEventTriggerCond;

	[SerializeField]
	private ConditionalGroup _deckSetButton;

	[SerializeField]
	private ImageTextPair _deckSetCostPair;

	[SerializeField]
	private ConditionalGroup _trainingButton;

	[Space(20f)]
	[ComponentConnect]
	public Button deckSetButton;

	[ComponentConnect]
	public Text deckSetButtonText;

	[ComponentConnect]
	public GameObject deckSetCostBox;

	[ComponentConnect]
	public Text deckSetRetryText;

	[ComponentConnect]
	public Price deckSetRetryCost;

	[ComponentConnect]
	public Button matchButton;

	[ComponentConnect]
	public GameObject levelLock;

	[ComponentConnect]
	public GameObject newRewardBadge;

	[GetComponent]
	[Space(20f)]
	public ConditionalGroup stateCond;

	[ComponentConnect]
	public CanvasGroup pvpLoadingPopup;

	private PvPRankingPanel _pvpRankingPanel;

	private PvPRewardPanel _pvpRewardPanel;

	private PvPLatestGamesLogPanel _pvpLatestGamesLogPanel;

	private PvPRetryConfirmPopup _pvpRetryConfirmPopup;

	private ArenaSeasonEventTriggerPanel _arenaSeasonEventTriggerPanel;

	public DeckPreviewPanel myDeckPanel;

	public ConditionalImage[] deckRecordItems;

	[Header("그랜드 아레나 관련")]
	[Space(20f)]
	[SerializeField]
	private Text _grandArenaInfoText;

	[SerializeField]
	private CanvasGroup _pvpDormantPanel;

	[SerializeField]
	private Text _pvpDormantPanelText;

	[SerializeField]
	private GameObject _grandArenaButton;

	[Space(20f)]
	[SerializeField]
	private GameObject _unitBundlePackage;

	private StartGrandArenaPanel _startGrandArenaPanel;

	private TerritoryBonusUnitTooltip _territoryBonusUnitTooltip;

	private ArenaTrainingInformationPanel _arenaTrainingInformationPanel;

	private DateTime _seasonUntilAt;

	private DateTime _nextSeasonStartAt;

	private bool _checkFetchNextSeasonStartAt;

	private bool _checkFetchSeasonUntilAt;

	private int _theme;

	private int _deckSettingDifficulty;

	private Tween _pvpDormantInfoTween;

	private ulong? _dormantTimer;

	public PvPRankingPanel pvpRankingPanel => null;

	public PvPRewardPanel pvpRewardPanel => null;

	public PvPLatestGamesLogPanel pvpLatestGamesLogPanel => null;

	public PvPRetryConfirmPopup pvpRetryConfirmPopup => null;

	public ArenaSeasonEventTriggerPanel arenaSeasonEventTriggerPanel => null;

	public StartGrandArenaPanel startGrandArenaPanel => null;

	public TerritoryBonusUnitTooltip territoryBonusUnitTooltip => null;

	public ArenaTrainingInformationPanel arenaTrainingInformationPanel => null;

	private bool _isArenaPreseason => false;

	private bool _isSemiSeasonBreakTime => false;

	private PvPInfoResponseModel _pvpData => null;

	public void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	[AsyncStateMachine(typeof(_003CInit_003Ed__69))]
	public void Init()
	{
	}

	public void Reload()
	{
	}

	public static int GetReceivableWinRewardCount()
	{
		return 0;
	}

	public void HandleSemiSeasonChanged()
	{
	}

	public void ReloadUnitBundlePackage()
	{
	}

	public void UpdateRemainTime()
	{
	}

	private static int GetDormantDecreaseScore(int score, int rank)
	{
		return 0;
	}

	public void Update()
	{
	}

	private void UpdateNextSeasonStartRemainTimeText()
	{
	}

	public void OnClickRetry()
	{
	}

	public void ShowRetryConfirmPopup(bool forceFreeRetry)
	{
	}

	public void OnClickDeckSet()
	{
	}

	public void OnClickMatch(bool training = false)
	{
	}

	private bool CheckMigratingPvPSeason()
	{
		return false;
	}

	private bool CheckPvPEnabled()
	{
		return false;
	}

	public void OnClickPvPRanking()
	{
	}

	public void OnClickPvPReward()
	{
	}

	public void ShowLoading(bool v)
	{
	}

	public void OnClickArenaShop()
	{
	}

	public void OnClickLatestGamesLogButton()
	{
	}

	public void OnClickPvpDormantInfo()
	{
	}

	public void OnClickGrandArenaInfo()
	{
	}

	[AsyncStateMachine(typeof(_003CPvpDormantProgress_003Ed__93))]
	private void PvpDormantProgress()
	{
	}

	[AsyncStateMachine(typeof(_003COnClickTestSetDormantTimeLeft_003Ed__94))]
	public void OnClickTestSetDormantTimeLeft(int minuteLeft)
	{
	}

	[AsyncStateMachine(typeof(_003COnClickTestResetDeckPool_003Ed__95))]
	public void OnClickTestResetDeckPool()
	{
	}

	public void OnClickTestSetArenaTimeLeft(int hourLeft)
	{
	}

	public void Hide()
	{
	}

	public void OnClickGrandArenaSeasonEventTrigger()
	{
	}

	public void OnClickRankingReward()
	{
	}

	[AsyncStateMachine(typeof(_003COnClickTraining_003Ed__100))]
	public void OnClickTraining()
	{
	}

	[AsyncStateMachine(typeof(_003COnClickSetWinCount_003Ed__101))]
	public void OnClickSetWinCount(InputField inputField)
	{
	}

	[AsyncStateMachine(typeof(_003COnClickClearWinRewardReceived_003Ed__102))]
	public void OnClickClearWinRewardReceived()
	{
	}
}
