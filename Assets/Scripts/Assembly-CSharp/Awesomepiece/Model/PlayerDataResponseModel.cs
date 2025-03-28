using System;
using System.Collections.Generic;

namespace Awesomepiece.Model
{
	[Serializable]
	public class PlayerDataResponseModel : ResponseModel
	{
		public int accountId;

		public string name;

		public string castleName;

		public int kingPostfix;

		public int castlePostfix;

		public string uid;

		public int accountType;

		public int cash;

		public int paidCash;

		public int gold;

		public int level;

		public int exp;

		public int heart;

		public string lastHeartTime;

		public int bestClearedStage;

		public int bestClearedTheme;

		public int bestClearedHardStage;

		public int bestClearedHardTheme;

		public int currentDeckPreset;

		public int playedCount;

		public int winCount;

		public int rogueLikePlayedCount;

		public bool rogueLikeCleared;

		public InvasionDifficultyRecord[] invasionDifficultyRecords;

		public int[] eventModeRecord;

		public int[] rogueLikeBuildingChallengeLevelRecord;

		public int rogueLikeGameIndex;

		public int[] currentRanking;

		public int[] currentHardRanking;

		public string tomorrow;

		public string nextWeek;

		public bool hasFreeRename;

		public int eventFlag;

		public int eventPlayedCount;

		public bool clanAttendance;

		public List<TokenInfo> tokens;

		public List<KeyValue> keyValues;

		public List<string> attendedCustomEvents;

		public List<CustomEventData> customEventDatas;

		public List<EventMissionData> eventMissionData;

		public List<EventMissionData> eventData;

		public string accountCreatedAt;

		public DateTime lastHeartTime_ => default(DateTime);

		public DateTime tomorrow_ => default(DateTime);

		public DateTime nextWeek_ => default(DateTime);

		public DateTime accountCreatedAt_ => default(DateTime);
	}
}
