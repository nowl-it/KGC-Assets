using System;
using System.Collections.Generic;
using System.Xml;

public class ResourceLocalPushItem : ResourceBase<ResourceLocalPushItem>
{
	public enum Type
	{
		None = 0,
		CardLevelUpItem = 1
	}

	public struct Value
	{
		public string key;

		public string value;
	}

	public struct Condition
	{
		public string condtionType;

		public string conditionValue;
	}

	private Dictionary<string, Value> _values;

	private string _content;

	private string _title;

	private string _subTitle;

	private string _data;

	private string _onOffKey;

	private bool _isRepeat;

	private float _repeatInterval;

	private bool _hasManyData;

	private Condition _pushCondition;

	public string content => null;

	public string title => null;

	public string subTitle => null;

	public string onOffKey => null;

	public string data => null;

	public bool repeat => false;

	public double repeatInterval => 0.0;

	public Condition pushCondition => default(Condition);

	public bool hasManyData => false;

	public override void Init(XmlNode n)
	{
	}

	public static void Load(Action callback = null)
	{
	}
}
