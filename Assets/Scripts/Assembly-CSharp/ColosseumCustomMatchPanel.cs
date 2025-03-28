using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Awesomepiece.Model;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class ColosseumCustomMatchPanel : MonoBehaviour, IClosable
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass5_0
	{
		public ColosseumCustomMatchResponseModel ret;

		internal void _003COnClickCreateButton_003Eb__0()
		{
		}
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003COnClickCreateButton_003Ed__5 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public ColosseumCustomMatchPanel _003C_003E4__this;

		private _003C_003Ec__DisplayClass5_0 _003C_003E8__1;

		private int _003Ccount_003E5__2;

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
	private Button _createButton;

	private ColosseumCustomMatchJoinPopup _colosseumJoinPopup;

	public ColosseumCustomMatchJoinPopup colosseumJoinPopup => null;

	public void Show()
	{
	}

	[AsyncStateMachine(typeof(_003COnClickCreateButton_003Ed__5))]
	public void OnClickCreateButton()
	{
	}

	public void OnClickJoinButton()
	{
	}

	public void OnClickClose()
	{
	}

	public bool Close()
	{
		return false;
	}
}
