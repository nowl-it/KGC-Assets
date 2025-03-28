using System;
using System.Collections.Generic;

namespace Awesomepiece.Model
{
	[Serializable]
	public class CardResponseModel : ResponseModel
	{
		public int unitId;

		public int level;

		public int exp;

		public int potentialTier;

		public List<int> skins;

		public int currentSkin;

		public int playerGold;

		public int soul;

		public int originLevel;

		public int originPotentialTier;

		public bool isLevelSynced;

		public string createdAt;
	}
}
