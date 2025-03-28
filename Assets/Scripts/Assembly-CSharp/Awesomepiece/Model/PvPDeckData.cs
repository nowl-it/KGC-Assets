using System;
using System.Collections.Generic;

namespace Awesomepiece.Model
{
	[Serializable]
	public class PvPDeckData
	{
		public CardInfo[] cards;

		public BuildingInfo[] buildings;

		public List<GameCompleteRequestModel.RoundData> rounds;

		public int[] potentials;

		public TreasureModel[] treasures;
	}
}
