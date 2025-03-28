using System;
using System.Collections.Generic;

namespace Awesomepiece.Model
{
	[Serializable]
	public class ColosseumPlayerDataResponseModel : ResponseModel
	{
		public class ColosseumPlayerData
		{
			public string userId;

			public CardInfo[] cardInfos;

			public int[] potentials;

			public List<ArtifactModel> artifactModels;

			public int[] buildingLevels;

			public int[] territoryStatBuffPers;

			public string castleName;

			public string userName;

			public int profileIconId;

			public int nameTagId;

			public FlagResponseModel flagModel;

			public bool isBot;

			public List<SaveColosseumRoundDataRequestModel.ColosseumRoundData> roundData;

			public bool reported;

			public bool blinded;
		}

		public List<ColosseumPlayerData> colosseumPlayerDataList;

		public bool isCustomMatch;
	}
}
