using System;
using System.Collections.Generic;
using System.Xml;

public class ResourceAlchemyExchangeRatio : ResourceBase<ResourceAlchemyExchangeRatio>
{
	public enum CurrencyType
	{
		Labor = 0,
		Dust = 1,
		UnitExp = 2,
		UnitSoul = 3,
		None = 4
	}

	public string currency;

	public float ratio;

	public int limit;

	private static Dictionary<string, ResourceAlchemyExchangeRatio> _currencyData;

	public override void Init(XmlNode n)
	{
	}

	public static void Load(Action callback = null)
	{
	}

	public static ResourceAlchemyExchangeRatio Get(CurrencyType type)
	{
		return null;
	}

	public new static ResourceAlchemyExchangeRatio Get(int ratioId)
	{
		return null;
	}
}
