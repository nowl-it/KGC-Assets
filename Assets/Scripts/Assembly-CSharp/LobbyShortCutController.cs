public static class LobbyShortCutController
{
	public enum Type
	{
		None = 0,
		BuyHeart = 1,
		Shop = 2,
		Deck = 3,
		Altar = 4,
		ArtifactCraft = 5,
		World = 6,
		GameList = 7,
		Theme = 8,
		EventMode = 9,
		SeasonalEventMode = 10,
		Clan = 11,
		Arena = 12,
		Colosseum = 13,
		Gacha = 14,
		RogueLike = 15,
		Territory = 16,
		Inventory = 17,
		Babel = 18,
		ClanRaid = 19,
		Mission = 20,
		StartOutGameTutorial = 21
	}

	public struct ShortCutInfo
	{
		public Type type;

		public string value;
	}

	private static int GetTabIndex(Type type)
	{
		return 0;
	}

	private static bool CheckLevelLimit(ShortCutInfo info)
	{
		return false;
	}

	public static void DoShortCut(ShortCutInfo info, bool fixTab = false, bool closePopups = true)
	{
	}
}
