using System;
using System.Collections.Generic;

namespace Awesomepiece.Model
{
	[Serializable]
	public class GameStartResponseModel : ResponseModel
	{
		public int heart;

		public string lastHeartTime;

		public int[] buildingLevels;

		public List<BuildingResponseModel.BuildingData> buildingData;

		public List<CardResponseModel> cards;

		public string gameId;

		public int eventFlag;

		public List<BatchData> rankingStageUnits;

		public int pvpId;

		public List<int> rogueLikeClearedMission;

		public List<int> rogueLikeBannedHeroes;

		public DateTime lastHeartTime_ => default(DateTime);
	}
}
