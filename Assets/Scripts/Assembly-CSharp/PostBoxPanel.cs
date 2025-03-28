using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Awesomepiece.Model;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class PostBoxPanel : MonoBehaviour, IClosable
{
	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003COnClickReceiveAll_003Ed__8 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public PostBoxPanel _003C_003E4__this;

		private bool _003ChasNameTagPost_003E5__2;

		private List<PostResponseModel.PostData> _003CdelList_003E5__3;

		private UniTask<PostReceiveResponseModel>.Awaiter _003C_003Eu__1;

		private GameManager _003C_003E7__wrap3;

		private UniTask<FlagInventoryResponseModel>.Awaiter _003C_003Eu__2;

		private UniTask<NameTagInventoryResponseModel>.Awaiter _003C_003Eu__3;

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
	public UITableView tableView;

	[ComponentConnect]
	public Button receiveAllButton;

	private readonly List<string> _acceptedKeys;

	private readonly Dictionary<PostResponseModel.PostData, string> _acceptableKeys;

	public void Show()
	{
	}

	public void Reload()
	{
	}

	public void Hide()
	{
	}

	private bool CheckAcceptable()
	{
		return false;
	}

	[AsyncStateMachine(typeof(_003COnClickReceiveAll_003Ed__8))]
	public void OnClickReceiveAll()
	{
	}

	public void AddToAcceptedPosts(PostResponseModel.PostData post)
	{
	}

	public bool CheckIsPostAccepted(PostResponseModel.PostData post)
	{
		return false;
	}

	public bool Close()
	{
		return false;
	}

	public void OnClickClose()
	{
	}
}
