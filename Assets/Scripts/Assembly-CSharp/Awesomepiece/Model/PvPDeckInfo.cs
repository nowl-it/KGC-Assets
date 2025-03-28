using System;
using System.Collections.Generic;

namespace Awesomepiece.Model
{
	[Serializable]
	public class PvPDeckInfo
	{
		public int id;

		public int season;

		public int score;

		public int tier;

		public int accountId;

		public string playerName;

		public string castleName;

		public int profileIcon;

		public int flagId;

		public int nameTagId;

		public CardInfo[] cards;

		public BuildingInfo[] buildings;

		public List<GameCompleteRequestModel.RoundData> pvpDeckRecordData;

		public List<ArtifactModel> artifacts;

		public int[] potentials;

		public int[] territoryStatBuffPers;

		public string encryptedUID;

		public int playerLevel;
	}
}
