using System;
using System.Collections.Generic;

namespace Awesomepiece.Model
{
	[Serializable]
	public class TerritoryHuntingRefreshResponseModel : ResponseModel
	{
		public List<TerritoryHuntingData> territoryHuntingData;

		public int labor;

		public int refreshCount;

		public int freeRefreshCount;
	}
}
