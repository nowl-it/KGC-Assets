using System;
using System.Collections.Generic;

namespace Awesomepiece.Model
{
	[Serializable]
	public class ClanChatResponseModel : ResponseModel
	{
		public List<ClanChatModel> chats;
	}
}
