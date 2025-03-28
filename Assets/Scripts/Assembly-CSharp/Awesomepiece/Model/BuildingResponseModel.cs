using System;
using System.Collections.Generic;

namespace Awesomepiece.Model
{
	[Serializable]
	public class BuildingResponseModel : ResponseModel
	{
		[Serializable]
		public class BuildingData
		{
			public int[] buildingLevels;
		}

		public int[] buildingLevels;

		public List<BuildingData> buildingData;

		public int buildingPoint;

		public int remainPoint;

		public int playerGold;
	}
}
