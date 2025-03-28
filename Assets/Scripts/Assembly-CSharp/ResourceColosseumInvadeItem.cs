using System;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

public class ResourceColosseumInvadeItem : ResourceBase<ResourceColosseumInvadeItem>
{
	private XmlNode _xmlNode;

	private int _inheritFrom;

	public int unitId;

	public int unitCount;

	public int tier;

	public int showTier;

	public int theme;

	public bool isBoss;

	public int abilityExp;

	public List<BuffOption> buffOptionList;

	public List<WorldTrigger> worldTriggerList;

	private readonly List<Func<BattleManager, WorldTriggerBundle, string>> _paramFuncs;

	private string _spriteName;

	private Sprite _iconSprite;

	private string _descKey;

	public int reqInvadePoint;

	public int tierUpId;

	public bool hide;

	public int eventTriggerId;

	private bool _showInvadeResultText;

	public Vector2 shopUnitSpriteOffset;

	public int globalEventTrigger;

	public List<WorldTrigger> globalWorldTriggerList;

	public int getShowingTier => 0;

	public Sprite iconSprite => null;

	public string desc => null;

	public override void Init(XmlNode n)
	{
	}

	public string GetDesc(BattleManager battle, Color color = default(Color))
	{
		return null;
	}

	public static ResourceColosseumInvadeItem PickRandomColosseumInvadeItem(int theme, int tier, int? seed = null)
	{
		return null;
	}

	public static void Load(Action callback = null)
	{
	}
}
