using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class ClanMenuPanel : PopupPanel, IComponentConnector
{
	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003COnClickDeleteClanButton_003Ed__24 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public ClanMenuPanel _003C_003E4__this;

		private UniTask<bool>.Awaiter _003C_003Eu__1;

		private UniTask<Awesomepiece.Model.ClanResponseModel>.Awaiter _003C_003Eu__2;

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
	private struct _003COnClickLeaveClanButton_003Ed__25 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public ClanMenuPanel _003C_003E4__this;

		private UniTask<bool>.Awaiter _003C_003Eu__1;

		private UniTask<Awesomepiece.Model.ClanResponseModel>.Awaiter _003C_003Eu__2;

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
	private struct _003COnClickMandateMasterButton_003Ed__26 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public ClanMenuPanel _003C_003E4__this;

		private UniTask<bool>.Awaiter _003C_003Eu__1;

		private UniTask<Awesomepiece.Model.ClanResponseModel>.Awaiter _003C_003Eu__2;

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
	public Border box;

	[ComponentConnect]
	public LayoutFitter layout;

	[ComponentConnect]
	public Button changeNameButton;

	[ComponentConnect]
	public GameObject adminLabel;

	public Button[] adminButtons;

	[ComponentConnect]
	public GameObject leaveLabel;

	public Button[] leaveButtons;

	public Button mandateMasterButton;

	[ComponentConnect]
	public ChangeClanNamePanel changeClanNamePanel;

	[ComponentConnect]
	public ChangeClanSettingPanel changeClanSettingPanel;

	[ComponentConnect]
	public ChangeClanJoinTypePanel changeClanJoinTypePanel;

	[ComponentConnect]
	public ManageClanMemberPanel manageClanMemberPanel;

	[ComponentConnect]
	public ManageClanJoinRequestPanel manageClanJoinRequestPanel;

	[ComponentConnect]
	public Popup deleteConfirmPopup;

	[ComponentConnect]
	public InputField confirmInputField;

	[ComponentConnect]
	public Image newRequestBadge;

	[ComponentConnect]
	public Image canMandateBadge;

	public override void Show()
	{
	}

	public void Reload()
	{
	}

	[OnClick("ChangeNameButton", true)]
	public void OnClickChangeNameButton()
	{
	}

	[OnClick("ChangeSettingButton", true)]
	public void OnClickChangeSettingButton()
	{
	}

	[OnClick("ChangeJoinTypeButton", true)]
	public void OnClickChangeJoinTypeButton()
	{
	}

	[OnClick("ManageMemberButton", true)]
	public void OnClickManageMemberButton()
	{
	}

	[OnClick("ManageJoinRequestButton", true)]
	public void OnClickManageJoinRequestButton()
	{
	}

	[OnClick("DeleteClanButton", true)]
	[AsyncStateMachine(typeof(_003COnClickDeleteClanButton_003Ed__24))]
	public void OnClickDeleteClanButton()
	{
	}

	[OnClick("LeaveClanButton", true)]
	[AsyncStateMachine(typeof(_003COnClickLeaveClanButton_003Ed__25))]
	public void OnClickLeaveClanButton()
	{
	}

	[AsyncStateMachine(typeof(_003COnClickMandateMasterButton_003Ed__26))]
	[OnClick("MandateMasterButton", true)]
	public void OnClickMandateMasterButton()
	{
	}
}
