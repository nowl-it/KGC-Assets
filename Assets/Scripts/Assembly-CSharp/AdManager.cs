using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;

public class AdManager
{
	public enum AdType
	{
		UnityAds = 0,
		Tapjoy = 1,
		Admob = 2
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CAdCallbackImpl_003Ed__17 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public AdManager _003C_003E4__this;

		public bool success;

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

	public string type;

	private const bool UnityAdsAvailable = true;

	private const bool TapjoyAvailable = true;

	private const bool AdmobAvailable = true;

	private Action<bool> _callback;

	private string _platform;

	private bool _callbacked;

	private bool _callbackResult;

	public static AdManager Instance { get; }

	public void Init()
	{
	}

	public void ShowAdOrPass(Action<bool> callback, string type = "")
	{
	}

	private void ShowAdPassText(Action<bool> callback, string type, string text)
	{
	}

	public void ShowAd(Action<bool> callback, string type = "")
	{
	}

	private void AdCallback(bool success)
	{
	}

	[AsyncStateMachine(typeof(_003CAdCallbackImpl_003Ed__17))]
	private void AdCallbackImpl(bool success)
	{
	}

	public bool IsReady()
	{
		return false;
	}

	public void Update()
	{
	}
}
