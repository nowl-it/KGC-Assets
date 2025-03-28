using System;

namespace Awesomepiece.Model
{
	[Serializable]
	public class ClanRaidEndBattleRequestModel
	{
		public int damage;

		public int usedTime;

		public bool isPracticeBattle;

		public int deckIdx;

		public long remainDivinePowerDamageAmount;

		public float remainTime;

		public bool isRetrying;
	}
}
