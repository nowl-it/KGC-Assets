using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class JourneyRewardPanel : MonoBehaviour, IClosable
{
	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003COnClickReward_003Ed__15 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public JourneyRewardPanel _003C_003E4__this;

		private ResourceJourneyReward.RewardItem _003CnextRewardItem_003E5__2;

		private UniTask<Awesomepiece.Model.JourneyRewardResponseModel>.Awaiter _003C_003Eu__1;

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
	private struct _003CShowWithInit_003Ed__12 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public JourneyRewardPanel _003C_003E4__this;

		private UniTask<Awesomepiece.Model.JourneyRewardResponseModel>.Awaiter _003C_003Eu__1;

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
	private RectTransform _gridLayoutRect;

	[SerializeField]
	private JourneyRewardItem _rewardItemPrefab;

	[SerializeField]
	private Button _rewardButton;

	[SerializeField]
	private Image _nextRewardImage;

	[SerializeField]
	private Text _nextRewardNameText;

	[SerializeField]
	private Text _remainTimeText;

	private List<JourneyRewardItem> _rewardItems;

	private bool _init;

	private bool _processing;

	private bool _timerDone;

	public void Show()
	{
	}

	private void ShowImpl()
	{
	}

	[AsyncStateMachine(typeof(_003CShowWithInit_003Ed__12))]
	private void ShowWithInit()
	{
	}

	private void InitRewards()
	{
	}

	public void Reload()
	{
	}

	[AsyncStateMachine(typeof(_003COnClickReward_003Ed__15))]
	public void OnClickReward()
	{
	}

	private void Update()
	{
	}

	private void UpdateRemainTime()
	{
	}

	public static void ReloadJourneyRewardButton()
	{
	}

	public static bool CanGetReward()
	{
		return false;
	}

	public static ResourceJourneyReward.RewardItem GetNextReward()
	{
		return null;
	}

	public void OnClickClose()
	{
	}

	public bool Close()
	{
		return false;
	}
}
