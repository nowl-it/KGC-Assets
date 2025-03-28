using System.Collections.Generic;
using System.Reflection;
using Awesomepiece.Model;
using JetBrains.Annotations;

namespace Awesomepiece
{
	public class EarlyAccessModeFakeWeb
	{
		private static readonly Dictionary<(string type, string url), MethodInfo> _fakeApis;

		private static bool _initialized;

		private static HashSet<(string type, string url)> _needRealWebURLList;

		public static bool NeedRealWeb(string type, string uri)
		{
			return false;
		}

		public static void Initialize()
		{
		}

		private static (string, List<string>) ParseUri(string uri)
		{
			return default((string, List<string>));
		}

		public static T FakeGet<T>(string uri, bool useSystemSerializeFunc = false) where T : ResponseModel, new()
		{
			return null;
		}

		public static T FakePost<T>(string uri, string json, bool useSystemSerializeFunc = false) where T : ResponseModel, new()
		{
			return null;
		}

		public static T FakePut<T>(string uri, string json) where T : ResponseModel, new()
		{
			return null;
		}

		public static T FakeDelete<T>(string uri, string json) where T : ResponseModel, new()
		{
			return null;
		}

		[FakeWebURL("POST", "/artifact/equip")]
		[UsedImplicitly]
		private static ArtifactResultResponseModel ArtifactEquip(ArtifactRequestModel model)
		{
			return null;
		}

		private static BuildingResponseModel GetDefaultBuildingResponseModel()
		{
			return null;
		}

		[UsedImplicitly]
		[FakeWebURL("POST", "/player/building/resetPoint")]
		private static BuildingResponseModel ResetBuildingPoint(BuildingRequestModel model)
		{
			return null;
		}

		[UsedImplicitly]
		[FakeWebURL("PUT", "/player/building/save")]
		private static BuildingResponseModel SaveBuilding(BuildingRequestModel model)
		{
			return null;
		}

		private static DeckResponseModel GetDefaultDeckResponseModel()
		{
			return null;
		}

		[UsedImplicitly]
		[FakeWebURL("POST", "/deck/set")]
		private static DeckResponseModel SetDeck(DeckRequestModel model)
		{
			return null;
		}

		[UsedImplicitly]
		[FakeWebURL("POST", "/deck/setAllPotential")]
		private static DeckResponseModel SetAllCardPotential(SetCardPotentialRequestModel model)
		{
			return null;
		}

		[UsedImplicitly]
		[FakeWebURL("POST", "/deck/setPotential")]
		private static DeckResponseModel SetCardPotential(SetCardPotentialRequestModel model)
		{
			return null;
		}

		[FakeWebURL("POST", "/treasure/equip")]
		[UsedImplicitly]
		private static TreasureResultResponseModel TreasureEquip(TreasureRequestModel model, bool useTicket)
		{
			return null;
		}

		[UsedImplicitly]
		[FakeWebURL("POST", "/treasure/release-equip")]
		private static TreasureResultResponseModel TreasureReleaseEquip(TreasureRequestModel model)
		{
			return null;
		}

		[FakeWebURL("POST", "/accessory/equip")]
		[UsedImplicitly]
		private static AccessoryResultResponseModel AccessoryEquip(AccessoryEquipRequestModel model, bool useTicket)
		{
			return null;
		}

		[FakeWebURL("POST", "/accessory/release-equip")]
		[UsedImplicitly]
		private static AccessoryResultResponseModel AccessoryReleaseEquip(AccessoryRequestModel model)
		{
			return null;
		}

		[UsedImplicitly]
		[FakeWebURL("GET", "/mission/check")]
		private static MissionResponseModel CheckMission(params string[] condTypes)
		{
			return null;
		}

		[FakeWebURL("POST", "/game/start")]
		[UsedImplicitly]
		private static GameStartResponseModel GameStart(GameStartRequestModel model)
		{
			return null;
		}

		[UsedImplicitly]
		[FakeWebURL("POST", "/game/complete")]
		private static GameResponseModel GameComplete(GameCompleteRequestModel model)
		{
			return null;
		}

		[UsedImplicitly]
		[FakeWebURL("GET", "/invasion/record")]
		private static InvasionRecordsResponseModel FetchInvasionRecords()
		{
			return null;
		}

		[UsedImplicitly]
		[FakeWebURL("GET", "/invasion/reward")]
		private static InvasionRewardDatasResponseModel FetchInvasionRewardDatas()
		{
			return null;
		}

		[FakeWebURL("POST", "/clan/raid/end")]
		[UsedImplicitly]
		private static ClanRaidResponseModel EndClanRaid(ClanRaidEndBattleRequestModel model)
		{
			return null;
		}

		[UsedImplicitly]
		[FakeWebURL("POST", "/clan/raid/deck")]
		private static ResponseModel SetClanRaidDeckPreset(ClanRaidDeckRequestModel model)
		{
			return null;
		}

		[UsedImplicitly]
		[FakeWebURL("POST", "/clan/raid/delete-deck")]
		private static ClanRaidDeckInfoResponseModel DeleteClanRaidDeck(int deckIdx)
		{
			return null;
		}

		[UsedImplicitly]
		[FakeWebURL("POST", "/clan/raid/support")]
		private static ClanRaidSupporterSettingResponseModel SetClanRaidSupportUnit(int unitId)
		{
			return null;
		}

		[UsedImplicitly]
		[FakeWebURL("POST", "/clan/raid/deck-name")]
		private static ClanRaidDeckInfoResponseModel SetClanRaidDeckName(int deckIdx, string deckName)
		{
			return null;
		}

		private static int GetTargetDeckIdx()
		{
			return 0;
		}

		private static int HandleCompleteClanRaidDeckRecord(GameCompleteRequestModel model)
		{
			return 0;
		}

		[UsedImplicitly]
		[FakeWebURL("GET", "/pvp/info")]
		private static PvPInfoResponseModel FetchPvPInfo()
		{
			return null;
		}

		[FakeWebURL("GET", "/colosseum")]
		[UsedImplicitly]
		private static PlayerColosseumInfoResponseModel FetchPlayerColosseum()
		{
			return null;
		}

		[FakeWebURL("POST", "/colosseum/round-data")]
		[UsedImplicitly]
		private static ResponseModel SaveColosseumRoundData(SaveColosseumRoundDataRequestModel model, string gameId)
		{
			return null;
		}

		[FakeWebURL("POST", "/colosseum/complete-round-data")]
		[UsedImplicitly]
		private static ResponseModel SaveCompleteColosseumRoundData(SaveCompleteColosseumRoundDataRequestModel model)
		{
			return null;
		}

		[UsedImplicitly]
		[FakeWebURL("POST", "/colosseum/record-minimum-rank")]
		private static ResponseModel ColosseumRecordMinimumRank(string gameId, int rank)
		{
			return null;
		}
	}
}
