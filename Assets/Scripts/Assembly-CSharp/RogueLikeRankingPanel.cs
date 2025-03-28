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

public class RogueLikeRankingPanel : MonoBehaviour, IClosable
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass11_0
	{
		public bool processed;

		public RogueLikeRankingPanel _003C_003E4__this;

		internal void _003CFetchRanking_003Eb__0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass12_0
	{
		public bool processed;

		public RogueLikeRankingPanel _003C_003E4__this;

		internal void _003CFetchBuildingRanking_003Eb__0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass16_0
	{
		public RogueLikeRankingResponseModel model;

		public List<RogueLikeRankingResponseModel.RogueLikeRankingData> items;

		internal bool _003CShowRanking_003Eb__1(RogueLikeRankingResponseModel.RogueLikeRankingData r)
		{
			return false;
		}

		internal void _003CShowRanking_003Eb__0(int idx, GameObject o)
		{
		}
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CFetchBuildingRanking_003Ed__12 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public RogueLikeRankingPanel _003C_003E4__this;

		public int index;

		private _003C_003Ec__DisplayClass12_0 _003C_003E8__1;

		private UniTask<RogueLikeRankingResponseModel>.Awaiter _003C_003Eu__1;

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
	private struct _003CFetchRanking_003Ed__11 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public RogueLikeRankingPanel _003C_003E4__this;

		private _003C_003Ec__DisplayClass11_0 _003C_003E8__1;

		private UniTask<RogueLikeRankingResponseModel>.Awaiter _003C_003Eu__1;

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

		public RogueLikeRankingPanel _003C_003E4__this;

		public int index;

		private _003C_003Ec__DisplayClass16_0 _003C_003E8__1;

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

	public Text titleText;

	[ComponentConnect]
	public Text noRankingText;

	[ComponentConnect]
	public RogueLikeRankingItem myRankingItem;

	[ComponentConnect]
	public CanvasGroup rankingLoadingPopup;

	public UITableView tableView;

	private RogueLikeRankingResponseModel _rankingModel;

	private RogueLikeRankingResponseModel[] _buildingRankingModel;

	private bool _inited;

	private int _currentIndex;

	private Action _callBack;

	private bool[] _playerRankInserted;

	public void Show(Action callBack = null)
	{
	}

	[AsyncStateMachine(typeof(_003CFetchRanking_003Ed__11))]
	public UniTask FetchRanking()
	{
		return default(UniTask);
	}

	[AsyncStateMachine(typeof(_003CFetchBuildingRanking_003Ed__12))]
	public UniTask FetchBuildingRanking(int index)
	{
		return default(UniTask);
	}

	public void OnClickLeft()
	{
	}

	public void OnClickRight()
	{
	}

	[AsyncStateMachine(typeof(_003CShowRanking_003Ed__16))]
	private void ShowRanking(int index)
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
