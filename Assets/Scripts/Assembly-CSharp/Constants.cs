using System;
using System.Collections.Generic;
using Awesomepiece;
using Awesomepiece.Model;
using CodeStage.AntiCheat.ObscuredTypes;
using UnityEngine;

public class Constants
{
	public static class Sound
	{
		public static string Click;

		public static string PositiveFeedback;

		public static string NegativeFeedback;
	}

	public static class StatusKey
	{
		public static string ACCOUNT_TRANSFER;

		public static string ACCOUNT_TRANSFER_DATE;

		public static string CURRENT_GOLD_MINE_TIER;

		public static string CURRENT_CASH_MINE_TIER;

		public static string CURRENT_GOLD_MINE_RESERVE;

		public static string CURRENT_CASH_MINE_RESERVE;

		public static string TOWER_RETURN_EVENT_SET;

		public static string RETURN_EVENT_SET;

		public static string RETURN_EVENT_KINGGAK;

		public static string ROGUE_LIKE_PLAY_COUNT;

		public static string ROGUE_LIKE_MAX_CLEARED_CHALLENGE;

		public static string OFFER_WALL_TAPJOY_GEM;

		public static string OFFER_WALL_TAPJOY_FOOD;

		public static string OFFER_WALL_FYBER_GEM;

		public static string OFFER_WALL_FYBER_FOOD;

		public static string SUMMON_TUTORIAL_AVAILABLE;

		public static string TREASURE_TUTORIAL_AVAILABLE;

		public static string ACCESSORY_TUTORIAL_AVAILABLE;

		public static string TERRITORY_TUTORIAL_AVAILABLE;

		public static string SOLO_RAID_TUTORIAL_AVAILABLE;

		public static string CLAN_RAID_TUTORIAL_AVAILABLE;

		public static string WELCOME_UNIT;

		public static string PVP_DORMANT_DECREASED_SCORE;

		public static string ROGUE_LIKE_BOUGHT_DLCS;

		public static string COLOSSEUM_OPEN_MISSION_REWARDED_STATUS;

		public static string CUSTOM_GROWTH_PACKAGE_UNIT;

		public static string THIRD_HALF_ANNIVERSARY_DAY;

		public static string THIRD_HALF_ANNIVERSARY_BUY_PASS;

		public static string THIRD_HALF_ANNIVERSARY_UNTIL;

		public static string DECK_SLOT_NAME;

		public static string TREASURE_USED_IN_DECK;

		public static string ACCESSORY_USED_IN_DECK;

		public static string INVENTORY_COUNT;

		public static string JOURNEY_LAST_REWARD_ID;

		public static string JOURNEY_NEXT_REWARD_TIME;

		public static string DAILY_CONSUMED_HEART;

		public static string STREAMING_START_AT;

		public static string STREAMING_PREVIEW_START_AT;

		public static string STREAMING_END_AT;

		public static string STREAMING_URL;

		public static string STREAMING_BANNER;

		public static string INVASION_SKIP_COUNT;

		public static string TOTAL_INVASION_SKIP_COUNT;

		public static string INVASION_SKIP_HEART_FREE_COUNT;

		public static string AUTO_MERGE_TUTORIAL_AVAILABLE;

		public static string EVENT_MODE_TUTORIAL_AVAILABLE;

		public static string BABEL_TUTORIAL_AVAILABLE;

		public static string CLAN_TUTORIAL_AVAILABLE;

		public static string COLOSSEUM_TUTORIAL_AVAILABLE;

		public static string TREASURE_GACHA_CEIL_PREFIX;

		public static string FIRST_PURCHASE_EVENT_RECEIVED;
	}

	public static class EventStatusKey
	{
		public static string FOURTH_YEAR_EVENT;

		public static string FOURTH_YEAR_EVENT_PARTICIPATED;

		public static string FOURTH_YEAR_EVENT_PASS_DAY;

		public static string FOURTH_YEAR_EVENT_LAST_HEART_REWARD_DAY;

		public static string FOURTH_YEAR_EVENT_LAST_PASS_ONLY_REWARD_DAY;

		public static string FOURTH_YEAR_EVENT_ATTENDANCE_DAY;

		public static string FOURTH_YEAR_EVENT_LAST_ATTENDANCE_REWARD_DAY;

		public static string FOURTH_YEAR_EVENT_BUY_PASS;

		public static string FOURTH_YEAR_EVENT_START_AT;

