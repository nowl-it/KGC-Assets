using System;
using System.Collections.Generic;

namespace Awesomepiece.Model
{
	[Serializable]
	public class CardInfo
	{
		public int cardId;

		public int level;

		public int skin;

		public int potentialTier;

		public bool isLevelSyncApplied;

		public TreasureModel treasure;

		public List<AccessoryModel> accessories;
	}
}
