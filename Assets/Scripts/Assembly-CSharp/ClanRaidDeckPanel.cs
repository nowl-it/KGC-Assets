using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Awesomepiece.Model;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class ClanRaidDeckPanel : PopupPanel
{
	private enum State
	{
		DeckPreview = 0,
		Empty = 1,
		FieldPreview = 2
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003COnClickCreateDeck_003Ed__43 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public ClanRaidDeckPanel _003C_003E4__this;

		private UniTask<bool>.Awaiter _003C_003Eu__1;

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

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003COnEndEdit_003Ed__47 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public ClanRaidDeckPanel _003C_003E4__this;

		private UniTaskVoid.Awaiter _003C_003Eu__1;

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

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CSetSupporter_003Ed__45 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public int unit;

		public ClanRaidDeckPanel _003C_003E4__this;

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

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CTestResetDeckSetCount_003Ed__50 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

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
	private GameObject _emptyDeckPreviewPanel;

	[SerializeField]
	private ClanRaidDeckFieldPreviewPanel _fieldPreviewPanel;

	[SerializeField]
	private Text _emptyDeckDescText;

	[SerializeField]
	private Text _emptyDeckItemText;

	[SerializeField]
	private InputField _deckNameText;

	[SerializeField]
	private Text _createDeckButtonText;

	[SerializeField]
	private Button _createDeckButton;

	[SerializeField]
	private GameObject _deckInfos;

	[SerializeField]
	private GameObject _deckDataButtonBlackMask;

	[SerializeField]
	private GameObject _fieldDataButtonBlackMask;

	[SerializeField]
	private UIGridView _decksGridView;

	[SerializeField]
	private Text _deckSlotCountText;

	[SerializeField]
	private Image _supportUnitAvatarImage;

	[SerializeField]
	private Text _supportUnitStateText;

	[SerializeField]
	private Text _supportUnitLevelText;

	[SerializeField]
	private ConditionalGroup _supportUnitPotentialConditionals;

	[SerializeField]
	private ConditionalGroup _deckNameConditionals;

	[SerializeField]
	private Button _supportUnitButton;

	[SerializeField]
	private Text _clanRaidRemainTimeText;

	[SerializeField]
	private ConditionalGroup _earlyAccessModeCond;

	[HideInInspector]
	public int selectedDeckIdx;

	private List<ClanRaidDeckInfo> _clanRaidDeckInfos;

	private State _state;

	private State _lastStateExceptEmpty;

	private bool _awakened;

	private void Update()
	{
	}

	private void ReloadCallback()
	{
	}

	public void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	public override void Show()
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

	private void ReloadEmpty()
	{
	}

	private void ReloadFieldPreview()
	{
	}

	private void ReloadSupportUnit()
	{
	}

	private void SetState(State state)
	{
	}

	private void SetDeckItem(int index, GameObject go)
	{
	}

	private void SelectDeckItem(int index, bool invokeOnClick)
	{
	}

	public void OnClickDeckDataButton()
	{
	}

	public void OnClickFieldDataButton()
	{
	}

	[AsyncStateMachine(typeof(_003COnClickCreateDeck_003Ed__43))]
	public void OnClickCreateDeck()
	{
	}

	public void OnClickSupporter()
	{
	}

	[AsyncStateMachine(typeof(_003CSetSupporter_003Ed__45))]
	private void SetSupporter(int unit)
	{
	}

	public void CheckDeckReset(Action yesCallback)
	{
	}

	[AsyncStateMachine(typeof(_003COnEndEdit_003Ed__47))]
	public void OnEndEdit()
	{
	}

	public void OnValueChanged()
	{
	}

	private void UpdateRemainTime()
	{
	}

	[AsyncStateMachine(typeof(_003CTestResetDeckSetCount_003Ed__50))]
	public void TestResetDeckSetCount()
	{
	}

	public override bool Close()
	{
		return false;
	}
}
