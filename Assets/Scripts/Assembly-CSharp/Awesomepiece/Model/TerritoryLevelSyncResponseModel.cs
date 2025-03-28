using System.Collections.Generic;

namespace Awesomepiece.Model
{
	public class TerritoryLevelSyncResponseModel : ResponseModel
	{
		public List<int> assignedUnits;

		public List<TerritoryLevelSyncData> playerLevelSyncData;
	}
}