		public static string FOURTH_YEAR_EVENT_PARTICIPATE_UNTIL_AT;

		public static string FOURTH_YEAR_EVENT_UNTIL_AT;
	}

	public static class CustomEventDataName
	{
		public const string AXIS_BLADE_OPEN = "EventAxisBladeOpen";
	}

	public static class AccountType
	{
		public static int Test;

		public static int Google;

		public static int GameCenter;

		public static int AppleID;

		public static int Guest;
	}

	public static class Team
	{
		public static int None;

		public static int Player;

		public static int Enemy;

		public static int GetOtherTeam(int team)
		{
			return 0;
		}
	}

	public static class BossLevel
	{
		public static int Elite;

		public static int Boss;
	}

	public static class UnitLevel
	{
		public static int MinLevel;

		public static int AutoSellMaxLevel;

		public static int NormalMaxLevel;

		public static int TestModeMaxLevel;
	}

	public static class StatLimit
	{
		public static float MaxMissRatio;

		public static float MinCriticalDamageMul;

		public static float MinDmgRelatedValue;

		public static float MinDef;

		public static float MaxExecution;

		public static float MaxDamageConversionRatio;

		public static void ResetStatLimitsToDefault()
		{
		}
	}

	public static class Position
	{
		public const int CenterX = 3;
	}

	public static class Direction
	{
		public static Vector2Int LeftTop;

		public static Vector2Int RightTop;

		public static Vector2Int LeftBottom;

		public static Vector2Int RightBottom;

		public static Vector2Int Top;

		public static Vector2Int Left;

		public static Vector2Int Right;

		public static Vector2Int Bottom;

		public static Vector2Int[] All;

		public static Vector2Int[] All4;

		public static Vector2Int[] AllUp;

		public static Vector2Int[] AllLeft;

		public static Vector2Int[] AllRight;

		public static Vector2Int[] AllDown;

		private static Vector2Int[] Way4_FromTop_a;

		private static Vector2Int[] Way4_FromTop_b;

		private static Vector2Int[] Way4_FromBottom_a;

		private static Vector2Int[] Way4_FromBottom_b;

		private static Vector2Int[] Way8_FromTop_a;

		private static Vector2Int[] Way8_FromTop_b;

		private static Vector2Int[] Way8_FromBottom_a;

		private static Vector2Int[] Way8_FromBottom_b;

		private static Vector2Int[] Way8_FromSide_a;

		private static Vector2Int[] Way8_FromSide_b;

		private static Vector2Int[] Way8_FromLeft_a;

		private static Vector2Int[] Way8_FromLeft_b;

		private static Vector2Int[] Way8_FromRight_a;

		private static Vector2Int[] Way8_FromRight_b;

		public static Vector2Int[] Way4_FromTop(int? seed = null)
		{
			return null;
		}

		public static Vector2Int[] Way4_FromBottom(int? seed = null)
		{
			return null;
		}

		public static Vector2Int[] Way8_FromTop(int? seed = null)
		{
			return null;
		}

		public static Vector2Int[] Way8_FromBottom(int? seed = null)
		{
			return null;
		}

		public static Vector2Int[] Way8_FromSide(int? seed = null)
		{
			return null;
		}

		public static Vector2Int[] Way8_FromLeft(int? seed = null)
		{
			return null;
		}

		public static Vector2Int[] Way8_FromRight(int? seed = null)
		{
			return null;
		}

		public static Vector2Int GetDirectionByName(string name, Vector2Int tilePos, Vector2Int? targetTilePos = null)
		{
			return default(Vector2Int);
		}
	}

	public static class PotentialTier
	{
		public static int Potential;

		public static int Max;
	}

	public static class Mode
	{
		public static int Chapter;

		public static int Pvp;

		public static int Event;
	}

	public static class ItemID
	{
		public static bool IsUnitExpPackage(int id)
		{
			return false;
		}
	}

	public static class DailyAttendanceEventID
	{
		public const int DAILY_ATTENDANCE_EVENT = 2;

		public const int RETURN_EVENT = 4;
	}

	public static class UnitID
	{
		public const int EVAN = 10030;

		public const int MARA = 10100;

		public const int LAIKA = 10120;

		public const int YOL = 10140;

		public const int MEL = 10210;

		public const int ELIZABETH = 10540;

		public const int SPIRIT_STONE = 10550;

		public const int EVENT_TRIGGER_UNIT = 99996;

		public const int CLONE_POS_UNIT = 99998;

