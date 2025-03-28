using System;
using System.Collections.Generic;
using System.Xml;

namespace Awesomepiece.Model
{
	[Serializable]
	public class GameCompleteRequestModel
	{
		[Serializable]
		public class DevelResult
		{
			public int stage;

			public string condition;

			public int reward;

			public bool accepted;
		}

		[Serializable]
		public class MerchantResult
		{
			public int item1;

			public int item2;

			public int item3;

			public List<Item.OptionForServer> itemOptions1;

			public List<Item.OptionForServer> itemOptions2;

			public List<Item.OptionForServer> itemOptions3;

			public bool buy1;

			public bool buy2;

			public bool buy3;

			public bool hasAd;
		}

		[Serializable]
		public class CraftResult
		{
			public int item1;

			public int item2;

			public int item3;

			public int selectedItem;

			public int reRollCount;
		}

		[Serializable]
		public class EndFieldUnit
		{
			public int unitId;

			public int level;

			public int item1;

			public int item2;

			public int item3;

			public int item4;

			public List<Item.OptionForServer> itemOption1;

			public List<Item.OptionForServer> itemOption2;

			public List<Item.OptionForServer> itemOption3;

			public List<Item.OptionForServer> itemOption4;

			public int posX;

			public int posY;
		}

		[Serializable]
		public class EndItemUnit
		{
			public int itemId;

			public List<Item.OptionForServer> options;

			public int posX;

			public int posY;

			public EndItemUnit()
			{
			}

			public EndItemUnit(XmlNode xmlNode)
			{
			}

			public bool IsSameItem(EndItemUnit endItemUnit)
			{
				return false;
			}
		}

		[Serializable]
		public class UnitInfo
		{
			public int unitId;

			public int maxLevel;

			public int stage;
		}

		[Serializable]
		public class RoundData
		{
			public List<EndFieldUnit> fieldUnits;

			public string fieldUnitAIs;

			public int barricade;
		}

		public string gameId;

		public string startTime;

		public string endTime;

		public int playTime;

		public int theme;

		public int stage;

		public int remainHeart;

		public bool win;

		public bool adBonus;

		public bool revived;

		public bool freeRevived;

		public int eliteValueSum;

		public int eliteLevel;

		public int eliteBossItem;

		public int eliteKillHeart;

		public int eliteAddBoss;

		public int difficulty;

		public bool eventDifficultyMissionClear;

		public int[] deck;

		public int[] potential;

		public int[] artifacts;

		public int currentDeckPreset;

		public int unitSlotCount;

		public int maxUnitLevel;

		public int maxGold;

		public int loseCount;

		public int barricade5;

		public int barricade10;

		public int barricade15;

		public List<DevelResult> devilResults;

		public List<MerchantResult> merchantResults;

		public List<CraftResult> craftResults;

		public List<EndFieldUnit> endFieldUnits;

		public List<UnitInfo> unitInfos;

		public List<EndFieldUnit> waitingUnits;

		public List<EndItemUnit> items;

		public long eliteRankingScore;

		public int maxLevelUnitCount;

		public int maxLevelItemCount;

		public long maxUnitDamageSum;

		public List<int> killedUnits;

		public int stageWinCount;

		public List<bool> stageResults;

		public List<RoundData> pvpDeckRecordData;

		public int pvpId;

		public int pvpScore;

		public int[] pvpRoundResults;

		public bool isArenaTraining;

		public int foodBoosterLevel;

		public int startGold;

		public int round1BattleTime;

		public int round2BattleTime;

		public int round3BattleTime;

		public int round4BattleTime;

		public int round5BattleTime;

		public int deckValue;

		public long clanRaidDamage;

		public int clanRaidBossKillCount;

		public bool isClanRaidPractice;

		public bool isDevTestMode;

		public int[] resEliteLevels;

		public int[] eliteLevels;

		public Scene_Game.RogueLikeSaveLogData rogueLikeSaveLogData;

		public int rogueLikeFloor;

		public int rogueLikeChallengeLevel;

		public int rogueLikeTotalScore;

		public int[] rogueLikeArtifacts;

		public int rogueLikeClearedBattleRoomCount;

		public int rogueLikeTotalBattleRoomCount;

		public int rogueLikeMaxLevelBuildingIdx;

		public bool isEventModeContinued;

		public int colosseumRank;

		public int colosseumSameRankNum;

		public string colosseumGameId;

		public int abilityLevel;

		public int abilityCount;

		public List<int> usedInvadeItemIDs;

		public int invadeSuccessCount;

		public int totalUsedGold;

		public bool isCustomMatch;

		public float divinePower;

		public bool ignoreDeckRecord;

		public int[] addCardsExp;
	}
}
