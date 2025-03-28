using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Awesomepiece.Model;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class RogueLikeMissionItem : MonoBehaviour
{
	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003COnClickReward_003Ed__12 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public RogueLikeMissionItem _003C_003E4__this;

		private UniTask<MissionRewardResponseModel>.Awaiter _003C_003Eu__1;

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
	private Image _missionIcon;

	[SerializeField]
	private Text _missionTitle;

	[SerializeField]
	private Text _missionDesc;

	[SerializeField]
	private Gauge _missionGauge;

	[SerializeField]
	private ConditionalGroup _missionCompleted;

	[SerializeField]
	private ClickableShopItemIcon _rewardIcon;

	[SerializeField]
	private ConditionalSetActive _clear;

	[SerializeField]
	private ConditionalSetActive _check;

	[SerializeField]
	private GameObject _completeAndCheckMark;

	private MissionData _missionData;

	public void Set(MissionData missionData, bool check)
	{
	}

	public void Reload()
	{
	}

	[AsyncStateMachine(typeof(_003COnClickReward_003Ed__12))]
	public void OnClickReward()
	{
	}
}
