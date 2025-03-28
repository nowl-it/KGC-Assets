using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Awesomepiece.Model;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class ClanRankingPanel : MonoBehaviour, IClosable
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass15_0
	{
		public ClanRankingResponseModel model;

		internal void _003COnClickTab_003Eb__0(int idx, GameObject o)
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass15_1
	{
		public ClanPointRankingResponseModel model;

		internal void _003COnClickTab_003Eb__1(int idx, GameObject o)
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass16_0
	{
		public bool processed;

		public ClanRankingPanel _003C_003E4__this;

		internal void _003CFetchClanRanking_003Eb__0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass17_0
	{
		public bool processed;

		public ClanRankingPanel _003C_003E4__this;

		internal void _003CFetchPointRanking_003Eb__0()
		{
		}
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CFetchClanRanking_003Ed__16 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public ClanRankingPanel _003C_003E4__this;

		private _003C_003Ec__DisplayClass16_0 _003C_003E8__1;

		private UniTask<ClanRankingResponseModel>.Awaiter _003C_003Eu__1;

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
	private struct _003CFetchPointRanking_003Ed__17 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public ClanRankingPanel _003C_003E4__this;

		public int index;

		private _003C_003Ec__DisplayClass17_0 _003C_003E8__1;

		private UniTask<ClanPointRankingResponseModel>.Awaiter _003C_003Eu__1;

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
	private struct _003COnClickTab_003Ed__15 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public int idx;

		public ClanRankingPanel _003C_003E4__this;

		private _003C_003Ec__DisplayClass15_0 _003C_003E8__1;

		private _003C_003Ec__DisplayClass15_1 _003C_003E8__2;

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
	public TabManager tabManager;

	[ComponentConnect]
	public CanvasGroup rankingLoadingPopup;

	[ComponentConnect]
	public Text noRankingText;

	[ComponentConnect]
	public Text rankTierName;

	public UITableView battleTableView;

	public UITableView pointTableView;

	public Text top100Text;

	[ComponentConnect]
	public ClanRankingItem myClanRankingItem;

	[ComponentConnect]
	public ClanPointRankingItem myClanPointRankingItem;

	private ClanRankingResponseModel _rankingModel;

	private readonly ClanPointRankingResponseModel[] _pointRankingModel;

	private int _pointRankingIndex;

	private bool _ignoreOnClickTab;

	public void Awake()
	{
	}

	public void Show()
	{
	}

	[AsyncStateMachine(typeof(_003COnClickTab_003Ed__15))]
	private void OnClickTab(int idx)
	{
	}

	[AsyncStateMachine(typeof(_003CFetchClanRanking_003Ed__16))]
	public UniTask FetchClanRanking()
	{
		return default(UniTask);
	}

	[AsyncStateMachine(typeof(_003CFetchPointRanking_003Ed__17))]
	public UniTask FetchPointRanking(int index)
	{
		return default(UniTask);
	}

	public void OnClickPointRankingNextPageButton(int dir)
	{
	}

	public void OnClickClanRaidRewardInfo()
	{
	}

	public void ShowLoading(bool v)
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
