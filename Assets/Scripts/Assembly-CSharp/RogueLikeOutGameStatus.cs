using System;
using System.Collections.Generic;
using UniRx;

[Serializable]
public class RogueLikeOutGameStatus
{
	public Dictionary<int, BoolReactiveProperty> collectedRune;

	public Dictionary<int, BoolReactiveProperty> collectedDLCRune;

	public Dictionary<int, BoolReactiveProperty> collectedArtifact;

	public Dictionary<int, BoolReactiveProperty> collectedHero;

	public Dictionary<int, BoolReactiveProperty> collectedGodItem;

	public IntReactiveProperty totalEventCount;

	public int totalDeathCount;

	public int totalUsedGold;

	public int totalKillCount;

	public Dictionary<int, int> bossKillCount;

	public RogueLikeOutGameStatus(RogueLikeOutGameStatusSerializable serializable)
	{
	}
}
