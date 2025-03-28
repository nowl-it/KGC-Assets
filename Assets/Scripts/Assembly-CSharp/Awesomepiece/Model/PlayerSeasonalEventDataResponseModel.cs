using System;

namespace Awesomepiece.Model
{
	[Serializable]
	public class PlayerSeasonalEventDataResponseModel : ResponseModel
	{
		public PlayerTerritoryTycoonResponseModel territoryTycoon;

		public FourthYearEventResponseModel playerFourthYearEvent;
	}
}
