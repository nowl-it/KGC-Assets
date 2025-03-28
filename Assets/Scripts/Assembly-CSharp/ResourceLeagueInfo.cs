using System.Xml;

public class ResourceLeagueInfo : ResourceBase<ResourceLeagueInfo>
{
	public enum ReqType
	{
		None = 0,
		Rank = 1,
		Point = 2
	}

	public enum LeagueType
	{
		Colosseum = 0,
		PvP = 1
	}

	public class Reward
	{
		public int tier;

		public ReqType reqType;

		public int reqValue;

		public (int skinId, LeagueType type)[] rewardSkins;

		public int GetSkinByLeagueType(LeagueType type)
		{
			return 0;
		}
	}

	public new string name;

	public string rewardTitleLeagueName;

	public int[] topRewardPoints;

	public Reward[] rewards;

	public int fromSeason;

	public int endSeason;

	public override void Init(XmlNode n)
	{
	}

	public static void Load()
	{
	}
}
