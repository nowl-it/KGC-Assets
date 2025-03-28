using UnityEngine;
using UnityEngine.UI;

public class ClanRaidRankRewardPanel : BlurPopupPanel
{
	[SerializeField]
	private GameObject _clanRewardPanel;

	[SerializeField]
	private GameObject _bossTierRewardPanel;

	[SerializeField]
	private Text _titleText;

	[SerializeField]
	private Text _descText;

	[SerializeField]
	private RectTransform _bossTierRewardRect;

	[SerializeField]
	private LayoutFitter _bossTierRewardFitter;

	[SerializeField]
	private ClanRaidRankRewardItem _bossTierRewardPrefab;

	[SerializeField]
	private ClanRaidRankRewardItem _bossTopTierRewardPrefab;

	[SerializeField]
	private RectTransform _clanTierRewardRect;

	[SerializeField]
	private LayoutFitter _clanTierRewardFitter;

	[SerializeField]
	private ClanRaidRankRewardItem _clanTierRewardPrefab;

	[SerializeField]
	private ClanRaidRankRewardItem _clanTopTierRewardPrefab;

	private bool _showClanReward;

	private bool _init;

	public override void Show()
	{
	}

	private void Init()
	{
	}

	public void OnClickToggle()
	{
	}

	private void Reload()
	{
	}
}
