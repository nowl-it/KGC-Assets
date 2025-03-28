using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class DeckSlotToggle : MonoBehaviour
{
	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003COnSlotNameEndEdit_003Ed__35 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public DeckSlotToggle _003C_003E4__this;

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
	private struct _003CRequestBuyDeckSlot_003Ed__33 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public DeckSlotToggle _003C_003E4__this;

		private UniTask<Awesomepiece.Model.ResponseModel>.Awaiter _003C_003Eu__1;

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
	private struct _003CSetDeckSlotName_003Ed__36 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

		public DeckSlotToggle _003C_003E4__this;

		public string name;

		public int idx;

		public InputField revertTo;

		private UniTask<Awesomepiece.Model.DeckResponseModel>.Awaiter _003C_003Eu__1;

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

	public RectTransform rectTransform;

	public InputField deckNameInput;

	public Image nameInputIcon;

	public Toggle[] toggles;

	public Text[] toggleText;

	public GameObject[] toggleLockIcon;

	public Button changeSlotPageButton;

	private bool _deckPanel;

	private bool _extended;

	private bool _inited;

	private bool _showingBuySlotPopup;

	private Action _onExtended;

	public int curPage { get; private set; }

	public void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void SetDeafultState()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public static int GetDeckPageByToggleIndex(int index)
	{
		return 0;
	}

	public void Init(bool deckPanel)
	{
	}

	public void SetOnExtended(Action onExtended)
	{
	}

	public void ReloadToggles()
	{
	}

	private void Update()
	{
	}

	public void OnToggle(int idx)
	{
	}

	public void OnToggle(int idx, bool force, bool expandSlot = true)
	{
	}

	public void ReloadDeckPanelDeckSlotToggle(bool extended, int idx = -1)
	{
	}

	public void OnClickChangeSlotPage()
	{
	}

	public void ChangeSlotPage()
	{
	}

	public void SetToggle(int idx)
	{
	}

	public void BuyDeckSlot()
	{
	}

	[AsyncStateMachine(typeof(_003CRequestBuyDeckSlot_003Ed__33))]
	public void RequestBuyDeckSlot()
	{
	}

	public void OnSlotNameChanged()
	{
	}

	[AsyncStateMachine(typeof(_003COnSlotNameEndEdit_003Ed__35))]
	public void OnSlotNameEndEdit()
	{
	}

	[AsyncStateMachine(typeof(_003CSetDeckSlotName_003Ed__36))]
	public UniTaskVoid SetDeckSlotName(int idx, string name, InputField revertTo)
	{
		return default(UniTaskVoid);
	}

	private bool CheckDeckNameValidity(string name)
	{
		return false;
	}
}
