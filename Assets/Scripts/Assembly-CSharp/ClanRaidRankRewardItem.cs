using UnityEngine;
using UnityEngine.UI;

public class ClanRaidRankRewardItem : MonoBehaviour
{
	[SerializeField]
	private Text _rankText;

	[SerializeField]
	private Text _itemCountText;

	[SerializeField]
	private Text _goldBonusText;

	[SerializeField]
	private ConditionalGroup _firstRankConditional;

	public void Set(ResourceClanRaidRankTier resRank, int itemCount, int goldBonus)
	{
	}

	public void Set(int startRank, int endRank, int itemCount, int goldBonus)
	{
	}

	public void Set(string text, int itemCount, int goldBonus)
	{
	}
}
