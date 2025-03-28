using System.Collections.Generic;
using Awesomepiece.Model;
using UniRx;

public class ColosseumData
{
	public float[,,] additionalInvadeItemWeightPer;

	public float[] additionalInvadeItemTierWeightPer;

	public List<int> invadeItemTierUpThemes;

	public List<int> unlockedInvadeItemIds;

	public List<(int disabled, int replaced)> replaceInvadeItemIDs;

	public int additionalInvadeItemCost;

	public string userId;

	public ColosseumPlayerDataResponseModel.ColosseumPlayerData playerData;

	public int abilityLevel;

	public int abilityExp;

	public readonly List<ResourceColosseumAbility> abilities;

	public readonly List<ResourceColosseumAbility> abilityQueue;

	public int invadePointToAdd;

	public int invadePoint;

	public int maxInvadePoint;

	public IntReactiveProperty colosseumEnemyBerserkValue;

	public List<int> usedInvadeIds;

	public string opponent;

	public int rank;

	public bool lastStageCleared;

	public int lastSurvivedStage;

	public int invadeSuccessCount;

	public ColosseumData(ColosseumPlayerDataResponseModel.ColosseumPlayerData playerData)
	{
	}
}
