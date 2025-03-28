using System.Collections.Generic;
using System.Xml;

public class ResourceColosseumTarotSetting : ResourceBase<ResourceColosseumTarotSetting>
{
	public List<int> choiceRounds;

	public List<int> choiceTarotOptionCounts;

	public List<int> choiceTarotPool;

	public List<int> randomRounds;

	public List<int> randomTarotPool;

	public List<CommonData.ChoiceUserSelectorType> choiceUserSelectors;

	public override void Init(XmlNode n)
	{
	}

	public static void Load()
	{
	}
}
