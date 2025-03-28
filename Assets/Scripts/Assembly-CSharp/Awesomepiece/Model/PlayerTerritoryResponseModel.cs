using System;
using System.Collections.Generic;

namespace Awesomepiece.Model
{
	public class PlayerTerritoryResponseModel : ResponseModel
	{
		[Serializable]
		public class StoredBuilding
		{
			public int buildingId;

			public int count;
		}

		public int labor;

		public int storedLabor;

		public List<TerritoryBuildingResponseModel> buildingDatas;

		public string lastLaborAt;

		public int[] statBuffPers;

		public List<StoredBuilding> storedBuildings;

		public List<TerritoryHuntingData> playerHuntingData;

		public int huntingRefreshCount;

		public int freeHuntingRefreshCount;

		public List<TerritoryLevelSyncData> playerLevelSyncData;

		public List<InventoryItem> tickets;

		public List<TerritoryTradeShopItemData> playerTradeShopItemData;

		public string passEndedAt;

		public DateTime lastLaborAt_ => default(DateTime);
	}
}
