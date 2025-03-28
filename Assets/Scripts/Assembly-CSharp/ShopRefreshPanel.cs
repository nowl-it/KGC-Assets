using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using UnityEngine.UI;

public class ShopRefreshPanel : PopupPanel
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass19_0
	{
		public bool processed;

		internal void _003CBuyProcess_003Eb__0()
		{
		}
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CBuyProcess_003Ed__19 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public int id;

		public ShopRefreshPanel _003C_003E4__this;

		private _003C_003Ec__DisplayClass19_0 _003C_003E8__1;

		private UniTask<Awesomepiece.Model.BuyResponseModel>.Awaiter _003C_003Eu__1;

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
	private struct _003CRequestRefreshDailyShopByAd_003Ed__18 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		private UniTask<Awesomepiece.Model.ShopResponseModel>.Awaiter _003C_003Eu__1;

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

	public Text todayAdRemain;

	public Text todayCashRemain;

	public Text cashCost;

	public Button adButton;

	public Image adIcon;

	public Text adText;

	public Text freeText;

	public Button cashButton;

	public Text descText;

	public ConditionalImage adbuttonImage;

	public const int FIRST_REFRESH_ITEM_ID = 650;

	public new void Show()
	{
	}

	private void Update()
	{
	}

	public void Reload()
	{
	}

	private void Refresh()
	{
	}

	public void Hide()
	{
	}

	public void OnClickAdRefresh()
	{
	}

	public void OnClickCashRefresh()
	{
	}

	[AsyncStateMachine(typeof(_003CRequestRefreshDailyShopByAd_003Ed__18))]
	private void RequestRefreshDailyShopByAd()
	{
	}

	[AsyncStateMachine(typeof(_003CBuyProcess_003Ed__19))]
	public void BuyProcess(int id)
	{
	}

	public override bool Close()
	{
		return false;
	}

	public override void OnClickClose()
	{
	}

	private ResourceShopItem GetRefreshItem()
	{
		return null;
	}
}