		public const int DEAL_METER_UNIT = 99999;

		public const int ULT_SMELTING_TOTEM = 89999;

		public const int KING_LIME = 20250;

		public const int KING_LIME_HARD = 25250;

		public const int CLONE_BOSS_SOLDIER = 41010;

		public const int CLONE_BOSS_SOLDIER_HARD = 41011;

		public const int CLONE_BOSS_SOLDIER_HARD2 = 41012;

		public const int ROGUE_LIKE_BUILDING5_MERCHANT = 79905;

		public const int ROGUE_LIKE_BOSS_1 = 70100;

		public const int ROGUE_LIKE_BOSS_2 = 70110;

		public const int ROGUE_LIKE_SUB_BOSS_2 = 70130;

		public const int ROGUE_LIKE_BOSS_3 = 70120;

		public static bool IsSmeltingTotem(int id)
		{
			return false;
		}
	}

	public static class ThemeID
	{
		public const int EVENT_GOLD_GOBLIN = 101;

		public const int EVENT_BOSS_RUSH = 102;

		public const int EVENT_PVP_RUSH = 103;

		public const int PVP_DECK_RECORD = 201;

		public const int PVP = 202;

		public const int CLAN_RAID_DECK_RECORD = 207;

		public const int CLAN_RAID = 208;

		public const int BABEL_START = 400;

		public const int SEASONAL_EVENT_MODE_1000 = 1000;

		public const int SEASONAL_EVENT_MODE_1001 = 1001;

		public const int ROGUE_LIKE = 2000;

		public const int COLOSSEUM = 3000;

		public static bool IsBabelTheme(int theme)
		{
			return false;
		}
	}

	public static class NewContentID
	{
		public const int MISSION = 3;

		public const int SEASON_PASS = 4;

		public const int CLAN = 6;

		public const int SEASONAL_EVENT = 8;

		public const int EVENT_MODE = 100;

		public const int ARENA = 200;

		public const int HARD_MODE = 300;

		public const int BABEL = 401;

		public const int ROGUE_LIKE = 500;

		public const int TERRITORY = 600;

		public const int COLOSSEUM = 700;

		public const int TREASURE = 800;

		public const int ACCESSORY = 900;

		public const int STARTER_MISSION = 1000;
	}

	public static class TutorialID
	{
		public const int LOBBY = 1;

		public const int LOBBY_SECOND_STEP = 2;

		public const int LOBBY_THIRD_STEP = 3;

		public const int ARENA = 10;

		public const int ARTIFACT = 20;

		public const int SUMMON = 30;

		public const int TERRITORY = 40;

		public const int TREASURE = 50;

		public const int ACCESSORY = 60;

		public const int CHAPTER_16 = 90;

		public const int EXP_CANDY = 100;

		public const int EVENT_MODE = 110;

		public const int BABEL = 120;

		public const int CLAN = 130;

		public const int LATE_COMER = 140;

		public const int POTENTIAL = 150;

		public const int ARTIFACT_REROLL = 160;

		public const int ARTIFACT_POLISH = 170;

		public const int COLOSSEUM = 180;

		public const int TREASURE_OVERCOME = 190;

		public const int ACCESSORY_UPGRADE = 200;
	}

	public static class ClanJoinType
	{
		public static int AutoJoin;

		public static int AcceptJoin;

		public static int CanNotJoin;
	}

	public static class ShopItemID
	{
		public const int SHOP_ITEM_UNIT = 200;

		public const int HEART_5EA = 601;

		public const int HEART_20EA = 602;

		public const int EVENT_FLAG = 610;

		public const int TERRITORY_HUNTING_TICKET = 620;

		public const int SEASON_PASS = 900;

		public const int TERRITORY_PASS = 920;

		public const int THIRD_HALF_ANNIVERSARY_PASS = 930;

		public const int FOURTH_YEAR_EVENT_PASS = 931;

		public const int DAILY_CASH_ITEM = 950;

		public const int DAILY_CASH2_ITEM = 951;

		public const int DAILY_GOLD_ITEM = 952;

		public const int DAILY_HEART_ITEM = 953;

		public const int CUSTOM_GROWTH_PACKAGE_0 = 6100;

		public const int INVASION_PASS_START = 6220;
	}

	public static class DailyShop
	{
		public const int PRODUCT_COUNT = 11;

		public const int DEFAULT_COUNT = 6;

		public const int UNIT_EXP_ITEM_INDEX = 0;

		public const int FREE_GACHA_1_INDEX = 6;

