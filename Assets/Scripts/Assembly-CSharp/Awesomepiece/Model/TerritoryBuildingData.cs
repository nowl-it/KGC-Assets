using System;
using System.Collections.Generic;

namespace Awesomepiece.Model
{
	[Serializable]
	public class TerritoryBuildingData
	{
		public int buildingId;

		public int posIndex;

		public List<int> assignedUnits;

		[NonSerialized]
		public float unitAssignBenefitPer;

		public DateTime upgradeEndAt;

		public DateTime lastTokenAt;

		public string data;

		public TerritoryBuildingData()
		{
		}

		public TerritoryBuildingData(TerritoryBuildingResponseModel building)
		{
		}

		public TerritoryBuildingData Clone()
		{
			return null;
		}
	}
}
