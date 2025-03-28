using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Awesomepiece.Model;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class LeagueHallOfFamePanel : MonoBehaviour, IClosable
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass16_0
	{
		public ColosseumRankingResponseModel rankingModel;

		internal void _003CShowRanking_003Eb__0(int idx, GameObject o)
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass16_1
	{
		public PvPRankingResponseModel rankingModel;

		internal void _003CShowRanking_003Eb__1(int idx, GameObject o)
		{
		}
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CFetchRanking_003Ed__17 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public LeagueHallOfFamePanel _003C_003E4__this;

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

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CShowRanking_003Ed__16 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public LeagueHallOfFamePanel _003C_003E4__this;

		private _003C_003Ec__DisplayClass16_0 _003C_003E8__1;

		private _003C_003Ec__DisplayClass16_1 _003C_003E8__2;

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

	[SerializeField]
	private LeagueHallOfFameItem[] _fameItems;

	[SerializeField]
	private Text _leagueTitleText;

	[SerializeField]
	private Text _duringSeasonText;

	[SerializeField]
	private Text _topNText;

	[SerializeField]
	private UITableView _colosseumTableView;

	[SerializeField]
	private UITableView _pvpTableView;

	[SerializeField]
	private GameObject[] _viewAnotherSeasonButtons;

	[SerializeField]
	private CanvasGroup _rankingLoadingPopup;

	private int _curSeason;

	private int _minSeason;

	private ResourceLeagueInfo.LeagueType _type;

	private readonly List<ColosseumRankingResponseModel> _colosseumRankingModels;

	private readonly List<PvPRankingResponseModel> _pvpRankingModels;

	private int _leagueSeason => 0;

	public void Show(ResourceLeagueInfo.LeagueType type)
	{
	}

	[AsyncStateMachine(typeof(_003CShowRanking_003Ed__16))]
	private void ShowRanking()
	{
	}

	[AsyncStateMachine(typeof(_003CFetchRanking_003Ed__17))]
	private UniTask FetchRanking()
	{
		return default(UniTask);
	}

	public void ShowLoading(bool v)
	{
	}

	public void OnClickViewAnotherSeasonButton(int dir)
	{
	}

	public void OnClickClose()
	{
	}

	public bool Close()
	{
		return false;
	}
}
