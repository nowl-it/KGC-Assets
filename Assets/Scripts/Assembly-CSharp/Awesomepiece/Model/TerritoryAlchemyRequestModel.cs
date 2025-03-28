using System.Collections.Generic;

namespace Awesomepiece.Model
{
	public class TerritoryAlchemyRequestModel
	{
		public class AlchemyCurrencyData
		{
			public string type;

			public int id;

			public int count;
		}

		public int alchemyBuildingPosIndex;

		public int index;

		public int rewardVersion;

		public List<AlchemyCurrencyData> alchemyCurrencies;

		public int level;
	}
}
