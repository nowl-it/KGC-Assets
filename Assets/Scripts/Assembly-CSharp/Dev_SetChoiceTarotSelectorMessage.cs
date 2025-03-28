using System.Collections.Generic;

public class Dev_SetChoiceTarotSelectorMessage : DevMessage
{
	public List<int> selectorTypes;

	public Dev_SetChoiceTarotSelectorMessage()
		: base(null)
	{
	}
}
