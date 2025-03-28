using System;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

public class ResourceBabel : ResourceBase<ResourceBabel>
{
	private string _nameKey;

	public int theme;

	public List<int> openDays;

	public ResourceUnit.Region region;

	public int stageIdPrefix;

	public int maxFloor;

	public bool enabled;

	public string groupUnitSpriteName;

	private Sprite _groupUnitSprite;

	public string npcSpriteName;

	private Sprite _npcSprite;

	public string babelFlagSpriteName;

	private Sprite _babelFlagSprite;

	public string babelBannerSpriteName;

	public static int SmallestMaxFloor;

	private static Dictionary<int, ResourceBabel> _babelDict;

	public new string name => null;

	public Sprite groupUnitSprite => null;

	public Sprite npcSprite => null;

	public Sprite babelFlagSprite => null;

	public static ResourceBabel DefaultBabel => null;

	public override void Init(XmlNode n)
	{
	}

	public new static ResourceBabel Get(int theme)
	{
		return null;
	}

	public new static List<ResourceBabel> GetAll(Func<ResourceBabel, bool> checkFunc = null)
	{
		return null;
	}

	public static void Load(Action callback = null)
	{
	}
}
