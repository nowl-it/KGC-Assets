using Awesomepiece.Model;
using UnityEngine;
using UnityEngine.UI;

public class LeagueHallOfFameItem : MonoBehaviour
{
	[SerializeField]
	private UnitIllust _illust;

	[SerializeField]
	private PlayerProfile _profile;

	[SerializeField]
	private Text _kingNameText;

	[SerializeField]
	private Text _castleNameText;

	[SerializeField]
	private GameObject _unitSprite;

	private GameObject _unitPrefab;

	public void Set(ColosseumRankingResponseModel.ColosseumRankingData data)
	{
	}

	public void Set(PvPRankingResponseModel.PvPRankingData data)
	{
	}

	private void Set(string userName, string castleName, int kingPostfix, int castlePostfix, int profileIcon, int nameTagId, int rank, int tier)
	{
	}
}
