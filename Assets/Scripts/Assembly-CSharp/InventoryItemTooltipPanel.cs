using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class InventoryItemTooltipPanel : ItemTooltipPanel
{
	public enum ButtonState
	{
		None = 0,
		InventoryUse = 1,
		Catalyst = 2,
		Polish = 3,
		Merge = 4,
		Reroll = 5
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CInventoryAction_003Ed__10 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public InventoryItemTooltipPanel _003C_003E4__this;

		private UseVoucherData _003CvoucherData_003E5__2;

		private UniTask<Awesomepiece.Model.UseInventoryResponseModel>.Awaiter _003C_003Eu__1;

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

	private ButtonState _buttonState;

	[SerializeField]
	private Button _button;

	[SerializeField]
	private ConditionalGroup _buttonStateCond;

	private ETCItemModel _item;

	private InventoryPanelItem _panelItem;

	private Action _buttonAction;

	public void Show(ETCItemModel etcItem, InventoryPanelItem panelItem)
	{
	}

	public void SetButtonState(ETCItemModel item)
	{
	}

	private void Reload()
	{
	}

	[AsyncStateMachine(typeof(_003CInventoryAction_003Ed__10))]
	private void InventoryAction()
	{
	}

	public void OnClickButton()
	{
	}

	private void OnDestroy()
	{
	}
}
