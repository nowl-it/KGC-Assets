using System.Collections.Generic;
using Awesomepiece.Model;

public static class CombatPowerCalculator
{
	public static int CalculateCombatPower(IEnumerable<(int level, int potentialTier, List<AccessoryModel> accessoryModels, TreasureModel treasure)> cardInfos, List<ArtifactModel> artifacts, IEnumerable<int> buildings)
	{
		return 0;
	}

	public static float CalculateCardCombatPower(int index, int level, int potentialTier, List<ArtifactModel> artifacts, List<AccessoryModel> accessories, TreasureModel treasure, float territoryStatBuffPersCombatPower)
	{
		return 0f;
	}

	public static float CalculateAccessoriesCombatPower(List<AccessoryModel> accessories)
	{
		return 0f;
	}

	public static float CalculateTreasureCombatPower(TreasureModel treasure)
	{
		return 0f;
	}

	public static float CalculateArtifactsCombatPower(List<ArtifactModel> artifacts)
	{
		return 0f;
	}

	public static float CalculateArtifactOptionsCombatPower(List<ArtifactModel> artifacts, int unitIdx)
	{
		return 0f;
	}

	public static float CalculateTerritoryStatBuffPersCombatPower()
	{
		return 0f;
	}

	public static float CalculateBuildingsCombatPower(IEnumerable<int> buildings, List<ArtifactModel> artifacts)
	{
		return 0f;
	}
}
