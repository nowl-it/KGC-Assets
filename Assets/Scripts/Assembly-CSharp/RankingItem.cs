using Awesomepiece.Model;
using UnityEngine;
using UnityEngine.UI;

public class RankingItem : MonoBehaviour
{
	public Text numText;

	public Text nameText;

	public Text castleText;

	public Text scoreText;

	public Image[] unitImages;

	public Image kingIcon;

	private RankingResponseModel.RankingData _rankingData;

	public void Set(RankingResponseModel.RankingData rankingData, bool my)
	{
	}

	public void OnClick()
	{
	}
}
