using System;
using System.Collections.Generic;

namespace Awesomepiece.Model
{
	[Serializable]
	public class ClanRaidDeckData
	{
		public ClanRaidCardInfo[] cards;

		public int[] buildings;

		public GameCompleteRequestModel.RoundData roundData;

		public List<ArtifactModel> artifacts;

		public int[] potentials;

		public int[] territoryStatBuffPers;

		public float divinePower;
	}
}
