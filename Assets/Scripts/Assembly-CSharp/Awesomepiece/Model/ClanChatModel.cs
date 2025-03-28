using System;

namespace Awesomepiece.Model
{
	[Serializable]
	public class ClanChatModel
	{
		public int seqId;

		public int type;

		public int accountId;

		public string sender;

		public string message;

		public int targetUnit;

		public int count;

		public int maxCount;

		public string createdAt;

		public bool canSupport;

		public DateTime createdAt_ => default(DateTime);
	}
}
