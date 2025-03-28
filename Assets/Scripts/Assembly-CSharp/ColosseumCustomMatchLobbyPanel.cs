using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using JetBrains.Annotations;
using Protocol;
using UnityEngine;
using UnityEngine.UI;

public class ColosseumCustomMatchLobbyPanel : MonoBehaviour, IClosable
{
	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CHandleLobbyDataMessage_003Ed__14 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public ColosseumCustomMatchLobbyPanel _003C_003E4__this;

		public LobbyDataMessage message;

		private UniTask.Awaiter _003C_003Eu__1;

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
	private GameObject _userItemPrefab;

	[SerializeField]
	private RectTransform _userItemLayout;

	[SerializeField]
	private DeckPreviewPanel _deckPreviewPanel;

	[SerializeField]
	private ConditionalGroup _gameStartButtonConditional;

	[SerializeField]
	private ConditionalGroup _readyButtonConditional;

	[SerializeField]
	private ConditionalGroup _earlyAccessModeConditional;

	[SerializeField]
	private Text _enterCode;

	[SerializeField]
	private ColosseumCustomMatchSelectBotPopup _selectBotPopup;

	private bool _initialized;

	private readonly List<ColosseumCustomMatchUserItem> _users;

	private ColosseumCustomMatchUserItem _me;

	private bool _readyToClose;

	private void Awake()
	{
	}

	public void Show()
	{
	}

	public void SetEnterCode(string code)
	{
	}

	[AsyncStateMachine(typeof(_003CHandleLobbyDataMessage_003Ed__14))]
	public void HandleLobbyDataMessage(LobbyDataMessage message)
	{
	}

	public void HandleExitMessage(LobbyExitMessage message)
	{
	}

	public void HandleReadyMessage(LobbyReadyMessage message)
	{
	}

	public void HandleCustomMatchGameStartMessage(CustomMatchGameStartMessage message)
	{
	}

	public void OnClickReady()
	{
	}

	public void OnClickGameStart()
	{
	}

	public void OnClickCopyCode()
	{
	}

	public void OnClickClose(bool closeAll)
	{
	}

	public void ShowSelectBotPopup(ColosseumCustomMatchUserItem item)
	{
	}

	private void ReloadConditional()
	{
	}

	public void ReloadDeck()
	{
	}

	public ColosseumCustomMatchUserItem GetUserItem([NotNull] Func<ColosseumCustomMatchUserItem, bool> checkFunc)
	{
		return null;
	}

	private void Clear()
	{
	}

	public bool Close()
	{
		return false;
	}

	public void ForceClose()
	{
	}

	public void Minimize()
	{
	}
}
