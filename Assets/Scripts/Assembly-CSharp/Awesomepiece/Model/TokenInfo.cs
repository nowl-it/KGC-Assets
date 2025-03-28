using System;

namespace Awesomepiece.Model
{
	[Serializable]
	public class TokenInfo
	{
		public string type;

		public int count;

		public string expiredAt;

		public DateTime expiredAt_ => default(DateTime);
	}
}
