using System;
using System.Collections.Generic;

namespace Awesomepiece.Model
{
	[Serializable]
	public class PlayerTerritoryTycoonResponseModel : ResponseModel
	{
		public int level;

		public int consumableToken;

		public int gachaToken;

		public int skinToken;

		public int storedSkinToken;

		public int skipRewardUsedCount;

		public List<TerritoryBuildingResponseModel> buildings;
	}
}
