using System;

namespace Awesomepiece.Model
{
	[Serializable]
	public class LoginRequestModel
	{
		public string locale;

		public string platform;

		public string deviceInfo;

		public string version;

		public string cookie;
	}
}
