using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.SignInWithApple;

public class LinkAccountPanel : MonoBehaviour
{
	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CLinkAccount_003Ed__8 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public int type;

		public string userId;

		public LinkAccountPanel _003C_003E4__this;

		private UniTask<Awesomepiece.Model.TransferCodeResponseModel>.Awaiter _003C_003Eu__1;

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
	public GameObject googleLoginButton;

	[ComponentConnect]
	public SignInWithApple appleLoginButton;

	[ComponentConnect]
	public GameObject gameCenterLoginButton;

	private int _accountType;

	public void Show()
	{
	}

	public void OnClickGoogleLogin()
	{
	}

	public void OnClickAppleLogin()
	{
	}

	public void OnClickGameCenterLogin()
	{
	}

	[AsyncStateMachine(typeof(_003CLinkAccount_003Ed__8))]
	private void LinkAccount(int type, string userId)
	{
	}

	public void OnClickCancel()
	{
	}
}
