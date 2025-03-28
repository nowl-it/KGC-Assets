using System.Collections.Generic;

public class GiveItemRewardMessage : UserMessage
{
	public int itemId;

	public List<CommonData.ItemOption> options;
}
