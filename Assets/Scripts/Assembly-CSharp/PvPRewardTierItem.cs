using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class PvPRewardTierItem : MonoBehaviour
{
	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CReward_003Ed__17 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public PvPRewardTierItem _003C_003E4__this;

		private UniTask<Awesomepiece.Model.PvPReceiveRewardResponseModel>.Awaiter _003C_003Eu__1;

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
	public Image fillCurrent;

	[ComponentConnect]
	public Image fillBest;

	[ComponentConnect]
	public ConditionalRoot gauge;

	[ComponentConnect]
	public Text tierPoint;

	[ComponentConnect]
	public Text halfPoint;

	[ComponentConnect]
	public Image tierIcon;

	[ComponentConnect]
	public Image starIcon;

	[ComponentConnect]
	public Text tierName;

	[ComponentConnect]
	public ConditionalRoot rewardButton;

	[ComponentConnect]
	public ImageTextPair reward;

	public IResourceRankTier tier { get; private set; }

	public void Init(IResourceRankTier tier, int curScore, int curTier, int bestScore, int bestTier, int rewardState)
	{
	}

	public void Reload()
	{
	}

	public void OnClickReward()
	{
	}

	[AsyncStateMachine(typeof(_003CReward_003Ed__17))]
	public void Reward()
	{
	}

	private bool IsFirstTier(IResourceRankTier tier)
	{
		return false;
	}

	private bool IsLastTier(IResourceRankTier tier)
	{
		return false;
	}
}
