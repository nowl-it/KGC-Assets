using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Awesomepiece;
using UnityEngine;
using UnityEngine.UI;

public class BuyInvasionPassPanel : MonoBehaviour, IClosable
{
	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003COnClickBuyPass_003Ed__7 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public BuyInvasionPassPanel _003C_003E4__this;

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
	private Text _titleText;

	[SerializeField]
	private FlexibleUIElements _rewardsPreviewElements;

	[SerializeField]
	private Text _priceText;

	private int _passIndex;

	private int _pass;

	public void Show(int passIndex, int pass)
	{
	}

	private ResourceShopItem GetPassShopItem(int passIndex)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003COnClickBuyPass_003Ed__7))]
	public void OnClickBuyPass()
	{
	}

	public bool Close()
	{
		return false;
	}

	public void OnClickClose()
	{
	}

	public static string GetPassName(int passIndex)
	{
		return null;
	}

	public static List<Reward> GetPassAllRewards(int passIndex)
	{
		return null;
	}
}
