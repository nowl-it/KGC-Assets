using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Awesomepiece.Model;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class BuyItemPanel : MonoBehaviour, IClosable
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass16_0
	{
		public bool processed;

		internal void _003CBuyProcess_003Eb__0()
		{
		}
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CBuyProcess_003Ed__16 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public int id;

		public BuyItemPanel _003C_003E4__this;

		private _003C_003Ec__DisplayClass16_0 _003C_003E8__1;

		private ResourceShopItem _003CresShopItem_003E5__2;

		private UniTask<BuyResponseModel>.Awaiter _003C_003Eu__1;

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

	public Price buyPrice;

	public Text todayRemain;

	public Text titleText;

	public Text itemNameText;

	public Image itemIconImage;

	public Button buyButton;

	public GameObject partitionBackground;

	protected ResourceShopItem _resShopItem;

	protected string _buyCompleteText;

	protected Func<bool> _checkRemainCountCallback;

	protected Action<BuyResponseModel> _afterBuyCallback;

	public void Show(int itemId, string title, string buyCompleteText)
	{
	}

	public void Hide()
	{
	}

	public void SetRemainCount(int count)
	{
	}

	public void SetCallbacks(Func<bool> checkRemainCountCallback, Action<BuyResponseModel> afterBuyCallback)
	{
	}

	public void OnClickBuy()
	{
	}

	[AsyncStateMachine(typeof(_003CBuyProcess_003Ed__16))]
	private void BuyProcess(int id)
	{
	}

	public virtual bool Close()
	{
		return false;
	}

	public void OnClickClose()
	{
	}
}
