using System;

namespace Awesomepiece.Model
{
	[Serializable]
	public class TerritoryBuildBuildingResponseModel : ResponseModel
	{
		public TerritoryRefreshBuildingResponseModel refreshRet;

		public int labor;

		public int buildingCore;

		public int townHallCore;

		public int gold;

		public int cash;

		public int seasonalToken;
	}
}
