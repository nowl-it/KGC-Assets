using System;
using System.Collections.Generic;
using Awesomepiece.Model;

public class BuyItemPanel_Voucher : BuyItemPanel
{
	public List<UseVoucherPanel> voucherPanels;

	private List<ResourceInventoryItem> _resInventoryItems;

	private Action<UseInventoryResponseModel> _afterUseCallback;

	public new void Show(int shopItemId, string title, string buyCompleteText)
	{
	}

	public void SetCallbacks(Func<bool> checkRemainCountCallback, Action<BuyResponseModel> afterBuyCallback, Action<UseInventoryResponseModel> afterUseCallback)
	{
	}

	public override bool Close()
	{
		return false;
	}
}
