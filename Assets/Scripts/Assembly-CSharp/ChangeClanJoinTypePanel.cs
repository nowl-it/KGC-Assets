using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Awesomepiece.Model;
using Cysharp.Threading.Tasks;
using UnityEngine.UI;

public class ChangeClanJoinTypePanel : PopupPanel, IComponentConnector
{
	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003COnClickSave_003Ed__7 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public ChangeClanJoinTypePanel _003C_003E4__this;

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

	[ComponentConnect]
	public Button saveButton;

	[ComponentConnect]
	public InputField introField;

	[ComponentConnect("JoinTypeToggle~", true)]
	public Toggle[] joinTypeToggles;

	private ClanModel _clan;

	private int _joinType;

	public override void Show()
	{
	}

	public void OnClickToggle()
	{
	}

	[OnClick("SaveButton", true)]
	[AsyncStateMachine(typeof(_003COnClickSave_003Ed__7))]
	public void OnClickSave()
	{
	}
}
