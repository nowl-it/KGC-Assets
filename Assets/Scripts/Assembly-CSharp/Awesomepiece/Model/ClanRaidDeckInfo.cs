using System;

namespace Awesomepiece.Model
{
	[Serializable]
	public class ClanRaidDeckInfo
	{
		public int id;

		public int idx;

		public int remainCount;

		public string deckName;

		public ClanRaidDeckData deck;
	}
}
