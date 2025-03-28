using System;
using System.Collections.Generic;

namespace Awesomepiece.Model
{
	[Serializable]
	public class TerritoryBuildingResponseModel : ResponseModel
	{
		public int buildingId;

		public int posIndex;

		public string upgradeEndAt;

		public string lastTokenAt;

		public List<int> assignedUnits;

		public string data;

		public DateTime upgradeEndAt_ => default(DateTime);

		public DateTime lastTokenAt_ => default(DateTime);
	}
}
