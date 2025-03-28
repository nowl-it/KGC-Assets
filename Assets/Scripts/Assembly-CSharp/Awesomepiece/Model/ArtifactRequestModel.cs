using System;

namespace Awesomepiece.Model
{
	[Serializable]
	public class ArtifactRequestModel
	{
		public int targetId;

		public int materialId;

		public int catalystId;

		public bool useDust;

		public bool takeNew;

		public bool[] optionLock;

		public int index;

		public int deckPreset;

		public int customType;

		public int[] polishItemIds;

		public int[] polishItemCounts;

		public int[] replacedOptionSlotIdx;
	}
}
