using System.Collections.Generic;

public class Dev_SetNextTarotPoolMessage : DevMessage
{
	public List<int> tarotIds;

	public Dev_SetNextTarotPoolMessage()
		: base(null)
	{
	}
}
