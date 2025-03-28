using Awesomepiece.Model;
using UnityEngine;
using UnityEngine.UI;

public class RogueLikeRankingItem : MonoBehaviour
{
	public Text nameText;

	public Text castleText;

	public Image kingIcon;

	public Text challengeText;

	public Image challengeTextFrame;

	public Text scoreText;

	public PlayerProfile playerProfile;

	private RogueLikeRankingResponseModel.RogueLikeRankingData _rankingData;

	public void Set(RogueLikeRankingResponseModel.RogueLikeRankingData rankingData, bool my, int rank)
	{
	}

	public void OnClick()
	{
	}
}
