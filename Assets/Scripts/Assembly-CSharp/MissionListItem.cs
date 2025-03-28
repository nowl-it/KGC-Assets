using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Awesomepiece.Model;
using UnityEngine;
using UnityEngine.UI;

public class MissionListItem : MonoBehaviour
{
	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003COnClick_003Ed__12 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public MissionListItem _003C_003E4__this;

		private TaskAwaiter<MissionRewardResponseModel> _003C_003Eu__1;

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

	public Text content;

	public Image progressGauge;

	public Text progressText;

	public Button rewardButton;

	public ImageTextPair[] rewardPair;

	public Text eliteActiveText;

	public ResourceMission resMission;

	public GameObject rightBox;

	public Text rightBoxText;

	[GetComponent]
	public ConditionalRoot conditionalRoot;

	public GameObject clearedObject;

	public void Set(ResourceMission resMission)
	{
	}

	[AsyncStateMachine(typeof(_003COnClick_003Ed__12))]
	public void OnClick()
	{
	}
}
