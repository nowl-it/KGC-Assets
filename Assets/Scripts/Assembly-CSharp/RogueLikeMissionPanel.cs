using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Awesomepiece.Model;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class RogueLikeMissionPanel : MonoBehaviour, IClosable
{
	public enum SearchType
	{
		All = 0,
		InProgress = 1,
		Completed = 2,
		EndEnum = 3
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CFetchMissionStatistics_003Ed__20 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public RogueLikeMissionPanel _003C_003E4__this;

		private UniTask<RogueLikeMissionStatisticsResponseModel>.Awaiter _003C_003Eu__1;

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
	private struct _003CShow_003Ed__18 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public RogueLikeMissionPanel _003C_003E4__this;

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

	private static RogueLikeMissionPanel _instance;

	[SerializeField]
	private ConditionalLocalizedText _searchTypeConditional;

	[SerializeField]
	private Gauge _totalMissionCompleteGauge;

	[SerializeField]
	private Text _totalMissionCompleteProgressText;

	[SerializeField]
	private TabManager _tabManager;

	[SerializeField]
	private ConditionalGroup _statisticMode;

	[SerializeField]
	private UITableView _missionTableView;

	[SerializeField]
	private UITableView _statisticsTableView;

	[SerializeField]
	private CanvasGroup _statisticsViewLoadingPopup;

	private RogueLikeHiddenMissionItem _hiddenMissionItem;

	private List<MissionData> _missions;

	private SearchType _searchType;

	private List<(MissionData missionData, bool check)> _missionTableViewList;

	private List<(MissionStatisticsData statisticsData, bool complete)> _statisticsTableViewList;

	private bool _initialized;

	private static bool missionStatisticsFetch;

	public static RogueLikeMissionPanel Instance => null;

	[AsyncStateMachine(typeof(_003CShow_003Ed__18))]
	public UniTask Show()
	{
		return default(UniTask);
	}

	[AsyncStateMachine(typeof(_003CFetchMissionStatistics_003Ed__20))]
	private void FetchMissionStatistics()
	{
	}

	public void Reload()
	{
	}

	private void ReloadMission()
	{
	}

	public static bool CheckSearchType(MissionData missionData, SearchType searchType)
	{
		return false;
	}

	public static bool CheckSearchType((MissionStatisticsData statisticsData, bool complete) data, SearchType searchType)
	{
		return false;
	}

	private void ReloadStatistics()
	{
	}

	public void OnClickTab(int index)
	{
	}

	public bool Close()
	{
		return false;
	}

	public void OnClickClose()
	{
	}

	public void OnToggleSearchType()
	{
	}

	private void SetSearchType(SearchType searchType)
	{
	}

	public static int MissionSortFunc((MissionData missionData, bool check) mission1, (MissionData missionData, bool check) mission2)
	{
		return 0;
	}
}
