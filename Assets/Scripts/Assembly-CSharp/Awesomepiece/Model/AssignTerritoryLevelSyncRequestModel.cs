using System;

namespace Awesomepiece.Model
{
	[Serializable]
	public class AssignTerritoryLevelSyncRequestModel
	{
		public int buildingId;

		public int posIndex;

		public int unitId;

		public int slotIdx;
	}
}
