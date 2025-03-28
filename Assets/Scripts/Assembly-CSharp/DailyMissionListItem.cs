using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Awesomepiece.Model;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class DailyMissionListItem : MonoBehaviour
{
	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003COnClick_003Ed__19 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public DailyMissionListItem _003C_003E4__this;

		private SeasonPassPanel _003CpassPanel_003E5__2;

		private int _003ClastPoint_003E5__3;

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

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CRerollMission_003Ed__21 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public DailyMissionListItem _003C_003E4__this;

		private UniTask<RerollPassMissionResponseModel>.Awaiter _003C_003Eu__1;

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

	public ImageTextPair keyPair;

	public ImageTextPair rewardPair;

	public ImageTextPair unitPair;

	public Button rewardButton;

	public Button rerollButton;

	public ResourceMission resMission;

	public Text timeText;

	public Image newImage;

	public GameObject nextObj;

	public Text nextText;

	private DateTime _untilAt;

	private bool _isNextObj;

	private bool _isInReroll;

	[ComponentConnect]
	public GameObject contentBox;

	[ComponentConnect]
	public GameObject completeIcon;

	public void Set(ResourceMission resMission, DateTime? untilAt = null)
	{
	}

	public void SetNextObj(bool v)
	{
	}

	private void ReloadTime()
	{
	}

	[AsyncStateMachine(typeof(_003COnClick_003Ed__19))]
	public void OnClick()
	{
	}

	public void OnClickReroll()
	{
	}

	[AsyncStateMachine(typeof(_003CRerollMission_003Ed__21))]
	private void RerollMission()
	{
	}

	public void Update()
	{
	}
}
