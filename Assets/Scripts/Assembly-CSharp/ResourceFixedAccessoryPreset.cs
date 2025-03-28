using System.Xml;
using Awesomepiece.Model;

public class ResourceFixedAccessoryPreset : ResourceBase<ResourceFixedAccessoryPreset>
{
	public int synergy;

	public int type;

	public ResourceTreasure.Rarity rarity;

	public int level;

	public AccessoryModel.AccessoryData data;

	public XmlNode xmlNode;

	public int inheritFrom;

	public override void Init(XmlNode n)
	{
	}

	public static void Load()
	{
	}
}
