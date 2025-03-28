using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Awesomepiece.Model;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class ClanRaidSelectDeckPanel : MonoBehaviour, IClosable
{
	private enum State
	{
		DeckPreview = 0,
		FieldPreview = 1,
		BossPreview = 2
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CSetSupporter_003Ed__37 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public int unit;

		private UniTask<ClanRaidSupporterSettingResponseModel>.Awaiter _003C_003Eu__1;

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
	private ClanRaidDeckPreviewPanel _deckPreviewPanel;

	[SerializeField]
	private ClanRaidDeckFieldPreviewPanel _fieldPreviewPanel;

	[SerializeField]
	private ClanRaidBossInfoPanel _bossPreviewPanel;

	[SerializeField]
	private Text _deckNameText;

	[SerializeField]
	private ConditionalGroup _deckNameConditionals;

	[SerializeField]
	private GameObject _deckButtons;

	[SerializeField]
	private GameObject _deckDataButtonBlackMask;

	[SerializeField]
	private GameObject _fieldDataButtonBlackMask;

	[SerializeField]
	private ConditionalGroup _startClanRaidConditionals;

	[SerializeField]
	private UIGridView _decksGridView;

	[SerializeField]
	private Text _deckSlotCountText;

	[SerializeField]
	private GameObject _partition;

	[SerializeField]
	private Text _remainCountText;

	[SerializeField]
	private ConditionalGroup _battleConditionalGroup;

	[SerializeField]
	private Border _startTextBorder;

	[SerializeField]
	private UIFitter[] _fitters;

	[HideInInspector]
	public int selectedDeckIdx;

	private List<ClanRaidDeckInfo> _clanRaidDeckInfos;

	private State _state;

	private State _lastStateExceptBossState;

	private int _bossId;

	private int _bossRemainHp;

	private int _selectedDifficulty;

	private bool _isPracticeBattle;

	private ClanRaidRetryInfo _retryInfo;

	public void Show(int bossId, int bossRemainHp, int selectedDifficulty, bool isPracticeBattle)
	{
	}

	public void Reload()
	{
	}

	public void ReloadDecks()
	{
	}

	private void ReloadDeckPreview()
	{
	}

	private void ReloadFieldPreview()
	{
	}

	private void ReloadBossPreview()
	{
	}

	private void SetState(State state)
	{
	}

	private void SetDeckItem(int index, GameObject go)
	{
	}

	public void OnClickDeckDataButton()
	{
	}

	public void OnClickFieldDataButton()
	{
	}

	public void OnClickSupporter()
	{
	}

	[AsyncStateMachine(typeof(_003CSetSupporter_003Ed__37))]
	private void SetSupporter(int unit)
	{
	}

	public void OnClickNextBoss(bool right)
	{
	}

	public void OnClickStart()
	{
	}

	public void OnClickStartImpl()
	{
	}

	public bool CanUseDeck()
	{
		return false;
	}

	public void MoveToDeckPanel()
	{
	}

	public void OnClickClose()
	{
	}

	public bool Close()
	{
		return false;
	}
}
