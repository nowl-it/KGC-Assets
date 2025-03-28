using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class ArenaWinRewardUIItem : MonoBehaviour
{
	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003COnClickReceive_003Ed__9 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public ArenaWinRewardUIItem _003C_003E4__this;

		private UniTask<Awesomepiece.Model.ArenaWinRewardResponseModel>.Awaiter _003C_003Eu__1;

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
	private Text _winRewardStepText;

	[SerializeField]
	private Text _winCountText;

	[SerializeField]
	private List<ClickableShopItemIcon> _winRewards;

	[SerializeField]
	private ConditionalGroup _receiveStateCond;

	private ResourceArenaSetting.WinReward _winReward;

	private int _step;

	private static bool _requestProcess;

	public void Set(ResourceArenaSetting.WinReward winReward, int step)
	{
	}

	private void Reload()
	{
	}

	[AsyncStateMachine(typeof(_003COnClickReceive_003Ed__9))]
	public void OnClickReceive()
	{
	}
}
