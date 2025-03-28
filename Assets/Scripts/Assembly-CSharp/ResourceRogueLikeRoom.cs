using System;
using System.Collections.Generic;
using System.Xml;

public class ResourceRogueLikeRoom
{
	public enum Category
	{
		None = 0,
		Boss = 1,
		Elite = 2,
		Shop = 3,
		Special = 4,
		Battle = 5
	}

	public enum Type
	{
		None = 0,
		Start = 1,
		Battle = 2,
		Elite = 3,
		Boss = 4,
		Shop = 5,
		BuildingArtifact = 6,
		Exchange = 7,
		HeroSummon = 8,
		Trial = 9,
		Trial_Accepted = 10,
		Trial_Declined = 11,
		RandomEventRoomStart = 12,
		Event_BloodRedEquipment = 13,
		Event_DarkKnight = 14,
		Event_StrangeOldWoman = 15,
		Event_StrangeBlackSmith = 16,
		Event_GoldenTotem = 17,
		Event_HighPressureSelling = 18,
		Event_LabOfAlchemist = 19,
		Event_Mushroom = 20,
		Event_BrightLight = 21,
		Event_SlimeDen = 22,
		Event_Crusader = 23,
		Event_CorpseOfAdventurer = 24,
		Event_RuneInsideOfBush = 25,
		Event_HunterEncounter = 26,
		Event_Arena = 27,
		Event_Mausoleum = 28,
		Event_Genie = 29,
		Event_TheTruth = 30,
		Event_Library = 31,
		Event_PeopleAndMonster = 32,
		Event_Prison = 33,
		Event_FishingGround = 34,
		Event_Bandit = 35,
		Event_WoundedHerbalist = 36,
		Event_UnluckyMushroom = 37,
		Event_KillerRabbit = 38,
		Event_Trap = 39,
		Event_Trial = 40,
		Event_TrappedHero = 41,
		Event_Mimic = 42,
		RandomEventRoomEnd = 43
	}

	[Serializable]
	public class Spawn : ICloneable
	{
		public int id;

		public int x;

		public int y;

		public int animEventInt;

		public object Clone()
		{
			return null;
		}
	}

	private static bool _loaded;

	private static readonly ResourceRogueLikeRoom[] _array;

	public Type type;

	public Category category;

	public List<(int worldId, int stageId)> stageIds;

	public string map;

	public List<Spawn> fixedSpawns;

	public List<Spawn> randomSpawns;

	public RandomInt randomSpawnCount;

	public int forceSpawnUnseenUnitAfterFloor;

	public int genFromFloor;

	public int genUntilFloor;

	public Type roomClearDefaultRewardType;

	public int enterEvent;

	public int clearEvent;

	public void Init(XmlNode n)
	{
	}

	public static void Load()
	{
	}

	public static ResourceRogueLikeRoom Get(Type type)
	{
		return null;
	}

	public static bool IsEnterAvailableRoomType(Type roomType)
	{
		return false;
	}

	public static bool IsBattleRoom(Type roomType)
	{
		return false;
	}

	public static bool IsNoneBattleRoom(Type roomType)
	{
		return false;
	}

	public static bool IsEventRoom(Type roomType)
	{
		return false;
	}

	public int GetStageID()
	{
		return 0;
	}
}
