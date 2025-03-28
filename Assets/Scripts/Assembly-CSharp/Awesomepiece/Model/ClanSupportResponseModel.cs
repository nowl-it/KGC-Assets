using System;
using System.Collections.Generic;

namespace Awesomepiece.Model
{
	[Serializable]
	public class ClanSupportResponseModel : ResponseModel
	{
		public List<ClanChatModel> chats;

		public int unitId;

		public int unitExp;

		public int playerLevel;

		public int playerExp;

		public int playerGold;

		public List<TokenInfo> tokens;
	}
}
