using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DailyAttendanceEventPanel_Multiple : MonoBehaviour, IClosable
{
	public GridLayoutGroup gridLayoutGroup;

	public DailyAttendanceEventRewardIcon_Multiple rewardIconPrefab;

	public List<DailyAttendanceEventRewardIcon_Multiple> rewardIcons;

	public Text adBlockDayText;

	public Text canGetRewardDayText;

	public void Show(int eventId, int attendance, bool withOutAnimation = false)
	{
	}

	public void Reload(int eventId, int attendance, bool withOutAnimation)
	{
	}

	public bool Close()
	{
		return false;
	}

	public void OnClickAcceptButton()
	{
	}
}