		public const int FREE_GACHA_2_INDEX = 7;

		public const int FREE_GOLD_INDEX = 8;

		public const int FREE_GACHA_AD_INDEX = 9;

		public const int FREE_UNIT_EXP_ITEM_INDEX = 10;
	}

	public static class ClanChatType
	{
		public static int System;

		public static int Message;

		public static int UnitRequest;

		public static int ClanRaidBossKill;
	}

	public static class ClanRaid
	{
		public const int DIVINE_POWER_DAMAGE = 25000;

		public const int MAX_DIVINE_POWER = 10;

		public const int BOSS_HP_LIMIT = 2100000000;

		public const int MAX_CLAN_RAID_DECK_COUNT = 15;

		public const int CLAN_RAID_DAILY_PLAY_COUNT = 2;

		public const int CLAN_RAID_MAX_DIFFICULTY = 5;

		public const int DECK_NAME_MAX_LENGTH = 30;

		public const int CLAN_RAID_LAST_ROUND = 10;

		public static List<int> TIER_REPEAT_COUNT;

		public static List<int> BOSS_INCREASE_HP_START_AT;

		public static List<int> BOSS_INCREASE_HP_AMOUNT;

		public static List<int> BOSS_INCREASE_DEF_START_AT;

		public static List<int> BOSS_INCREASE_DEF_AMOUNT;

		public const float CLAN_RAID_TIMER = 30f;

		public const int DECK_MAX_PLAY_COUNT = 3;

		public const int CLAN_RAID_BOSS_TYPE_COUNT = 4;

		public const int CHALLENGER_REQ_KILL = 40;

		public const int CLAN_RAID_KING_DIFFICULTY = 5;

		public const int MODIFIER_COUNT = 15;

		public const int CLAN_RAID_RESET_COUNT = 10;

		public const int BEST_DECK_ITEM_DISPLAY_COUNT = 7;
	}

	public static class ClanRole
	{
		public const int Requested = -1;

		public const int None = 0;

		public const int MemberStart = 1;

		public const int Member1 = 1;

		public const int Member2 = 2;

		public const int Member3 = 3;

		public const int MemberEnd = 3;

		public const int SubMaster = 9;

		public const int Master = 10;

		public static bool Check(int role, ClanRoleEnum roleEnum)
		{
			return false;
		}

		public static bool CheckExactly(int role, ClanRoleEnum roleEnum)
		{
			return false;
		}

		public static string GetName(ClanModel model, int role)
		{
			return null;
		}

		public static string GetName(List<ClanModel.RoleName> roleNames, int role)
		{
			return null;
		}
	}

	public enum ClanRoleEnum
	{
		Member = 0,
		SubMaster = 1,
		Master = 2
	}

	public static class ArtifactCustomType
	{
		public const int NONE = 0;

		public const int LOCKED = 1;

		public const int FAVORITE = 2;
	}

	public class Font
	{
		public static string RANKING_FONT_DEFAULT;

		public static string RANKING_FONT_GOD;

		public static string RANKING_FONT_KINGGOD;
	}

	public static class ResItemID
	{
		public const int SWORD = 100;

		public const int ARMOR = 200;

		public const int BOW = 300;

		public const int STAFF = 400;

		public const int RANDOM_LEVEL_UP = 10040;

		public const int NONE_ITEM = 30004;
	}

	public static class ArtifactID
	{
		public const int DUST = 100;

		public const int POLISH_ITEM = 901;

		public const int NORMAL_FORGE_STONE = 598;

		public const int KINGGOD_FORGE_STONE = 601;

		public const int NONE_ARTIFACT = 29994;
	}

	public static class WeaponIDIndex
	{
		public const int SWORD = 100;

		public const int ARMOR = 200;

		public const int BOW = 300;

		public const int STAFF = 400;
	}

	public static class RogueLikeBuildingIndex
	{
		public const int NONE = -1;

		public const int HERO = 0;

		public const int SMITH = 1;

		public const int BLOOD = 2;

		public const int COLOSSUS = 3;

		public const int MAGICIAN = 4;

		public const int GREED = 5;

		public const int DEATH = 6;
	}

