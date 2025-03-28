using System;
using System.Collections.Generic;

[Serializable]
public class RogueLikeOutGameStatusSerializable
{
	public Dictionary<int, bool> collectedRune;

	public Dictionary<int, bool> collectedDLCRune;

	public Dictionary<int, bool> collectedArtifact;

	public Dictionary<int, bool> collectedHero;

	public Dictionary<int, bool> collectedGodItem;

	public int totalEventCount;

	public int totalDeathCount;

	public int totalUsedGold;

	public int totalKillCount;

	public Dictionary<int, int> bossKillCount;

	public RogueLikeOutGameStatusSerializable()
	{
	}

	public RogueLikeOutGameStatusSerializable(RogueLikeOutGameStatus unserializable)
	{
	}
}
