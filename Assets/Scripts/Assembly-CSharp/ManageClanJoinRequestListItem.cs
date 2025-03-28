using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Awesomepiece.Model;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class ManageClanJoinRequestListItem : MonoBehaviour, IComponentConnector
{
	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CProcessRequestJoinClan_003Ed__5 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public ManageClanJoinRequestListItem _003C_003E4__this;

		public int accountId;

		public bool accept;

		private UniTask<ClanResponseModel>.Awaiter _003C_003Eu__1;

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

	public Button[] buttons;

	[ComponentConnect]
	public PlayerProfile playerProfile;

	[ComponentConnect]
	public Text nameText;

	private ClanMemberModel _model;

	public void Set(ClanMemberModel model)
	{
	}

	[AsyncStateMachine(typeof(_003CProcessRequestJoinClan_003Ed__5))]
	private void ProcessRequestJoinClan(int accountId, bool accept)
	{
	}

	[OnClick("AcceptButton", true)]
	public void OnClickAccept()
	{
	}

	[OnClick("DeclineButton", true)]
	public void OnClickDecline()
	{
	}

	public void OnClickProfile()
	{
	}
}
