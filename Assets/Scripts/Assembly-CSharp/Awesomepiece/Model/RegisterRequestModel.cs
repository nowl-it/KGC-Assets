using System;

namespace Awesomepiece.Model
{
	[Serializable]
	public class RegisterRequestModel
	{
		public int type;

		public string id;

		public string userName;

		public string castleName;

		public int kingPostfix;

		public int castlePostfix;
	}
}
