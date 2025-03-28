using System;

namespace Awesomepiece.Model
{
	[Serializable]
	public class CreateClanResponseModel : ResponseModel
	{
		public ClanModel clan;

		public int role;

		public int playerGold;
	}
}
