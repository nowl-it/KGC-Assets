using System;

namespace Awesomepiece.Model
{
	[Serializable]
	public class BuySkinResponseModel : ResponseModel
	{
		public int skin;

		public int playerCash;

		public int playerSkinToken;
	}
}
