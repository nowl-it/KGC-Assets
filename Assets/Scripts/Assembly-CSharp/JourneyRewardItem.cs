using UnityEngine;
using UnityEngine.UI;

public class JourneyRewardItem : MonoBehaviour
{
	public ClickableShopItemIcon itemIcon;

	public ConditionalGroup itemRewardedConditional;

	public Text itemNameText;

	public Text timeText;

	private ResourceJourneyReward.RewardItem _rewardItem;

	public void Set(ResourceJourneyReward.RewardItem rewardItem)
	{
	}

	public void Reload()
	{
	}
}
