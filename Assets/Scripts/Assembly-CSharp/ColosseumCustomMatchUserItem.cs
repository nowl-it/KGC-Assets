using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Protocol;
using UnityEngine;
using UnityEngine.UI;

public class ColosseumCustomMatchUserItem : MonoBehaviour
{
	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CSetUser_003Ed__22 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public ColosseumCustomMatchUserItem _003C_003E4__this;

		public Action afterSet;

		private UniTask<Awesomepiece.Model.OtherPlayerDataResponseModel>.Awaiter _003C_003Eu__1;

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
	private ConditionalGroup _userItemConditionals;

	[SerializeField]
	private ProfileAvatar _profileAvatar;

	[SerializeField]
	private Text _castleName;

	[SerializeField]
	private Text _kingName;

	[SerializeField]
	private Image _leaderIcon;

	[SerializeField]
	private Button _kickButton;

	[SerializeField]
	private Button _infoButton;

	[SerializeField]
	private Button _foldButton;

	[SerializeField]
	private GameObject _readyGradiant;

	private LobbyPlayerData _playerData;

	private int _lastUserId;

	[HideInInspector]
	public int slotIdx;

	[HideInInspector]
	public bool isReady;

	[HideInInspector]
	public bool isUserSet;

	public int userId => 0;

	public bool isBot => false;

	public bool isHost => false;

	public void SetPlayerData(LobbyPlayerData player)
	{
	}

	private void SetMe(Action afterSet)
	{
	}

	[AsyncStateMachine(typeof(_003CSetUser_003Ed__22))]
	public UniTask SetUser(Action afterSet)
	{
		return default(UniTask);
	}

	public void SetBot(LobbyPlayerData player)
	{
	}

	public void SetKickButtonActive(bool v)
	{
	}

	public void SetFoldButtonActive(bool v)
	{
	}

	public void SetEmpty()
	{
	}

	public void SetReady(bool v)
	{
	}

	public void SetMe(bool v)
	{
	}

	public string GetEntireName()
	{
		return null;
	}

	public string GetUserName()
	{
		return null;
	}

	public int GetBotTier()
	{
		return 0;
	}

	public void OnClickInfoButton()
	{
	}

	public void OnClickKickButton()
	{
	}

	public void OnClickFoldButton()
	{
	}
}
