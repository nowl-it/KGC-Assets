using System;

namespace Awesomepiece.Model
{
	[Serializable]
	public class ChangeNicknameRequestModel
	{
		public string userName;

		public string castleName;

		public int kingPostfix;

		public int castlePostfix;
	}
}
