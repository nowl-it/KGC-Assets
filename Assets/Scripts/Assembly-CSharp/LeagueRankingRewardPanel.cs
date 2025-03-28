using System;
using UnityEngine;
using UnityEngine.UI;

public class LeagueRankingRewardPanel : MonoBehaviour
{
	[Serializable]
	private struct Skins
	{
		public Text[] skinNames;
	}

	[SerializeField]
	private Text[] rankText;

	[SerializeField]
	private Text[] pointText;

	[SerializeField]
	private Skins[] rewardSkinNames;

	[SerializeField]
	private Image[] rewardSkinImages;

	[SerializeField]
	private Text[] rewardReqText;

	[SerializeField]
	private Text leagueRewardTitle;

	public void Set(ResourceLeagueInfo.LeagueType type)
	{
	}
}
