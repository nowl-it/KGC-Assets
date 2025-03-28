using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Awesomepiece.Model;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class ManageClanMemberListItem : MonoBehaviour, IComponentConnector
{
	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003COnChangeRole_003Ed__11 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public ManageClanMemberListItem _003C_003E4__this;

		private int _003CtargetRole_003E5__2;

		private ManageClanMemberPanel _003Cpanel_003E5__3;

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
	private struct _003COnClickBan_003Ed__10 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public ManageClanMemberListItem _003C_003E4__this;

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

	[ComponentConnect]
	public PlayerProfile playerProfile;

	[ComponentConnect]
	public Text nameText;

	[ComponentConnect]
	public Text lastLoginedText;

	[ComponentConnect]
	public Button banButton;

	[ComponentConnect]
	public Dropdown roleCombobox;

	private ClanMemberModel _model;

	private int _myRole;

	private bool _handleChangeRole;

	public void Set(ClanMemberModel model)
	{
	}

	private void OnDisable()
	{
	}

	[AsyncStateMachine(typeof(_003COnClickBan_003Ed__10))]
	public void OnClickBan()
	{
	}

	[AsyncStateMachine(typeof(_003COnChangeRole_003Ed__11))]
	public void OnChangeRole()
	{
	}

	public void OnClickProfile()
	{
	}
}
