using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class TerritoryTradeShopPanel : TerritoryBuildingMenuBase
{
	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CClearAllBuyLimit_003Ed__19 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public TerritoryTradeShopPanel _003C_003E4__this;

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

	[SerializeField]
	private RectTransform _currencyItemsRoot;

	[SerializeField]
	private SimpleCurrencyItem _currencyItemPrefab;

	private List<SimpleCurrencyItem> _currencyItems;

	[SerializeField]
	private Image _buildingIllust;

	[SerializeField]
	private Text _refreshAtText;

	[SerializeField]
	private UIGridView _uiGridView;

	[SerializeField]
	private TabManager _tabManager;

	private List<TerritoryTradeShopItem> _shopItems;

	private ResourceTerritoryBuilding _resBuilding;

	private List<ResourceTerritoryTradeShop> _resTradeShop;

	private int _tradeShopIdx;

	public bool requestProcessing;

	private bool _currentIsLockedTab => false;

	public override void Show(TerritoryBuilding building)
	{
	}

	public void Reload(int idx = -1)
	{
	}

	private void ReloadCurrency()
	{
	}

	protected override void Update()
	{
	}

	public override bool Close()
	{
		return false;
	}

	[AsyncStateMachine(typeof(_003CClearAllBuyLimit_003Ed__19))]
	public void ClearAllBuyLimit()
	{
	}
}
