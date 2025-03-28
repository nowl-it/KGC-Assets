using UnityEngine;
using UnityEngine.UI;

public class ClanRaidSeasonEndPanel : MonoBehaviour, IComponentConnector
{
	[ComponentConnect]
	public ClanRankingItem clanRankingItem;

	public Text nextClanRaidRemainTime;

	public void Show()
	{
	}

	public void OnClickProgress()
	{
	}

	private void Update()
	{
	}

	public void ReloadNextClanRaidRemainTime()
	{
	}
}