	[Flags]
	public enum RogueLikeItemType
	{
		None = 0,
		Artifact = 1,
		Equip = 2,
		Rune = 4,
		Item = 8,
		Hero = 0x10,
		Gold = 0x20,
		ExpItem = 0x40,
		EquipLvUpItem = 0x80,
		RuneLvUpItem = 0x100,
		RandomArtifactLvUpItem = 0x200,
		ArtifactRerollItem = 0x400,
		RareItem = 0x800,
		UnitDamaged = 0x1000,
		AllUnitDamaged = 0x2000,
		UnitHealed = 0x4000,
		AllUnitHealed = 0x8000,
		AddUnitExp = 0x10000,
		AddAllUnitExp = 0x20000,
		SetUnitHpPer = 0x40000,
		UnitRemoved = 0x80000,
		ConsumeGold = 0x100000,
		CustomResult = 0x200000
	}

	[Flags]
	public enum RogueLikeRewardCategory
	{
		None = 0,
		Artifact = 1,
		Equip = 2,
		Rune = 4,
		Hero = 8,
		Gold = 0x10
	}

	public class RogueLike
	{
		public const int ROGUE_LIKE_CHALLENGE_MAX = 15;

		public const int ROGUE_LIKE_MAX_FLOOR = 9;

		public static Color ROGUE_LIKE_CHALLENGE_HARD_COLOR_START;

		public static Color ROGUE_LIKE_CHALLENGE_HARD_COLOR_END;

		public static Color ROGUE_LIKE_CHALLENGE_EASY_COLOR;
	}

	public static class GachaId
	{
		public const int TREASURE_GACHA_TAB = 102;

		public const int WELCOME_GACHA = 9000;
	}

	public static class InventoryId
	{
		public const int UNIT_EXP = 100;

		public const int UNIT_EXP_ITEM = 110;

		public const int UNIT_SOUL = 120;

		public const int UNIT_SOUL_ITEM = 130;

		public const int UNIT_LV_UP_GOLD_CANDY = 150;

		public const int UNIT_LV_UP_EXP_CANDY = 151;

		public const int UNIT_LV_UP_CANDY = 152;

		public const int KING_UNIT_LV_UP_GOLD_CANDY = 155;

		public const int KING_UNIT_LV_UP_EXP_CANDY = 156;

		public const int KING_UNIT_LV_UP_CANDY = 157;

		public const int KING_UNIT_POTENTIAL_TIER_UP_CANDY = 170;

		public const int GACHA_1 = 300;

		public const int GACHA_2 = 301;

		public const int GACHA_3 = 302;

		public const int NEW_UNIT_GACHA_ITEM = 303;

		public const int NEW_UNIT_GACHA_BY_SOUL = 304;

		public const int ARTIFACT_GACHA_1 = 350;

		public const int ARTIFACT_GACHA_2 = 351;

		public const int ARTIFACT_GACHA_3 = 352;

		public const int GOLD_400EA = 400;

		public const int EVENT_FLAG = 500;

		public const int SEASONAL_EVENT_FLAG_1000 = 510;

		public const int SEASONAL_EVENT_FLAG_1001 = 511;

		public const int TERRITORY_HUNTING_TICKET = 530;

		public const int KINGS_VOUCHER = 600;

		public const int HEART_VOUCHER = 601;

		public const int FLAG_VOUCHER = 602;

		public const int ALCHEMY_ITEM = 700;

		public const int ALCHEMY_ITEM_KING = 701;

		public const int ALCHEMY_ITEM_GOD = 702;

		public const int ALCHEMY_GACHA_ITEM = 703;

		public const int SKIN_TOKEN = 2001;

		public const int ARENA_TOKEN = 2002;

		public const int CLAN_TOKEN = 2003;

		public const int EVENT_TOKEN = 2004;

		public const int HARD_MODE_TOKEN = 2005;

		public const int COLOSSEUM_OPEN_MISSION_POINT = 2006;

		public const int HARD_MODE_TOKEN2 = 2007;

		public const int TERRITORY_TYCOON_TOKEN_CONSUMABLE = 2008;

		public const int TERRITORY_TYCOON_TOKEN_GACHA = 2009;

		public const int TERRITORY_TYCOON_TOKEN_SKIN = 2010;

		public const int HEART = 2100;

		public const int GOLD = 2101;

		public const int CASH = 2102;

		public const int ARTIFACT_DUST = 2103;

		public const int PASS_POINT = 2104;

		public const int TERRITORY_BUILDING_CORE = 2105;

		public const int TERRITORY_TOWN_HALL_CORE = 2106;

		public const int CASTLE_EXP = 2107;

		public const int CLAN_EXP = 2108;

		public const int LABOR = 2109;

		public const int UNIT_SKIN = 2200;

