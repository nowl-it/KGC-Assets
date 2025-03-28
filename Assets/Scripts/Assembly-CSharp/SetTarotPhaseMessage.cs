using System.Collections.Generic;
using Awesomepiece.Model;

public class SetTarotPhaseMessage : BaseMessage
{
	public List<int> choiceTarotList;

	public CommonData.ChoiceUserSelectorType choiceUserSelector;

	public string choiceUserId;
}
