using System;
using System.Collections.Generic;

namespace Awesomepiece.Model
{
	[Serializable]
	public class FourthYearEventReceiveRewardResponseModel : ResponseModel
	{
		public FourthYearEventResponseModel eventResponseModel;

		public int playerGold;

		public int playerCash;

		public List<GachaKey> gachaKeys;

		public int unitSoulItem;

		public ArtifactResultResponseModel artifactResult;

		public List<InventoryItem> inventoryItems;

		public int unitId;

		public int unitSoul;

		public int skinId;
	}
}
