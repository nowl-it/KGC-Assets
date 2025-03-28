using System.Collections.Generic;
using System.Xml;
using Awesomepiece;

public class ResourceArenaSetting
{
	public class WinReward
	{
		public int step;

		public int winCount;

		public List<Reward> rewards;

		public WinReward(int step, int winCount, List<Reward> rewards)
		{
		}
	}

	public static List<WinReward> WinRewards;

	public static List<int> WinCounts;

	public static int DailyTrainingCount;

	private static void Init(XmlNode n)
	{
	}

	public static void Load()
	{
	}
}
