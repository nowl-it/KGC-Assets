using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Awesomepiece.Model;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class ClanRankingItem : MonoBehaviour
{
	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003COnClick_003Ed__13 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public ClanRankingItem _003C_003E4__this;

		private UniTask<ClanResponseModel>.Awaiter _003C_003Eu__1;

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

	public ClanMark clanMark;

	public Text clanName;

	public Text clanRank;

	public ConditionalImage bossFrame;

	public Text clanBossTier;

	public Text bossStage;

	public Text bossHPPer;

	public Gauge bossHPGauge;

	public Image bossIcon;

	private ClanRankingResponseModel.ClanRankingData _rankingData;

	private bool isMyClan;

	public void Set(ClanRankingResponseModel.ClanRankingData rankingData, bool my)
	{
	}

	public void Set(int markId, int tier, int rank, int score)
	{
	}

	[AsyncStateMachine(typeof(_003COnClick_003Ed__13))]
	public void OnClick()
	{
	}

	private void SetBossData()
	{
	}
}