		public const int FLAG = 2201;

		public const int NAME_TAG = 2202;

		public const int SKIN_CATALOG = 2203;

		public const int TREASURE_COOLTIME_RESET = 2204;

		public const int ACCESSORY_COOLTIME_RESET = 2205;

		public const int REVIVE_COUPON = 2206;

		public const int TERRITORY_BUILDING = 2300;

		public const int TREASURE_PIECE_ITEM = 3000;

		public const int TREASURE_PIECE_ITEM_2 = 3001;

		public const int TREASURE_EXP_ITEM = 3100;

		public const int KING_TREASURE_EXP_ITEM = 3101;

		public const int GOD_TREASURE_EXP_ITEM = 3102;

		public const int TREASURE_OVERCOME_ITEM = 3200;

		public const int ACCESSORY_PIECE_ITEM = 4000;

		public const int ACCESSORY_EXP_ITEM = 4100;

		public const int KING_ACCESSORY_EXP_ITEM = 4101;

		public const int GOD_ACCESSORY_EXP_ITEM = 4102;

		public const int TREASURE_ITEM_ID_START = 3000;

		public const int ACCESSORY_ITEM_ID_END = 4999;

		public static readonly int[] ALCHEMY_ITEM_IDS;
	}

	public static class TerritoryBuildingId
	{
		public const int TOWN_HALL = 10000;

		public const int LABOR_STORAGE = 10100;

		public const int LEVEL_SYNC = 10200;

		public const int HUNTING = 10300;

		public const int ALCHEMY = 10400;

		public const int ATK_PER_STONE = 10500;

		public const int HP_PER_STONE = 10600;

		public const int MATK_PER_STONE = 10700;

		public const int ATK_SPEED_PER_STONE = 10800;

		public const int TRADE_SHOP = 10900;

		public static bool IsStatBuffBuilding(int id)
		{
			return false;
		}
	}

	public static class TerritoryTycoon
	{
		public const int TERRITORY_TYCOON_TOKEN_GEN_SECONDS = 3600;

		public const int TERRITORY_TYCOON_MAX_LEVEL = 9;

		public const int TERRITORY_TYCOON_REQ_BUILDINGS_TO_LEVEL_UP = 2;

		public const int FIREWORK_SOUND_BUILDING = 109900;

		public static int GetFireworkReqPoint(int skipRewardUsedCount)
		{
			return 0;
		}
	}

	public enum TerritoryStatBuffType
	{
		AtkPer = 0,
		MAtkPer = 1,
		HpPer = 2,
		AtkSpeedPer = 3,
		Count = 4
	}

	public static class TerritoryHunting
	{
		public const int SAME_REGION_BONUS = 5;

		public const int BASE_HUNTING_HOUR = 6;
	}

	public static class TerritoryLevelSync
	{
		public static TimeSpan TIME_PER_CASH;
	}

	public static class TerritoryPass
	{
		private static int[] addLaborTable;

		public static int duringDay;

		public static int buildTimePer;

		public static int laborGenPer;

		public static int maxLaborPer;

		public static int huntingTicketCount;

		public static int huntingTimePer;

		public static int huntingRefreshCount;

		public static int levelSyncAssignCount;

		public static int[] arr;

		public static int addLabor => 0;
	}

	public static class Colosseum
	{
		public const int BATTLE_MANAGER_INTERVAL = 776;

		public const int PLAYER_COUNT = 4;

		public const int DEFAULT_INVADE_COST = 3;

		public const int MAX_INVADE_COUNT = 3;

		public const int MAX_INVADE_ITEM_TIER = 6;

		public const int ALARM_UNIT_LEVEL = 6;

		public const int CUSTOM_MATCH_MINIMUM_PLAYER_COUNT = 2;

		public const float TAROT_INTRO_TIME = 5f;
	}

	public static class StarterMission
	{
		public const int ARTIFACT_OPTION_SUM_MISSION_TARGET = 15014;
	}

	public static class ReturnEvent
	{
		public static int CHECK_DAY;

		public static int DURING_DAY;
	}

	public static class UnitBundlePackageIndex
	{
		public static int CLAN;

		public static int HARD_MODE;

		public static int ROGUE_LIKE;

		public static int ARENA;
	}

	public enum StatCategory
	{
		None = 0,
		AttackStat = 1,
		DefenseStat = 2,
		UtilStat = 3
	}

	public static class InvasionSkip
	{
		public const int BASE_COUNT = 2;

