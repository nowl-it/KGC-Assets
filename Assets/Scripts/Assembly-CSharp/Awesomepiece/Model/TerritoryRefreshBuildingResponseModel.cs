using System;
using System.Collections.Generic;

namespace Awesomepiece.Model
{
	[Serializable]
	public class TerritoryRefreshBuildingResponseModel : ResponseModel
	{
		public TerritoryBuildingResponseModel buildingRet;

		public int ticketCount;

		public List<TerritoryLevelSyncData> playerLevelSyncData;
	}
}
