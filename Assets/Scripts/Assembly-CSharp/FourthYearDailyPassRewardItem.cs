using Awesomepiece;
using UnityEngine;
using UnityEngine.UI;

public class FourthYearDailyPassRewardItem : MonoBehaviour
{
	[Header("HeartRewardItem")]
	public ClickableShopItemIcon heartRewardItemIcon;

	public Text heartRewardItemCountText;

	public ConditionalGroup heartRewardReceivedCond;

	[Header("PassOnlyRewardItem")]
	public ClickableShopItemIcon passOnlyRewardItemIcon;

	public Text passOnlyRewardItemCountText;

	public ConditionalGroup passOnlyRewardReceivedCond;

	public ConditionalGroup dayCond;

	public void Set(ResourceFourthYearEventReward resEventReward, int day, int currentDay)
	{
	}

	public void SetPassOnlySimple(Reward reward)
	{
	}

	public void OnClickHeartRewardIcon()
	{
	}

	public void OnClickPassOnlyRewardIcon()
	{
	}
}
