using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using UnityEngine.UI;

public class CouponPanel : PopupPanel
{
	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CSubmitCoupon_003Ed__4 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public CouponPanel _003C_003E4__this;

		private UniTask<Awesomepiece.Model.ResponseModel>.Awaiter _003C_003Eu__1;

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

	public InputField inputField;

	private bool _waiting;

	public override void Show()
	{
	}

	public void OnClickConfirm()
	{
	}

	[AsyncStateMachine(typeof(_003CSubmitCoupon_003Ed__4))]
	private void SubmitCoupon()
	{
	}

	public override bool Close()
	{
		return false;
	}
}
