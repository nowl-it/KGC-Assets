using System;
using System.Collections.Generic;

namespace Awesomepiece.Model
{
	[Serializable]
	public class TerritoryHuntingRequestModel
	{
		public int huntingBuildingPosIndex;

		public string region;

		public int resourceRoot;

		public int difficulty;

		public List<int> units;
	}
}
