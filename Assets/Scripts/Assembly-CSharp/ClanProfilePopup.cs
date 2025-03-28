using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Awesomepiece.Model;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class ClanProfilePopup : MonoBehaviour, IClosable
{
	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003COnClickJoin_003Ed__8 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public ClanProfilePopup _003C_003E4__this;

		private UniTask<bool>.Awaiter _003C_003Eu__1;

		private UniTask<ClanResponseModel>.Awaiter _003C_003Eu__2;

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
	[ComponentConnect]
	private ClanProfilePanel _clanProfilePanel;

	[SerializeField]
	[ComponentConnect]
	private Button _joinButton;

	[ComponentConnect]
	[SerializeField]
	private Text _joinButtonText;

	[SerializeField]
	[ComponentConnect]
	private Text _levelLimitText;

	private ClanModel _clanModel;

	public static Dictionary<int, ClanResponseModel> cachedOtherClanModel;

	public void Show(ClanModel clan, bool joined)
	{
	}

	private void ReloadJoinButton(bool joined)
	{
	}

	[AsyncStateMachine(typeof(_003COnClickJoin_003Ed__8))]
	public void OnClickJoin()
	{
	}

	public bool Close()
	{
		return false;
	}

	public void OnClickClose()
	{
	}
}
