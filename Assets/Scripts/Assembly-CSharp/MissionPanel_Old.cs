using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class MissionPanel_Old : MonoBehaviour, IClosable
{
	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003COnClickGetReward_003Ed__12 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public MissionPanel_Old _003C_003E4__this;

		private UniTask<Awesomepiece.Model.MissionRewardResponseModel>.Awaiter _003C_003Eu__1;

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
	public UITableView tableView;

	[ComponentConnect]
	public Text rewardNameText;

	[ComponentConnect]
	public Text rewardStackText;

	[ComponentConnect]
	public Image rewardGauge;

	[ComponentConnect]
	public Image rewardIcon;

	[ComponentConnect]
	public Button rewardButton;

	[ComponentConnect]
	public ConditionalRoot gaugeBox;

	[ComponentConnect]
	public GetMoneyEffect getKeyEffect;

	public void Show()
	{
	}

	public void Reload(bool showGuageTween = false)
	{
	}

	private bool CheckShowCondition(ResourceMission resMission)
	{
		return false;
	}

	public int GetMissionCount()
	{
		return 0;
	}

	[AsyncStateMachine(typeof(_003COnClickGetReward_003Ed__12))]
	public void OnClickGetReward()
	{
	}

	public bool Close()
	{
		return false;
	}

	public void OnClickClose()
	{
	}
}
