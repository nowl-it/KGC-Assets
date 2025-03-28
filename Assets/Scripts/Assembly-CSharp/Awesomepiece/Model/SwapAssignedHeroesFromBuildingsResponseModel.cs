using System;
using System.Collections.Generic;

namespace Awesomepiece.Model
{
	[Serializable]
	public class SwapAssignedHeroesFromBuildingsResponseModel : ResponseModel
	{
		public List<int> fromBuildingAssignedUnits;

		public List<int> toBuildingAssignedUnits;
	}
}
