using System;

namespace Awesomepiece.Model
{
	[Serializable]
	public class AuthResponseModel : ResponseModel
	{
		public string accessToken;

		public string expiredAt;

		public string seed;

		public string serverTime;

		public string blockedUntilAt;

		public string blockedComment;

		public string loginId;

		public DateTime expiredAt_ => default(DateTime);

		public DateTime serverTime_ => default(DateTime);

		public DateTime blockedUntilAt_ => default(DateTime);
	}
}
