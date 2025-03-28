using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Awesomepiece.Model;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class PvPSeasonRankingPanel : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass13_0
	{
		public bool processed;

		public PvPSeasonRankingPanel _003C_003E4__this;

		internal void _003CFetchRanking_003Eb__0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass14_0
	{
		public List<PvPRankingResponseModel.PvPRankingData> items;

		public PvPRankingResponseModel model;

		internal void _003CShowRanking_003Eb__0(int idx, GameObject o)
		{
		}
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CFetchRanking_003Ed__13 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public PvPSeasonRankingPanel _003C_003E4__this;

		private _003C_003Ec__DisplayClass13_0 _003C_003E8__1;

		private UniTask<PvPRankingResponseModel>.Awaiter _003C_003Eu__1;

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
	private struct _003CShowRanking_003Ed__14 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public int tier;

		public PvPSeasonRankingPanel _003C_003E4__this;

		private _003C_003Ec__DisplayClass14_0 _003C_003E8__1;

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
	public Image rankTierIcon;

	[ComponentConnect]
	public Text rankTierName;

	[ComponentConnect]
	public Text rankTierScore;

	[ComponentConnect]
	public Text rankTierRank;

	[ComponentConnect]
	public Text noRankingText;

	[ComponentConnect]
	public PvPRankingItem myRankingItem;

	[ComponentConnect]
	public CanvasGroup rankingLoadingPopup;

	public UITableView tableView;

	private PvPRankingResponseModel _rankingModel;

	private int _currentTier;

	private static readonly int[] TIERS;

	private bool _inited;

	public void OnEnable()
	{
	}

	[AsyncStateMachine(typeof(_003CFetchRanking_003Ed__13))]
	public UniTask FetchRanking()
	{
		return default(UniTask);
	}

	[AsyncStateMachine(typeof(_003CShowRanking_003Ed__14))]
	private void ShowRanking(int tier)
	{
	}

	public void OnClickLeft()
	{
	}

	public void OnClickRight()
	{
	}

	public void Reload()
	{
	}

	public void ShowLoading(bool v)
	{
	}
}
