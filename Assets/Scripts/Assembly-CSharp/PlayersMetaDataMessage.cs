using System.Collections.Generic;
using Awesomepiece.Model;

public class PlayersMetaDataMessage : BaseMessage
{
	public int myIdIdx;

	public bool tarotEnabled;

	public List<CommonData.ChoiceUserSelectorType> tarotSelectors;

	public CommonData.PlayerColosseumMetaData[] playerMetaData;
}
