using System;
using System.Collections.Generic;

namespace Awesomepiece.Model
{
	public class PlayerTerritoryModel
	{
		public int labor;

		public int storedLabor;

		public List<TerritoryBuildingData> buildingDatas;

		public DateTime lastLaborAt;

		public List<PlayerTerritoryResponseModel.StoredBuilding> storedBuildings;

		public List<TerritoryHuntingData> playerHuntingData;

		public int huntingRefreshCount;

		public int freeHuntingRefreshCount;

		public Dictionary<int, TerritoryLevelSyncData> playerLevelSyncData;

		public List<TerritoryTradeShopItemData> playerTradeShopData;

		public string passEndedAt;

		public DateTime passEndedAt_ => default(DateTime);

		public bool buyPass => false;
	}
}
