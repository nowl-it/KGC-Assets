using UnityEngine;

public interface IResourceRankTier
{
	int id { get; set; }

	int reqScore { get; set; }

	bool isChallenger { get; }

	int reqRank { get; set; }

	int GetTier();

	string GetName();

	Sprite GetTierIcon();

	Sprite GetTierStar();

	(string, int, int) GetReward();
}
