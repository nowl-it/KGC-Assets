using System;
using System.Collections.Generic;

[Serializable]
public class RogueLikeInGameStatus
{
	public int usedInstantItemCount;

	public int deathCount;

	public int[] visitedRoomCount;

	public Dictionary<int, float> bossKillTime;
}
