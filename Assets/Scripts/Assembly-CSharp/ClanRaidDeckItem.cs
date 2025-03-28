using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Awesomepiece.Model;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class ClanRaidDeckItem : MonoBehaviour
{
	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003COnClickDelete_003Ed__23 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public ClanRaidDeckItem _003C_003E4__this;

		private UniTask<bool>.Awaiter _003C_003Eu__1;

		private UniTask<ClanRaidDeckInfoResponseModel>.Awaiter _003C_003Eu__2;

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
	private struct _003CTestResetDeckBattleCount_003Ed__24 : IAsyncStateMachine
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
	private GameObject _hasDeckObject;

	[SerializeField]
	private ConditionalGroup _selectedConditionals;

	[SerializeField]
	private Text _deckNameText;

	[SerializeField]
	private Image _levelImage;

	[SerializeField]
	private Image _unitImage;

	[SerializeField]
	private Text _levelText;

	[SerializeField]
	private FlexibleUIElements _itemElements;

	[SerializeField]
	private ConditionalGroup _potentialConditionals;

	[SerializeField]
	private Image _potentialIconImage;

	[SerializeField]
	private Text _slotLeftCountText;

	[SerializeField]
	private Text _divinePowerText;

	[SerializeField]
	private ConditionalGroup _cannotUseConditional;

	[SerializeField]
	private ConditionalGroup _retryConditional;

	[SerializeField]
	private ConditionalImageColor[] _remainCountConditional;

	public int index;

	private ClanRaidDeckInfo _deckInfo;

	private Action _onClick;

	public void SetDeck(ClanRaidDeckInfo deckInfo, Action onClick, bool showStatus = true, bool isPracticeBattle = false)
	{
	}

	private void SetRemainCount(int v)
	{
	}

	public void SetSelected(bool v)
	{
	}

	public void SetSelected(int v)
	{
	}

	public int GetSelectedCondValue()
	{
		return 0;
	}

	public void OnClick()
	{
	}

	[AsyncStateMachine(typeof(_003COnClickDelete_003Ed__23))]
	public void OnClickDelete()
	{
	}

	[AsyncStateMachine(typeof(_003CTestResetDeckBattleCount_003Ed__24))]
	public void TestResetDeckBattleCount()
	{
	}
}
