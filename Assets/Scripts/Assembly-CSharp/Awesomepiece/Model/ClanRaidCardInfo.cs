using System;
using System.Collections.Generic;

namespace Awesomepiece.Model
{
	[Serializable]
	public class ClanRaidCardInfo
	{
		public int unitId;

		public int level;

		public int skin;

		public int potential;

		public int potentialTier;

		public bool isLevelSyncApplied;

		public bool supported;

		public int accountId;

		public string accountName;

		public TreasureModel treasure;

		public List<AccessoryModel> accessories;
	}
}
