using System.Collections.Generic;
using UnityEngine;

public class DailyAttendanceEventPanel : MonoBehaviour, IClosable
{
	public List<DailyAttendanceEventRewardIcon> rewardIcons;

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

	public void OnClickClose()
	{
	}
}
