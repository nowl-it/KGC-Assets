using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class ColosseumOpenEventPanel : MonoBehaviour
{
	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003COnClickGetReward_003Ed__9 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public ColosseumOpenEventPanel _003C_003E4__this;

		public int index;

		private int _003CrewardedStatus_003E5__2;

		private UniTask<Awesomepiece.Model.RewardListResponseModel>.Awaiter _003C_003Eu__1;

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
	private Text _timeLeftText;

	[SerializeField]
	private ClickableShopItemIcon[] _rewardIcons;

	[SerializeField]
	private Text[] _rewardRequirePointTexts;

	[SerializeField]
	private ConditionalGroup[] _rewardedConditionals;

	[SerializeField]
	private Image _missionPointGauge;

	[SerializeField]
	private Text _currentMissionPointText;

	private bool processing;

	public void Init()
	{
	}

	public void Reload()
	{
	}

	[AsyncStateMachine(typeof(_003COnClickGetReward_003Ed__9))]
	private void OnClickGetReward(int index)
	{
	}

	private void Update()
	{
	}

	private void UpdateLeftTimeText()
	{
	}
}
