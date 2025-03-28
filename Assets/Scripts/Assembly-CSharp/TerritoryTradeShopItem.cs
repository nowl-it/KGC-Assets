using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Awesomepiece.Model;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class TerritoryTradeShopItem : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass12_0
	{
		public TerritoryTradeShopItem _003C_003E4__this;

		public TerritoryBuyTradeShopItemResponseModel ret;

		internal bool _003COnClickBuy_003Eb__0(TerritoryTradeShopItemData x)
		{
			return false;
		}

		internal void _003COnClickBuy_003Eb__1()
		{
		}

		internal bool _003COnClickBuy_003Eb__2(TerritoryTradeShopItemData x)
		{
			return false;
		}
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003COnClickBuy_003Ed__12 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public TerritoryTradeShopItem _003C_003E4__this;

		private _003C_003Ec__DisplayClass12_0 _003C_003E8__1;

		private UniTask<TerritoryBuyTradeShopItemResponseModel>.Awaiter _003C_003Eu__1;

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
	private Text _nameText;

	[SerializeField]
	private Text _buyLimitText;

	[SerializeField]
	private ImageTextPair _price;

	[SerializeField]
	private GameObject _soldOutObj;

	[SerializeField]
	private ConditionalGroup _buyButton;

	private int _buildingId;

	private int _resTradeShopId;

	private ResourceTerritoryTradeShop.TradeItem _tradeItem;

	private TerritoryTradeShopPanel _tradeShopPanel;

	private bool _isLocked;

	public void Set(int buildingId, int resTradeShopId, ResourceTerritoryTradeShop.TradeItem tradeItem, TerritoryTradeShopPanel tradeShopPanel, bool isLocked)
	{
	}

	[AsyncStateMachine(typeof(_003COnClickBuy_003Ed__12))]
	public void OnClickBuy()
	{
	}
}
