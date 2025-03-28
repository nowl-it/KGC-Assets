using System;
using System.Collections.Generic;

namespace Awesomepiece.Model
{
	[Serializable]
	public class TerritoryAssignUnitsResponseModel : ResponseModel
	{
		public List<TerritoryLevelSyncData> playerLevelSyncData;

		public int cash;
	}
}
