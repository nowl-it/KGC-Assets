using System;
using System.Collections.Generic;
using System.Xml;
using Awesomepiece;

public class ResourceTerritoryTradeShop : ResourceBase<ResourceTerritoryTradeShop>
{
	public class TradeItem
	{
		public Reward reward;

		public Reward currency;

		public int buyLimit;

		public int itemId;

		public int version;
	}

	public List<Reward> availableCurrencies;

	public List<TradeItem> tradeItems;

	public string availableCurrenciesNames => null;

	public override void Init(XmlNode n)
	{
	}

	public static void Load(Action callback = null)
	{
	}
}
