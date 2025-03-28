using Awesomepiece.Model;
using UnityEngine;
using UnityEngine.UI;

public class ClanRankingScoreItem : MonoBehaviour
{
	public PlayerProfile playerProfile;

	public Text userRank;

	public Text scoreText;

	private ClanRankingResponseModel.ClanRankingData _rankingData;

	public void Set(int avatar, int nameTag, int rank, int score, bool hasClan)
	{
	}

	public void SetScoreText(string text)
	{
	}
}
