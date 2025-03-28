using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class RogueLikeRevivePanel : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass23_0
	{
		public RogueLikeRevivePanel _003C_003E4__this;

		public bool timeOut;

		internal void _003COnClickRevive_003Eb__0()
		{
		}

		internal void _003COnClickRevive_003Eb__1()
		{
		}

		internal void _003COnClickRevive_003Eb__2(bool ret)
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass24_0
	{
		public RogueLikeRevivePanel _003C_003E4__this;

		public bool timeOut;

		internal void _003COnClickCashRevive_003Eb__0()
		{
		}

		internal void _003COnClickCashRevive_003Eb__1()
		{
		}
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003COnClickCashRevive_003Ed__24 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public RogueLikeRevivePanel _003C_003E4__this;

		public bool useCoupon;

		private _003C_003Ec__DisplayClass24_0 _003C_003E8__1;

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

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003COnClickRevive_003Ed__23 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public RogueLikeRevivePanel _003C_003E4__this;

		private _003C_003Ec__DisplayClass23_0 _003C_003E8__1;

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

	private static RogueLikeRevivePanel _instance;

	[ComponentConnect]
	public Border ribbon;

	[ComponentConnect]
	public ConditionalRootGroup adButtonRootGroup;

	[ComponentConnect]
	public Button adButton;

	[ComponentConnect]
	public Button cashButton;

	[ComponentConnect]
	public Button couponButton;

	[ComponentConnect]
	public Text timerText;

	[ComponentConnect]
	public Text commentText;

	[ComponentConnect]
	public Text currentCash;

	[ComponentConnect]
	public Text currentCoupon;

	private Action _cancelCallback;

	private float _remainTime;

	private bool _timerEnabled;

	private bool _hasHandledAdCallback;

	private bool _requested;

	private const int _cashCost = 10;

	private const int _couponItemId = 2206;

	private bool _setBG;

	public static RogueLikeRevivePanel Instance => null;

	private void SetBG()
	{
	}

	public void Show(Action cancelCallback, bool canAdRevive)
	{
	}

	public void OnClickClose()
	{
	}

	[AsyncStateMachine(typeof(_003COnClickRevive_003Ed__23))]
	public void OnClickRevive()
	{
	}

	[AsyncStateMachine(typeof(_003COnClickCashRevive_003Ed__24))]
	public void OnClickCashRevive(bool useCoupon)
	{
	}

	public void Update()
	{
	}
}