		public const int COUNT_IF_PASS_PLUS = 2;

		public const int COUNT_IF_PASS_PREMIUM = 2;

		public const int PASS_PREMIUM_HEART_FREE_COUNT = 2;
	}

	public static bool USE_ONLY_ASSETBUNDLE;

	public static bool LOG;

	public const string ASSET_URL_PREFIX = "https://kgc-cdn-1.awesomepiece.com/patch/";

	public static string DEV_PATCH_SERVER_FOLDER;

	public static string LIVE_PATCH_SERVER_FOLDER;

	public static string DEV_BRANCH;

	public static float REF_RESOLUTION;

	public const int MAX_BUFF_OVERLAP_COUNT = 999;

	public const float INFINITE_TIME = 9999f;

	public const int COMMON_LARGE_INT = 9999;

	public const float COMMON_LARGE_FLOAT = 9999f;

	public const float BIGGER_EPSILON = 0.001f;

	public static Vector3 MIN_POSITION;

	public const int NeedSoulLv = 16;

	public const int GetPotentialLv = 16;

	public const int DO_NOT_USE_TIER1_POTENTIALS = 999;

	public const int CARD_DEFAULT_POTENTIAL_IDX = 100000;

	public const int PLAYER_MAX_LV = 100;

	public static int BuildingMaxPoint;

	public static int UnitMaxLv;

	public static int EliteLevelSetGap;

	public const int SOUL_GACHA_ADD_VALUE = 150;

	public const int ALCHEMY_GACHA_ITEM_ADD_VALUE = 150;

	public static int ADD_MAX_HEART_BY_BUY_PASS;

	public static int ADD_MAX_HEART_BY_BUY_PASS_PREMIUM;

	public static int CartMaxTier;

	public const int FlagMaxCount = 12;

	public const int InvasionChapterCount = 10;

	public const int HardThemeStart = 50;

	public const int InvasionMaxDifficulty = 5;

	public const int InvasionRequireDifficultyToNextTheme = 3;

	public static int KING_BOSS_INCREASE_HP_AMOUNT;

	public static int MergeArtifact_Normal;

	public static int MergeArtifact_King;

	public static int MergeArtifact_God;

	public static int MergeArtifact_KingGod;

	public static int Gold_MergeArtifact_Normal;

	public static int Gold_MergeArtifact_King;

	public static int Gold_MergeArtifact_God;

	public static int Gold_MergeArtifact_KingGod;

	public static int RerollArtifact_Normal;

	public static int RerollArtifact_King;

	public static int RerollArtifact_God;

	public static int RerollArtifact_KingGod;

	public static int Artifact_Option_Max_Level;

	public static int Artifact_Polish_Point_Consumption;

	public static int MAX_DAILY_SHOP_AD_REFRESH_COUNT;

	public static int MAX_DAILY_SHOP_CASH_REFRESH_COUNT;

	public static int SEASON_PASS_NONE;

	public static int SEASON_PASS_NORMAL;

	public static int SEASON_PASS_PLUS;

	public static int SEASON_PASS_PREMIUM;

	public static int[] unitEquipItemIds;

	public const int ROGUE_LIKE_BUILDING_COUNT = 7;

	public const int BUILDING_COUNT = 6;

	public const int DECK_SLOT_COUNT = 10;

	public const int DECK_HERO_COUNT = 6;

	public const int DEFAULT_LATECOMERS_COUNT = 8;

	public const int EVENT_TOKEN_DEFAULT_GAIN = 12;

	public const int EVENT_TOKEN_ADD_GAIN_HEART_AMOUNT = 5;

	public const int PASS_POINT_REWARD = 5;

	public const int MAX_ARTIFACT_COUNT = 3;

	public const int ELITE_COUNT = 5;

	public const int MAX_ELITE_LEVEL_SUM = 15;

	public static int[] ELITE_MAX_LEVELS;

	public static int[] ELITE_ADD_ENEMY_VALUES_PER;

	public const int TERRITORY_LABOR_GEN_SECONDS = 600;

	public const int TERRITORY_STAT_BUFF_BUILDING_COUNT = 4;

	public static int SKIN_MIN_ID;

	public static int DUMMY_SKIN_INDEX;

	public static string CHROMA_SKIN_INFO_ICON_COLOR_CODE;

	public const int PVP_DORMANT_SCORE_DECREASE_INTERVAL_HOUR = 72;

	public const int BATTLE_START_GOLD = 7;

