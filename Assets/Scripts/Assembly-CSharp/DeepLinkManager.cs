using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnityEngine;
using UnityEngine.Networking;

public class DeepLinkManager : MonoBehaviour
{
	[Serializable]
	public class ResponseModel
	{
		public int errorCode;

		public string message;
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CAxisBladeCheckPost_003Ed__6 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public string accessToken;

		public DeepLinkManager _003C_003E4__this;

		private UnityWebRequest _003Cwww_003E5__2;

		private UnityAsyncExtensions.UnityWebRequestAsyncOperationAwaiter _003C_003Eu__1;

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
	private struct _003CAxisBladeOpenEventRequest_003Ed__7 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public string accessToken;

		private UniTask<Awesomepiece.Model.ResponseModel>.Awaiter _003C_003Eu__1;

		private UnityAsyncExtensions.UnityWebRequestAsyncOperationAwaiter _003C_003Eu__2;

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

	public static DeepLinkManager Instance;

	private static readonly string somethingGood;

	private static string AXISBLADE_EVENT_URL;

	public static bool isDeepLinkOpened;

	public void Awake()
	{
	}

	public void OnDeepLinkURLOpened(string deepLinkUrl)
	{
	}

	[AsyncStateMachine(typeof(_003CAxisBladeCheckPost_003Ed__6))]
	private UniTask AxisBladeCheckPost(string accessToken)
	{
		return default(UniTask);
	}

	[AsyncStateMachine(typeof(_003CAxisBladeOpenEventRequest_003Ed__7))]
	private UniTask AxisBladeOpenEventRequest(string accessToken)
	{
		return default(UniTask);
	}
}
