using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Awesomepiece.Model;
using UnityEngine;
using UnityEngine.UI;

public class StarterMissionPanel : MissionPanel
{
	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003COnClickStepRewardButton_003Ed__32 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public StarterMissionPanel _003C_003E4__this;

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

	[SerializeField]
	private StarterMissionPanel_Base _exclusiveBasePanel;

	[Header("보상 유닛 관련")]
	[SerializeField]
	private Image _rewardUnitIllustImage;

	[SerializeField]
	private Image _rewardUnitGradationImage;

	[SerializeField]
	private Image _rewardUnitSpriteImage;

	[SerializeField]
	private Text _rewardUnitNameText;

	[SerializeField]
	private Text _rewardUnitSubNameText;

	[SerializeField]
	private Text _rewardButtonProgressText;

	[SerializeField]
	private Gauge _rewardButtonProgressGauge;

	[SerializeField]
	private HQIllustPopup _hqIllustPopup;

	[SerializeField]
	[Header("Step 보상 관련")]
	private Text _stepTitleText;

	[SerializeField]
	private Text _stepDescText;

	[SerializeField]
	private TabManager _stepTabManager;

	[SerializeField]
	private ImageTextPair[] _stepTabTitlePairs;

	[SerializeField]
	private ConditionalGroup[] _stepTabConditional;

	[SerializeField]
	private ConditionalGroup _getStepRewardConditional;

	private static int _currentStep;

	private int _currentSubStep;

	private MissionData _currentStepMission;

	private int _currentFinalRewardUnit;

	public (int step, int subStep) currentStepInProgress;

	protected override void Init()
	{
	}

	public void Show()
	{
	}

	public void ReloadAfterMissionClear()
	{
	}

	private void ReloadStep()
	{
	}

	private void ReloadStepRewardButton()
	{
	}

	private void ReloadSubStepTabDatas()
	{
	}

	public new static bool CheckShowCondition(int tabIdx, ResourceMission resMission, bool isConditionForClearedCountBadge)
	{
		return false;
	}

	public new static int GetTotalClearedMissionCount()
	{
		return 0;
	}

	public static bool CanReceiveStepMissionReward()
	{
		return false;
	}

	private static (int, int) GetCurrentStepInProgress()
	{
		return default((int, int));
	}

	protected override void OnReceive(MissionPanel_Base panelBase)
	{
	}

	protected override void BeforeShow()
	{
	}

	[AsyncStateMachine(typeof(_003COnClickStepRewardButton_003Ed__32))]
	public void OnClickStepRewardButton()
	{
	}

	public void OnClickUnitIllust()
	{
	}

	public static bool CanShowStarterMissionButton()
	{
		return false;
	}
}
