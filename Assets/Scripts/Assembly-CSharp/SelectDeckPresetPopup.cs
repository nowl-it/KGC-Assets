using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnityEngine;

public class SelectDeckPresetPopup : MonoBehaviour, IClosable
{
	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CShowAsync_003Ed__8 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder<bool> _003C_003Et__builder;

		public SelectDeckPresetPopup _003C_003E4__this;

		public int sortingOrder;

		public int initialIdx;

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
	private DeckPreviewPanel _deck;

	public DeckSlotToggle deckSlotToggle;

	public Canvas canvas;

	private bool _waitForCallback;

	private bool _response;

	private int _sortingOrder;

	public void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	[AsyncStateMachine(typeof(_003CShowAsync_003Ed__8))]
	public UniTask<bool> ShowAsync(int initialIdx, int sortingOrder = 2)
	{
		return default(UniTask<bool>);
	}

	public void Reload()
	{
	}

	public void OnClickConfirm()
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
