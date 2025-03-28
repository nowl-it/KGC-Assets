using System;
using System.Collections.Generic;

namespace Awesomepiece.Model
{
	[Serializable]
	public class ArtifactResultResponseModel : ResponseModel
	{
		public List<ArtifactModel> results;

		public bool polishItemAdded;

		public int playerGold;

		public int playerCash;

		public bool changeEquipped;

		public List<EquippedArtifactData> equippedArtifacts;
	}
}
