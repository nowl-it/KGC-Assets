using System;
using System.Collections.Generic;

namespace Awesomepiece.Model
{
	[Serializable]
	public class ArtifactInventoryResponseModel : ResponseModel
	{
		public List<ArtifactModel> artifacts;

		public int dustCount;

		public List<EquippedArtifactData> equippedArtifacts;

		public int playerGold;

		public int playerCash;
	}
}
