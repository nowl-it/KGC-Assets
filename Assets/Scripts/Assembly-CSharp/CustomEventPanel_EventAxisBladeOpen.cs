using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Awesomepiece;
using Awesomepiece.Model;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnityEngine;

public class CustomEventPanel_EventAxisBladeOpen : CustomEventPanel
{
	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CAxisBladeDownloadOrDeepLink_003Ed__8 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		private UniTask.Awaiter _003C_003Eu__1;

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
	private ConditionalGroup _cardConditional;

	private CustomEventData _customEventData;

	private List<Reward> _customEventReward => null;

	public override void Show(CustomEventData customEventData)
	{
	}

	public void SetCardConditional()
	{
	}

	public void ShowSkinInfoPanel()
	{
	}

	public void DoDeepLinkShortcut()
	{
	}

	[AsyncStateMachine(typeof(_003CAxisBladeDownloadOrDeepLink_003Ed__8))]
	private UniTask AxisBladeDownloadOrDeepLink()
	{
		return default(UniTask);
	}

	public void TestReward()
	{
	}
}
