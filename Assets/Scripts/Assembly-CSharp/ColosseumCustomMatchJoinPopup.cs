using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Awesomepiece.Model;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class ColosseumCustomMatchJoinPopup : PopupPanel
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass6_0
	{
		public ColosseumCustomMatchResponseModel ret;

		public ColosseumCustomMatchJoinPopup _003C_003E4__this;

		internal void _003CJoin_003Eb__0()
		{
		}
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CJoin_003Ed__6 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public ColosseumCustomMatchJoinPopup _003C_003E4__this;

		private _003C_003Ec__DisplayClass6_0 _003C_003E8__1;

		private UniTask<ColosseumCustomMatchResponseModel>.Awaiter _003C_003Eu__1;

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

	[SerializeField]
	private InputField _inputField;

	[SerializeField]
	private Button _joinButton;

	private void Awake()
	{
	}

	public override void Show()
	{
	}

	public void OnClickConfirm()
	{
	}

	public void OnClickPasteCode()
	{
	}

	[AsyncStateMachine(typeof(_003CJoin_003Ed__6))]
	private void Join()
	{
	}
}
