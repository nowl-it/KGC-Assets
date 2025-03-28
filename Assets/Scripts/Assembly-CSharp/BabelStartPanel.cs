using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Awesomepiece.Model;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class BabelStartPanel : MonoBehaviour, IClosable
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass20_0
	{
		public BabelStartPanel _003C_003E4__this;

		public GameStartRequestModel.DeckInfo requestDeckInfo;

		internal void _003COnClickStart_003Eb__0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass21_0
	{
		public BabelStartPanel _003C_003E4__this;

		public GameStartRequestModel.DeckInfo requestDeckInfo;

		internal void _003COnClickAutoStart_003Eb__0()
		{
		}
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003COnClickAutoStart_003Ed__21 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public BabelStartPanel _003C_003E4__this;

		private _003C_003Ec__DisplayClass21_0 _003C_003E8__1;

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
	private struct _003COnClickStart_003Ed__20 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public BabelStartPanel _003C_003E4__this;

		private _003C_003Ec__DisplayClass20_0 _003C_003E8__1;

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

	[SerializeField]
	private FlexibleUIElements _babelStartPanelItems;

	[SerializeField]
	private ItemInfoPanel _itemInfoPanel;

	[SerializeField]
	private DeckPreviewPanel _deckPreviewPanel;

	[SerializeField]
	private CanvasGroup _canvasGroup;

	public Button autoSelectButton;

	[Header("연출 관련 변수")]
	[SerializeField]
	private float _panelFadeOutTime;

	[SerializeField]
	private float _floorScrollTimePerFloor;

	[SerializeField]
	private float _screenFadeOutTime;

	public ResourceBabelFloor targetFloor;

	public FlexibleUIElements babelStartPanelItems => null;

	public ItemInfoPanel itemInfoPanel => null;

	public DeckPreviewPanel deckPreviewPanel => null;

	public void Show(ResourceBabelFloor resBabelFloor)
	{
	}

	public void ReloadDeck()
	{
	}

	public void OnClickClose()
	{
	}

	public bool Close()
	{
		return false;
	}

	public void OnClickDeckPreview()
	{
	}

	[AsyncStateMachine(typeof(_003COnClickStart_003Ed__20))]
	public void OnClickStart()
	{
	}

	[AsyncStateMachine(typeof(_003COnClickAutoStart_003Ed__21))]
	public void OnClickAutoStart()
	{
	}

	public void SetItemSelected(BabelStartPanelItem itemUI)
	{
	}

	private void SetBabelStartPanelItemsState()
	{
	}

	private void SetBabelStartPanelItemsState(BabelStartPanelItem selectedItemUI)
	{
	}
}
