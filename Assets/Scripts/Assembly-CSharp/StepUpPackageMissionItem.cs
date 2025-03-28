using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Awesomepiece.Model;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

public class StepUpPackageMissionItem : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass10_0
	{
		public bool processed;

		internal void _003CRewardProcess_003Eb__0()
		{
		}
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CRewardProcess_003Ed__10 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

		public StepUpPackageMissionItem _003C_003E4__this;

		private _003C_003Ec__DisplayClass10_0 _003C_003E8__1;

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
	private Text _title;

	[SerializeField]
	private ClickableShopItemIcon _reward;

	[SerializeField]
	private Button _button;

	[SerializeField]
	private ConditionalGroup _buttonCond;

	[SerializeField]
	private Text _buttonText;

	private ResourceShopItem _parent;

	private ResourceMission _resMission;

	[CanBeNull]
	private MissionData _missionData;

	public void Set(ResourceShopItem parent, ResourceMission resMission, MissionData missionData)
	{
	}

	public void OnClickButton()
	{
	}

	[AsyncStateMachine(typeof(_003CRewardProcess_003Ed__10))]
	private UniTaskVoid RewardProcess()
	{
		return default(UniTaskVoid);
	}

	private void DoShortCut()
	{
	}
}
