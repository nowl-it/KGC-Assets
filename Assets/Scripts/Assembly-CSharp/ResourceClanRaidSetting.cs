using System.Collections.Generic;
using System.Xml;

public static class ResourceClanRaidSetting
{
	public static Dictionary<int, List<int>> RecommendedPartyDict;

	public static List<int> ClanRankRewardReqRanks;

	public static List<int> ClanRankRewardAmounts;

	public static List<int> ClanRankRewardGoldBonus;

	public static int BossKillRewardMaxKillCount;

	private static void Init(XmlNode n)
	{
	}

	public static void Load()
	{
	}
}
