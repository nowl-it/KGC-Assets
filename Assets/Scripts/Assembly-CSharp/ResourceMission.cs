using System;
using System.Collections.Generic;
using System.Xml;
using Awesomepiece.Model;

public class ResourceMission : ResourceBase<ResourceMission>
{
	public enum Type
	{
		Pass = 0,
		Normal = 1,
		Challenge = 2,
		Unit = 3,
		Repeated = 4,
		Beginner = 5,
		Event = 6,
		RogueLikeAchievement = 7,
		Shop = 8,
		Starter = 9
	}

	public enum Category
	{
		None = 0,
		Theme = 1,
		EventMode = 2,
		MaxUnitCount = 3,
		MaxUnitLevel = 4,
		Item = 5,
		Merchant = 6,
		Devil = 7,
		Building = 8,
		InGameGold = 9,
		OutGame = 10,
		Hero = 11,
		Clan = 12,
		RogueLike = 13,
		ColosseumOpen = 14,
		ThirdHalfAnniversary = 15
	}

	public enum EventType
	{
		None = 0,
		TowerEvent = 1,
		HotTimeEvent = 2,
		ColosseumOpen = 3,
		ThirdHalfAnniversary = 4,
		TerritoryTycoon = 5,
		FourthYearEvent = 6
	}

	public enum MatchType
	{
		Equal = 0,
		LessEqual = 1,
		GreaterEqual = 2
	}

	public enum RepeatType
	{
		None = 0,
		Daily = 1,
		Weekly = 2
	}

	public Type type;

	public Category category;

	private string _descFormatKey;

	private List<string> _descArgs;

	public (string type, int value) startCondition;

	public (string type, int value) showCondition;

	public (string type, int value) condition;

	public List<(string type, int value, int id, int amount)> rewards;

	public List<(string type, int value, int id, int amount)> buyPassRewards;

	public string sprite;

	private string _titleKey;

	private List<string> _titleArgs;

	public RepeatType repeatType;

	public LobbyShortCutController.ShortCutInfo shortCutInfo;

	public (float value, MatchType matchType)? param;

	public int reqRogueLikeDlc;

	public (int min, int max) ingameMissionInfoShowThemes;

	public List<int> ingameMissionInfoShowExcludeThemes;

	public int theme;

	public int difficulty;

	public int passPoint;

	public int missionDay;

	public int missionStep;

	public int missionSubStep;

	public EventType eventType;

	public string title => null;

	public bool hasShortCut => false;

	public static int totalRogueLikeMissionCount => 0;

	public int keyCount => 0;

	public string GetDesc()
	{
		return null;
	}

	public override void Init(XmlNode n)
	{
	}

	public static void Load(Action callback = null)
	{
	}

	private bool CheckCondition(string conditionType, int conditionValue, Func<MissionData, bool> additionalCondition = null)
	{
		return false;
	}

	public bool CheckShowCondition(Func<MissionData, bool> clearedMissionShowCondition = null)
	{
		return false;
	}

	public bool CheckStartCondition(Func<MissionData, bool> clearedMissionStartCondition = null)
	{
		return false;
	}

	public static List<MissionData> GetDefaultRogueLikeMissions()
	{
		return null;
	}

	public static bool NormalMissionShowCondition(MissionData missionData)
	{
		return false;
	}
}