	public const int MAX_FIELD_ITEM_COUNT = 13;

	public const int ROGUE_LIKE_MAX_FIELD_ITEM_COUNT = 14;

	public const int DAILY_GAMEOVER_AD_BONUS_MAX_COUNT = 3;

	public const int GAME_UNIT_MAX_LEVEL = 7;

	public const int MAX_KEY_COUNT = 4;

	public const int MAX_KEY_STACK = 3;

	public static readonly Dictionary<BuffManager.StatType, string> StatNames;

	public static readonly Dictionary<BuffManager.StatValueType, string> StatValueNames;

	public static readonly Dictionary<BuffManager.StatValueType, string> StatValueNamesShorten;

	public static Dictionary<StatCategory, List<(BuffManager.StatType statType, string postfix, string prefix)>> UIAllStats;

	public const int MAX_ARTIFACT_INVENTORY = 999;

	public const int GRAND_ARENA_SCORE = 2000;

	public static ObscuredBool DEVELOPMENT_MODE;

	public static bool APRIL_FOOLS => false;

	public static int PVP_DAILY_BONUS_COUNT => 0;

	public static int PVP_DAILY_BONUS_RATIO => 0;

	public static int GetNextPlayerExp(int level)
	{
		return 0;
	}

	public static int GetBuildingPointCost(int curPoint)
	{
		return 0;
	}

	public static int GetNextUnitExp(CardData card)
	{
		return 0;
	}

	public static int GetNextUnitSoul(CardData card)
	{
		return 0;
	}

	public static int ConvertSoulToAlchemyGachaItem(int soulCount)
	{
		return 0;
	}

	public static int GetFoodBoosterCost(int level)
	{
		return 0;
	}

	public static int GetFoodBoosterReward(int level)
	{
		return 0;
	}

	public static int GetFlagBoosterReward(int level)
	{
		return 0;
	}

	public static bool IsNormalBattle(int themeId)
	{
		return false;
	}

	public static bool IsEventBattle(int themeId)
	{
		return false;
	}

	public static bool IsRerollArtifact(int id)
	{
		return false;
	}

	public static bool IsSpecialArtifact(int id)
	{
		return false;
	}

	public static bool IsMergeArtifact(int id)
	{
		return false;
	}

	public static string GetClanRaidBossTierText(int killCount)
	{
		return null;
	}

	public static int GetRemainExpToMaxRaw(CardData target)
	{
		return 0;
	}

	public static int GetRemainSoulToMaxRaw(CardData target, int additionalMaxLimit = 0)
	{
		return 0;
	}

	public static int GetRemainSoulToMax(CardData target, int additionalMaxLimit = 0)
	{
		return 0;
	}

	public static bool NeedToUpgradePotentialTier(CardData data)
	{
		return false;
	}

	public static bool CheckBuyPassMinType(SeasonPassResponseModel model, int seasonPassType)
	{
		return false;
	}

	public static bool IsBuyPassUnit(SeasonPassResponseModel model)
	{
		return false;
	}

	public static int GetUnitTierTerm(int themeId, int team)
	{
		return 0;
	}

	public static int RogueLikeUnitLevelToOriginLevel(int themeId, int team, int level)
	{
		return 0;
	}

	public static int GetIngameUnitMaxLevel(int themeId, int team)
	{
		return 0;
	}

	public static bool CanPlayRogueLikeLevel()
	{
		return false;
	}

	public static int GetRogueLikeLevel(int level)
	{
		return 0;
	}

	public static Sprite[] GetOvercomeSprites(TreasureModel treasure)
	{
		return null;
	}

	public static string GetPureStatName(string key)
	{
		return null;
	}

	public static Sprite GetStatSprite(string key)
	{
		return null;
	}

	public static Sprite GetAccessorySynergySprite(int synergy)
	{
		return null;
	}

	public static Sprite GetTreasureHexagonFrameSprite(TreasureModel treasure, ResourceTreasure.Rarity rarity = ResourceTreasure.Rarity.None)
	{
		return null;
	}

	public static (string, string) GetItemNameAndDesc(Reward reward)
	{
		return default((string, string));
	}

	public static (string, string) GetItemNameAndDesc(ResourceInventoryItem resInventoryItem, int itemId, int flagSeason = -1, ResourceArtifact resArtifact = null)
	{
		return default((string, string));
	}

	public static bool IsGrandArena(PvPInfoResponseModel pvpData)
	{
		return false;
	}
}
