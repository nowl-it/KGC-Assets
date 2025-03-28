using System;

namespace Awesomepiece.Model
{
	[Serializable]
	public class ClanRaidDeckRequestModel
	{
		public int[] deck;

		public int[] potential;

		public int[] buildingLevels;

		public int[] artifactIds;

		public int supporterAccountId;

		public int supportUnitId;
	}
}
