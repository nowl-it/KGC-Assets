using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Awesomepiece.Model;
using UnityEngine;
using UnityEngine.UI;

public class ClanRaidProgressItem : MonoBehaviour
{
	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003COnClick_003Ed__8 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public ClanRaidProgressItem _003C_003E4__this;

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

	public Text nameText;

	public Text castleText;

	public Text scoreText;

	public PlayerProfile playerProfile;

	public Text timeText;

	private int _accountId;

	public void Set(ClanRaidMemberDamageSumModel data, int rank)
	{
	}

	public void SetMy()
	{
	}

	[AsyncStateMachine(typeof(_003COnClick_003Ed__8))]
	public void OnClick()
	{
	}
}
