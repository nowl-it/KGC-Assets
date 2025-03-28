using System.Collections.Generic;
using System.Xml;

namespace Awesomepiece
{
	public struct Reward
	{
		public string type;

		public int id;

		public int count;

		public static int ACCESSORY_SYNERGY;

		public static int ACCESSORY_RARITY;

		public static int ACCESSORY_TYPE;

		public static int ACCESSORY_MAIN_STAT;

		public static int ACCESSORY_OPT_BIT_COUNT;

		public (int synergy, int rarity, int type, string mainStat) accessoryInfo => default((int, int, int, string));

		public Reward(string type, int id, int count)
		{
			this.type = null;
			this.id = 0;
			this.count = 0;
		}

		public int GetRewardHash()
		{
			return 0;
		}

		public static List<Reward> ParseRewards(XmlNode n)
		{
			return null;
		}

		public static Reward ParseReward(XmlNode n)
		{
			return default(Reward);
		}
	}
}
