using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReturnDailyAttendanceEventPanel : MonoBehaviour, IClosable
{
	[SerializeField]
	private GridLayoutGroup _gridLayoutGroup;

	[SerializeField]
	private ReturnDailyAttendanceEventRewardIcon_Multiple _rewardIconPrefab;

	[SerializeField]
	private Text _dateText;

	private List<ReturnDailyAttendanceEventRewardIcon_Multiple> _rewardIcons;

	public void Show(int eventId, int attendance, bool withOutAnimation = false)
	{
	}

	public void Reload(int eventId, int attendance, bool withOutAnimation)
	{
	}

	private void PlayAnimation(int eventSize, int rewardedDay, int attendance)
	{
	}

	public bool Close()
	{
		return false;
	}

	public void OnClickAcceptButton()
	{
	}

	public void OnClickWelcomePanel()
	{
	}
}
