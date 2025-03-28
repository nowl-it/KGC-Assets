using System;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

public class ResourceColosseumAbility : ResourceBase<ResourceColosseumAbility>
{
	public enum Category
	{
		None = 0,
		BuildingLevel = 1,
		InvadeShop = 2,
		HighestLevel = 3,
		UnitRegionOrRole = 4,
		InvadeChapter = 5
	}

	public struct Value
	{
		public string key;

		public string value;
	}

	private XmlNode _xmlNode;

	private int _inheritFrom;

	private string _name;

	private string _descKey;

	private string _spriteName;

	public int tier;

	public int rerollCost;

	public List<WorldTrigger> worldTriggerList;

	public List<Category> categories;

	public int weight;

	private readonly List<Func<BattleManager, WorldTriggerBundle, string>> _paramFuncs;

	private Func<BattleManager, WorldTriggerBundle, string> _representativeValueFunc;

	public bool applyAfterBattle;

	public readonly Dictionary<string, Value> values;

	public int root => 0;

	public new string name => null;

	public string desc => null;

	public Sprite iconSprite => null;

	public override void Init(XmlNode n)
	{
	}

	public string GetDesc(BattleManager battle, Color color = default(Color))
	{
		return null;
	}

	public string GetRepresentativeValue(BattleManager battle)
	{
		return null;
	}

	public bool UseRepresentativeValue()
	{
		return false;
	}

	public int GetValueInt(string key, int @default = -1)
	{
		return 0;
	}

	public float GetValueFloat(string key, float @default = -1f)
	{
		return 0f;
	}

	public string GetValueText(string key, string @default = null)
	{
		return null;
	}

	public bool GetValueBool(string key, bool @default = false)
	{
		return false;
	}

	public bool HasValue(string key)
	{
		return false;
	}

	public static void Load(Action callback = null)
	{
	}
}
