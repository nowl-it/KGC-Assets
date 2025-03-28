using System;
using System.Collections.Generic;

namespace Awesomepiece.Model
{
	[Serializable]
	public class SeasonPassResponseModel : ResponseModel
	{
		[Serializable]
		public class BonusRewardPair
		{
			public int bonusId;

			public int buyCount;
		}

		[Serializable]
		public class MissionRerollCountPair
		{
			public int missionId;

			public int rerollCount;
		}

		public bool enabled;

		public byte buyPass;

		public bool buyPassUnit;

		public string buyPassUnitAt;

		public int passSeason;

		public int passLevel;

		public int passPoint;

		public List<int> receivedPassRewards;

		public List<int> receivedPassOnlyRewards;

		public List<int> receivedPremiumOnlyRewards;

		public List<BonusRewardPair> receivedBonusRewards;

		public string seasonStartAtDate;

		public string seasonUntilAtDate;

		public bool seasonalEventAvailable;

		public bool seasonalEventShopAvailable;

		public List<int> seasonalEventModes;

		public List<int> seasonalEventModesDailyPlayCount;

		public string seasonalEventUntilAtDate;

		public string seasonalEventShopUntilAtDate;

		public List<MissionRerollCountPair> missionRerollCountPairs;

		public string nextSeasonStartAtDate;

		public DateTime buyPassUnitAt_ => default(DateTime);

		public DateTime seasonStartAtDate_ => default(DateTime);

		public DateTime seasonUntilAtDate_ => default(DateTime);

		public DateTime seasonalEventUntilAtDate_ => default(DateTime);

		public DateTime seasonalEventShopUntilAtDate_ => default(DateTime);

		public DateTime nextSeasonStartAtDate_ => default(DateTime);
	}
}
