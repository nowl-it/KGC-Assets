using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Awesomepiece.Model;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class ClanChatPanel : MonoBehaviour, IComponentConnector
{
	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CAutoUpdateChat_003Ed__26 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public ClanChatPanel _003C_003E4__this;

		private UniTask<ClanSeqResponseModel>.Awaiter _003C_003Eu__1;

		private UniTask<ClanChatResponseModel>.Awaiter _003C_003Eu__2;

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
	private struct _003CFetchMyRequest_003Ed__27 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public ClanChatPanel _003C_003E4__this;

		private UniTask<ClanChatResponseModel>.Awaiter _003C_003Eu__1;

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
	private struct _003COnClickChatSubmit_003Ed__25 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public ClanChatPanel _003C_003E4__this;

		private ulong _003Ctimer_003E5__2;

		private UniTask<ClanChatResponseModel>.Awaiter _003C_003Eu__1;

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
	private struct _003CReloadChat_003Ed__19 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public List<ClanChatModel> chats;

		public ClanChatPanel _003C_003E4__this;

		public bool scrollToBottom;

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
	public UIAdvancedTableView tableView;

	[ComponentConnect]
	public InputField chatField;

	[ComponentConnect]
	public Button chatButton;

	[ComponentConnect]
	public Button requestButton;

	[ComponentConnect]
	public Text requestButtonText;

	[ComponentConnect]
	public Button upperRequestButton;

	[ComponentConnect]
	public Text upperRequestButtonText;

	[ComponentConnect]
	public Button toBottomButton;

	public Text chatMessagePrefabText;

	private int _currentSeqId;

	private bool _autoUpdate;

	private float _autoUpdateTimer;

	private int _myRequestID;

	private int _lastRequestCount;

	private List<ClanChatModel> _requests;

	private bool _inited;

	private ClanModel _clan;

	public void Show()
	{
	}

	public void CheckClanSupportCompleted()
	{
	}

	[AsyncStateMachine(typeof(_003CReloadChat_003Ed__19))]
	public void ReloadChat(List<ClanChatModel> chats, bool scrollToBottom = false)
	{
	}

	public void ReloadButtons()
	{
	}

	[OnClick("RequestButton", true)]
	public void OnClickRequest()
	{
	}

	[OnClick("UpperRequestButton", true)]
	public void OnClickUpperRequest()
	{
	}

	[OnClick("ToBottomButton", true)]
	public void OnClickToBottom()
	{
	}

	public void OnTableViewScrolled()
	{
	}

	[OnClick("ChatButton", true)]
	[AsyncStateMachine(typeof(_003COnClickChatSubmit_003Ed__25))]
	public void OnClickChatSubmit()
	{
	}

	[AsyncStateMachine(typeof(_003CAutoUpdateChat_003Ed__26))]
	private void AutoUpdateChat()
	{
	}

	[AsyncStateMachine(typeof(_003CFetchMyRequest_003Ed__27))]
	private void FetchMyRequest()
	{
	}

	public void SetAutoUpdate(bool v)
	{
	}

	public void Update()
	{
	}
}
