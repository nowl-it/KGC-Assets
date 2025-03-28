using System;

namespace Awesomepiece.Model
{
	[Serializable]
	public class DeckRequestModel
	{
		public int presetIdx;

		public int idx;

		public int unitId;

		public int[] deck;

		public int[] potential;
	}
}
