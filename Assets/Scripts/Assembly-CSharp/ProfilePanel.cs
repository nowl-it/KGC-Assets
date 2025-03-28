using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Awesomepiece.Model;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class ProfilePanel : MonoBehaviour, IClosable
{
	public enum Tab
	{
		Invasion = 0,
		EventMode = 1,
		RogueLike = 2,
		Babel = 3,
		None = 4
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003COnClickClanBox_003Ed__66 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public ProfilePanel _003C_003E4__this;

		private UniTask<ClanResponseModel>.Awaiter _003C_003Eu__1;

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
	private struct _003CShowOther_003Ed__50 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public ProfilePanel _003C_003E4__this;

		public string defaultCastleName;

		public string defaultUserName;

		public int accountId;

		private UniTask<OtherPlayerDataResponseModel>.Awaiter _003C_003Eu__1;

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

	[GetComponent]
	public CanvasGroup canvasGroup;

	[ComponentConnect]
	public CanvasGroup nameBox;

	[ComponentConnect]
	public Text winRecordText;

	[ComponentConnect]
	public Text heroCountText;

	[ComponentConnect]
	public Text currentAltarText;

	[ComponentConnect]
	public Text missionDescText;

	[ComponentConnect]
	public UITableView tableView;

	[ComponentConnect("TableView", true)]
	public RectTransform tableViewTransform;

	[ComponentConnect]
	public GameObject missionBox;

	[ComponentConnect]
	public Text levelText;

	[ComponentConnect]
	public Gauge expGauge;

	[ComponentConnect]
	public GameObject deckBox;

	[ComponentConnect]
	public GameObject rankingBox;

	[ComponentConnect]
	public Image profileIconSetting;

	[ComponentConnect]
	public PlayerProfile playerProfile;

	[ComponentConnect]
	public RectTransform infoArea;

	[ComponentConnect]
	public CanvasGroup loadingPopup;

	[ComponentConnect]
	public GameObject clanInfoBox;

	[ComponentConnect]
	public ClanMark clanMark;

	[ComponentConnect]
	public Text clanNameText;

	[ComponentConnect]
	public Text clanRoleText;

	[ComponentConnect]
	public TabManager challengeTab;

	public Image[] borderClanInfo;

	public ConditionalGroup godSkinCond;

	public UnitIllust profileIconIllust;

	public Button bgCloseButton;

	public Text[] levelsGridShort;

	public GameObject[] chapterSection;

	public Text[] levelsGridLongScroll;

	public UIFitter[] _invasionRecordUiFitters;

	public Text[] weeklyRankings;

	public CardPreviewItem[] cardItems;

	public GameObject dailyAttendanceButton;

	public Text accountCreatedAtText;

	public GameObject challengeScroll;

	public GameObject chapterScroll;

	public Scrollbar chapterScrollBar;

	public GridLayoutGroup challengeGridLayoutGroup;

	private Tab _challengeType;

	public SelectHardThemeTab[] rankingTabs;

	private int _rankingType;

	private OtherPlayerDataResponseModel _otherPlayerInfo;

	private bool _isOtherPlayerInfo;

	private int _infoRequestedId;

	private static Dictionary<int, OtherPlayerDataResponseModel> _cachedOtherPlayerInfoData;

	public void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	public void Show()
	{
	}

	public void ShowOther(RankingResponseModel.RankingData rankingData)
	{
	}

	[AsyncStateMachine(typeof(_003CShowOther_003Ed__50))]
	public void ShowOther(int accountId, string defaultUserName = "", string defaultCastleName = "")
	{
	}

	private void ShowImpl(bool other)
	{
	}

	public bool Close()
	{
		return false;
	}

	public void ReloadMission()
	{
	}

	public void Reload()
	{
	}

	public void ReloadChallenge()
	{
	}

	public void ReloadRanking()
	{
	}

	private void ReloadAccountCreatedAtDate()
	{
	}

	private void ReloadProfileIcon(GameManager.ProfileUIInfo profileInfo)
	{
	}

	private bool CheckShowCondition(ResourceMission resMission)
	{
		return false;
	}

	public void OnClickClose()
	{
	}

	public void OnClickChallengeTab(int idx)
	{
	}

	public void OnClickRankingTab(int idx)
	{
	}

	public void SetTabsSortingFalse()
	{
	}

	public void RevertTabsSorting()
	{
	}

	public void ShowLoading(bool v)
	{
	}

	[AsyncStateMachine(typeof(_003COnClickClanBox_003Ed__66))]
	public void OnClickClanBox()
	{
	}

	public void OnClickDailyAttendance()
	{
	}
}
