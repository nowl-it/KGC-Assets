using Awesomepiece.Model;
using UnityEngine;
using UnityEngine.UI;

public class ColosseumRankingItem : MonoBehaviour
{
	public PlayerProfile playerProfile;

	public Text nameText;

	public Text castleText;

	public Text scoreText;

	public Image kingIcon;

	private ColosseumRankingResponseModel.ColosseumRankingData _rankingData;

	public void Set(ColosseumRankingResponseModel.ColosseumRankingData rankingData, bool my)
	{
	}

	public void OnClick()
	{
	}
}
