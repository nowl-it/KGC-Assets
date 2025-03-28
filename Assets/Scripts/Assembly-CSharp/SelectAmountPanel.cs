using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AwesomeData.Encrypted;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class SelectAmountPanel : MonoBehaviour, IClosable
{
	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CShow_003Ed__7 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder<int> _003C_003Et__builder;

		public SelectAmountPanel _003C_003E4__this;

		public int minValue;

		public int maxValue;

		public Action<ClickableShopItemIcon> iconSetFunc;

		public int startValue;

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
	private ClickableShopItemIcon _itemIcon;

	[SerializeField]
	private Text _amountText;

	[SerializeField]
	private Slider _slider;

	private EncryptedInt _curValue;

	private EncryptedInt _minValue;

	private EncryptedInt _maxValue;

	private int _asyncWaitingState;

	[AsyncStateMachine(typeof(_003CShow_003Ed__7))]
	public UniTask<int> Show(int startValue, int minValue, int maxValue, Action<ClickableShopItemIcon> iconSetFunc)
	{
		return default(UniTask<int>);
	}

	public void OnSliderValueChanged()
	{
	}

	private void UpdateAmountText()
	{
	}

	private void SetValue(int value)
	{
	}

	public void OnClickPlus(bool all)
	{
	}

	public void OnClickMinus(bool all)
	{
	}

	public bool Close()
	{
		return false;
	}

	public void OnClickClose()
	{
	}

	public void OnClickConfirm()
	{
	}
}
