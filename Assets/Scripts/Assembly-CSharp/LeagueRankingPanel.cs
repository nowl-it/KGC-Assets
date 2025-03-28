using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Awesomepiece.Model;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class LeagueRankingPanel : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass12_0
	{
		public bool processed;

		public LeagueRankingPanel _003C_003E4__this;

		internal void _003CFetchRanking_003Eb__0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass13_0
	{
		public List<LeagueRankingData> items;

		internal void _003CShowRanking_003Eb__0(int idx, GameObject o)
		{
		}
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CFetchRanking_003Ed__12 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public LeagueRankingPanel _003C_003E4__this;

		private _003C_003Ec__DisplayClass12_0 _003C_003E8__1;

		private UniTask<LeagueRankingResponseModel>.Awaiter _003C_003Eu__1;

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
	private struct _003CShowRanking_003Ed__13 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public LeagueRankingPanel _003C_003E4__this;

		private _003C_003Ec__DisplayClass13_0 _003C_003E8__1;

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

	[ComponentConnect]
	public Text noRankingText;

	[ComponentConnect]
	public LeagueRankingItem myRankingItem;

	[ComponentConnect]
	public CanvasGroup rankingLoadingPopup;

	[SerializeField]
	private Text leagueTitleText;

	[SerializeField]
	private Text duringSeasonText;

	public UITableView tableView;

	public ClosableObject leagueRewardPanel;

	[SerializeField]
	public ResourceLeagueInfo.LeagueType type;

	private LeagueRankingResponseModel _rankingModel;

	private bool _inited;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	[AsyncStateMachine(typeof(_003CFetchRanking_003Ed__12))]
	public UniTask FetchRanking()
	{
		return default(UniTask);
	}

	[AsyncStateMachine(typeof(_003CShowRanking_003Ed__13))]
	private void ShowRanking()
	{
	}

	public void ShowLoading(bool v)
	{
	}

	public void OnClickRewardInfoButton()
	{
	}
}
