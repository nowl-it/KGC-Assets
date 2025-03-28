using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Awesomepiece.Model;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class ClanPointRankingItem : MonoBehaviour
{
	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003COnClick_003Ed__8 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public ClanPointRankingItem _003C_003E4__this;

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

	public Text scoreText;

	private ClanPointRankingResponseModel.ClanPointRankingData _rankingData;

	private bool isMyClan;

	public void Set(ClanPointRankingResponseModel.ClanPointRankingData rankingData, bool my)
	{
	}

	public void Set(int markId, int tier, int rank, int score)
	{
	}

	[AsyncStateMachine(typeof(_003COnClick_003Ed__8))]
	public void OnClick()
	{
	}
}
