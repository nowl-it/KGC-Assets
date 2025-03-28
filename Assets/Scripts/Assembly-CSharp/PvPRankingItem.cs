using Awesomepiece.Model;
using UnityEngine;
using UnityEngine.UI;

public class PvPRankingItem : MonoBehaviour
{
	public PlayerProfile playerProfile;

	public Text nameText;

	public Text castleText;

	public Text scoreText;

	public Image kingIcon;

	private PvPRankingResponseModel.PvPRankingData _rankingData;

	public void Set(PvPRankingResponseModel.PvPRankingData rankingData, bool my)
	{
	}

	public void OnClick()
	{
	}
}
