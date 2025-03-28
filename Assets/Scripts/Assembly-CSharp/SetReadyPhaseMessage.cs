using System.Collections.Generic;
using Awesomepiece.Model;

public class SetReadyPhaseMessage : BaseMessage
{
	public struct SetReadyPhasePlayerInfo
	{
		public string opponent;

		public int enemyBerserkValue;

		public int winningStreak;
	}

	public Dictionary<string, SetReadyPhasePlayerInfo> playerInfos;
}
