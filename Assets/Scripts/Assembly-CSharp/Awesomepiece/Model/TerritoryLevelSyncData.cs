using System;

namespace Awesomepiece.Model
{
	[Serializable]
	public class TerritoryLevelSyncData
	{
		public int unitId;

		public int syncLevel;

		public int syncPotentialTier;

		public string untilAt;

		public DateTime untilAt_ => default(DateTime);
	}
}
