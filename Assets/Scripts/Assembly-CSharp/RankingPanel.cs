using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Awesomepiece.Model;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class RankingPanel : MonoBehaviour, IClosable
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass13_0
	{
		public bool processed;

		public RankingPanel _003C_003E4__this;

		internal void _003CFetchRanking_003Eb__0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass14_0
	{
		public RankingResponseModel model;

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

		public RankingPanel _003C_003E4__this;

		public int theme;

		private _003C_003Ec__DisplayClass13_0 _003C_003E8__1;

		private UniTask<RankingResponseModel>.Awaiter _003C_003Eu__1;

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

		public int theme;

		public RankingPanel _003C_003E4__this;

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
	public Text chapterNumText;

	[ComponentConnect]
	public Text chapterNameText;

	[ComponentConnect]
	public RankingItem myRankingItem;

	[ComponentConnect]
	public CanvasGroup rankingLoadingPopup;

	[ComponentConnect]
	public Text noRankingText;

	public UITableView tableView;

	private RankingPreviewPanel _rankingPreviewPanel;

	private Dictionary<int, RankingResponseModel> _fetchedMap;

	private int _currentTheme;

	private bool _inited;

	public RankingPreviewPanel rankingPreviewPanel => null;

	public void Show(int currentTheme)
	{
	}

	[AsyncStateMachine(typeof(_003CFetchRanking_003Ed__13))]
	public UniTask FetchRanking(int theme)
	{
		return default(UniTask);
	}

	[AsyncStateMachine(typeof(_003CShowRanking_003Ed__14))]
	private void ShowRanking(int theme)
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

	public void OnClickClose()
	{
	}

	public bool Close()
	{
		return false;
	}

	public void OnClickRankingPreviewButton()
	{
	}
}
