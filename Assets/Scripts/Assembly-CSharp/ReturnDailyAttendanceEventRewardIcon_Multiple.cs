using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReturnDailyAttendanceEventRewardIcon_Multiple : MonoBehaviour
{
	[SerializeField]
	private DailyAttendanceEventRewardIcon _rewardIconPrefab;

	[SerializeField]
	private GridLayoutGroup _gridLayoutGroup;

	[SerializeField]
	private Text _day;

	[SerializeField]
	private GameObject _received;

	[SerializeField]
	private Image _checkIcon;

	[SerializeField]
	private Image _completeCheckIcon;

	private List<DailyAttendanceEventRewardIcon> _rewardIcons;

	public void Init(ResourceDailyAttendanceEvent res, bool isRewarded)
	{
	}

	private void InitIcon(string type, int id, int count, bool isRewarded)
	{
	}

	public void ShowRewardAnimation(ReturnDailyAttendanceEventRewardIcon_Multiple nextRewardedDayIcon)
	{
	}
}
