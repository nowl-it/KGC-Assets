using System;
using System.Collections.Generic;

namespace Awesomepiece.Model
{
	[Serializable]
	public class TerritoryHuntingData
	{
		public int resourceRoot;

		public string region;

		public int foodBoosterLevel;

		public List<int> units;

		public string endAt;

		public DateTime endAt_ => default(DateTime);
	}
}
