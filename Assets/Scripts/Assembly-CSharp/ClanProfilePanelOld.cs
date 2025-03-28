using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Awesomepiece.Model;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class ClanProfilePanelOld : MonoBehaviour, IClosable, IComponentConnector
{
	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003COnClickJoin_003Ed__19 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public ClanProfilePanelOld _003C_003E4__this;

		private UniTask<bool>.Awaiter _003C_003Eu__1;

		private UniTask<ClanResponseModel>.Awaiter _003C_003Eu__2;

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
	private struct _003CShow_003Ed__16 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public ClanProfilePanelOld _003C_003E4__this;

		public ClanModel clan;

		public bool joined;

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
	public ClanMark clanMark;

	[ComponentConnect]
	public Text nameText;

	[ComponentConnect]
	public Text introLabel;

	[ComponentConnect]
	public Text introText;

	[ComponentConnect]
	public Text supportText;

	[ComponentConnect]
	public Text memberCountText;

	[ComponentConnect]
	public UITableView tableView;

	[ComponentConnect]
	public RectTransform nameLabel;

	[ComponentConnect]
	public RectTransform weeklyLabel;

	[ComponentConnect]
	public Button joinButton;

	[ComponentConnect]
	public Button menuButton;

	[ComponentConnect]
	public Text levelLimitText;

	[ComponentConnect]
	public Text joinButtonText;

	[ComponentConnect]
	public Image newRequestBadge;

	[ComponentConnect]
	public Image canMandateBadge;

	private ClanModel _clanModel;

	[AsyncStateMachine(typeof(_003CShow_003Ed__16))]
	public void Show(ClanModel clan, bool joined = false)
	{
	}

	public void Reload(ClanModel clan, bool joined)
	{
	}

	private void ReloadJoinButton(bool joined)
	{
	}

	[OnClick("JoinButton", true)]
	[AsyncStateMachine(typeof(_003COnClickJoin_003Ed__19))]
	public void OnClickJoin()
	{
	}

	[OnClick("MenuButton", true)]
	public void OnClickMenu()
	{
	}

	public bool Close()
	{
		return false;
	}

	public void OnClickClose()
	{
	}
}
