using System.Collections.Generic;

public class EventResultMessage : UserMessage
{
	public CommonData.ItemType type;

	public int itemId;

	public List<CommonData.ItemOption> options;
}
