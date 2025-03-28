using System.Collections.Generic;
using Awesomepiece.Model;

public class TarotParamsMessage : BaseMessage
{
	public CommonData.TarotParams tarotParams;

	public Dictionary<string, CommonData.TarotParams> botParams;
}
