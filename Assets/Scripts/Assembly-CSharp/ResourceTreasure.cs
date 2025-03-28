using System;
using System.Xml;
using Awesomepiece.Model;
using UnityEngine;

public class ResourceTreasure : ResourceBase<ResourceTreasure>
{
	public enum Rarity
	{
		None = 0,
		Common = 1,
		Rare = 2,
		Special = 3
	}

	public string subNameKey;

	public string descKey;

	public string skillNameKey;

	public string skillDescKey;

	public ResourceUnit.Role targetRole;

	public Rarity rarity;

	public bool limitedEdition;

	public int buffDataStartID;

	public string iconName;

	public string illustName;

	public string illustBGName;

	public string cardIllustName;

	public string inventoryIllustName;

	public string cardIllustFrameName;

	public string cardIllustFrameName_Upgrade;

	public string skillIconName;

	public int minVersion;

	public float illustOffsetX;

	public float illustOffsetY;

	public float illustScale;

	public float cardIllustOffsetX;

	public float cardIllustOffsetY;

	public float cardIllustScale;

	private Sprite _icon;

	private Sprite _illust;

	private Sprite _illustBG;

	private Sprite _cardIllust;

	private Sprite _inventoryIllust;

	private Sprite _skillIcon;

	private Sprite _cardIllustFrame;

	private Sprite _cardIllustFrame_Upgrade;

	public Color subNameColor;

	public Color mainColor;

	public string subName => null;

	public bool hasSubName => false;

	public string desc => null;

	public string skillName => null;

	public string skillDesc => null;

	public Vector3 illustOffset => default(Vector3);

	public Vector3 cardIllustOffset => default(Vector3);

	public Sprite icon => null;

	public Sprite illust => null;

	public Sprite illustBG => null;

	public bool hasIllust => false;

	public Sprite cardIllust => null;

	public Sprite inventoryIllust => null;

	public Sprite skillIcon => null;

	public Sprite cardIllustFrame => null;

	public Sprite cardIllustFrame_Upgrade => null;

	public override void Init(XmlNode n)
	{
	}

	public static void Load(Action callback = null)
	{
	}

	public Sprite GetIllustFrame(TreasureModel treasure)
	{
		return null;
	}

	public Sprite GetIllustFrame(int overcome)
	{
		return null;
	}
}
