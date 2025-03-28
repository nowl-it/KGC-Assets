using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Awesomepiece.Model;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class UseVoucherPanel : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass10_0
	{
		public bool processed;

		internal void _003COnClickUseVoucher_003Eb__0()
		{
		}
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003COnClickUseVoucher_003Ed__10 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public UseVoucherPanel _003C_003E4__this;

		private _003C_003Ec__DisplayClass10_0 _003C_003E8__1;

		private UniTask<UseInventoryResponseModel>.Awaiter _003C_003Eu__1;

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

	public ConditionalGroup canUseButton;

	public Button useButton;

	public ClickableShopItemIcon icon;

	public Text descText;

	public Text titleText;

	public Text countText;

	private UseVoucherData _useVoucherData;

	private ResourceInventoryItem _resInventoryItem;

	private Action<UseInventoryResponseModel> _afterUseCallback;

	public void Init(UseVoucherData useVoucherData)
	{
	}

	[AsyncStateMachine(typeof(_003COnClickUseVoucher_003Ed__10))]
	public void OnClickUseVoucher()
	{
	}

	public void SetCallback(Action<UseInventoryResponseModel> afterUseCallback)
	{
	}

	private void Reload()
	{
	}
}
