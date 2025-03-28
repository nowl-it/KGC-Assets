using System;
using System.Collections.Generic;

namespace Awesomepiece.Model
{
	[Serializable]
	public class ClanRaidSupportModel
	{
		public int accountId;

		public int unitId;

		public int level;

		public int skin;

		public string userName;

		public int potential;

		public int potentialTier;

		public TreasureModel treasure;

		public List<AccessoryModel> accessories;
	}
}
