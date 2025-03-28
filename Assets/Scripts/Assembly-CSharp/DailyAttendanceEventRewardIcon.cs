using UnityEngine;
using UnityEngine.UI;

public class DailyAttendanceEventRewardIcon : MonoBehaviour
{
	[ComponentConnect]
	public Text day;

	[ComponentConnect]
	public new Text name;

	[ComponentConnect]
	public Image icon;

	[ComponentConnect]
	public Image checkIcon;

	public void Init(ResourceDailyAttendanceEvent res, bool isRewarded)
	{
	}

	public void Init(string type, int id, int count, bool isRewarded)
	{
	}

	public void ShowRewardAnimation()
	{
	}
}
