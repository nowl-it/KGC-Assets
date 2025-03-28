using System;
using System.Diagnostics;
using System.Net.WebSockets;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Awesomepiece.Model;
using Cysharp.Threading.Tasks;
using Protocol;
using UnityEngine;
using UnityEngine.UI;

public class ColosseumPanel : MonoBehaviour
{
	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CInit_003Ed__54 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public ColosseumPanel _003C_003E4__this;

		private UniTask<PlayerColosseumInfoResponseModel>.Awaiter _003C_003Eu__1;

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
	private struct _003COnClickTestColosseumFreeMatching_003Ed__66 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public InputField input;

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
	private struct _003COnClickTestColosseumSinglePlay_003Ed__65 : IAsyncStateMachine
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

	public static ColosseumPanel Instance;

	[SerializeField]
	private Button _customMatchButton;

	[SerializeField]
	private LeagueContentRankBox _seasonRankBox;

	[SerializeField]
	private ColosseumOpenEventPanel _openEventPanel;

	[SerializeField]
	private Text _openEventMissionClearedCountBadgeText;

	[SerializeField]
	private CanvasGroup _loadingObject;

	[SerializeField]
	private DeckPreviewPanel _deckPreviewPanel;

	[SerializeField]
	private Button _matchStartButton;

	[SerializeField]
	private Text _matchStartButtonText;

	[SerializeField]
	private GameObject _levelLock;

	[SerializeField]
	private UnitBalanceInfoPanel _unitBalanceInfo;

	[SerializeField]
	private ColosseumDailyRewardIcon _colosseumDailyReward;

	[SerializeField]
	private GameObject _colosseumRankRewardButton;

	[SerializeField]
	private GameObject _newRewardBadge;

	[SerializeField]
	private GameObject _nextSeasonObj;

	[SerializeField]
	private Text _nextSeasonRemainTeme;

	public ColosseumCustomMatchLobbyPanel _colosseumCustomMatchLobbyPanel;

	private ColosseumOpenEventMissionPanel _colosseumOpenEventMissionPanel;

	private ColosseumRankingPanel _colosseumRankingPanel;

	private ColosseumCustomMatchPanel _colosseumCustomMatchPanel;

	private PvPRewardPanel _colosseumRewardPanel;

	private DateTime _seasonUntilAt;

	private DateTime _nextSeasonStartAt;

	private bool _checkFetchNextSeasonStartAt;

	private bool _checkFetchSeasonUntilAt;

	private IDisposable _pingPongTimer;

	public Button customMatchButton => null;

	public Button unitBalanceInfoTotalAreaButton => null;

	public Button unitBalanceInfoStatAreaButton => null;

	public Button unitBalanceInfoPopupButton => null;

	public bool isColosseumOpenEventMissionPanelInstantiated => false;

	public ColosseumCustomMatchLobbyPanel colosseumCustomMatchLobbyPanel => null;

	public ColosseumOpenEventMissionPanel colosseumOpenEventMissionPanel => null;

	public bool colosseumOpenEventMissionPanelInstantiated => false;

	public ColosseumRankingPanel colosseumRankingPanel => null;

	public ColosseumCustomMatchPanel colosseumCustomMatchPanel => null;

	public PvPRewardPanel colosseumRewardPanel => null;

	private bool _isColosseumPreSeason => false;

	private bool _isSemiSeasonBreakTime => false;

	private void Awake()
	{
	}

	private void Update()
	{
	}

	private void OnDestroy()
	{
	}

	[AsyncStateMachine(typeof(_003CInit_003Ed__54))]
	public void Init()
	{
	}

	public void HandleSemiSeasonChanged()
	{
	}

	public void ReloadDeck()
	{
	}

	public void ShowLoading(bool v)
	{
	}

	public void OnClickStartColosseum()
	{
	}

	public void SetMatchStartButtonInteractable(bool v)
	{
	}

	public void ReloadOpenEventMissionPanel()
	{
	}

	public void Hide()
	{
	}

	public void ReloadColosseumOpenEventMissionPanelClearedMissionCountBadge()
	{
	}

	public void ReloadColosseumOpenMission()
	{
	}

	public void OnClickColosseumOpenEventMissionPanelButton()
	{
	}

	[AsyncStateMachine(typeof(_003COnClickTestColosseumSinglePlay_003Ed__65))]
	public void OnClickTestColosseumSinglePlay()
	{
	}

	[AsyncStateMachine(typeof(_003COnClickTestColosseumFreeMatching_003Ed__66))]
	public void OnClickTestColosseumFreeMatching(InputField input)
	{
	}

	public void OnClickColosseumRanking()
	{
	}

	public void OnClickArenaShop()
	{
	}

	public void OnClickCustomMatch()
	{
	}

	private bool CheckColosseumEnabled()
	{
		return false;
	}

	public void DispatchCustomMatchBinaryWebSocketEvent(Packet packet)
	{
	}

	public void DispatchCustomMatchWebSocketEvent(BaseMessage baseMessage)
	{
	}

	public void DisposePingPongTimer()
	{
	}

	public void OnCustomMatchWebSocketClosed(WebSocketCloseStatus? closeStatus)
	{
	}

	public void OnClickColosseumReward()
	{
	}

	public void ReloadNewRewardBadge()
	{
	}

	private void UpdateNextSeasonStartRemainTimeText()
	{
	}
}
