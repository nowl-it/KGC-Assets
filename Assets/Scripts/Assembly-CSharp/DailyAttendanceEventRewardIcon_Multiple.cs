using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DailyAttendanceEventRewardIcon_Multiple : MonoBehaviour
{
	public List<DailyAttendanceEventRewardIcon> rewardIcons;

	public DailyAttendanceEventRewardIcon rewardIconPrefab;

	public GridLayoutGroup gridLayoutGroup;

	[ComponentConnect]
	public Text day;

	[ComponentConnect]
	public GameObject received;

	[ComponentConnect]
	public Image checkIcon;

	[ComponentConnect]
	public Image completeCheckIcon;

	public void Init(ResourceDailyAttendanceEvent res, bool isRewarded)
	{
	}

	private void InitIcon(string type, int id, int count, bool isRewarded)
	{
	}

	public void ShowRewardAnimation(DailyAttendanceEventRewardIcon_Multiple nextRewardedDayIcon)
	{
	}
}
